using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Constants;
using Data.Models;
using Newtonsoft.Json;
using SocketIOClient;
using SocketIOClient.Newtonsoft.Json;
using UnityEngine;

namespace Data.Socket
{
    public class SocketManager : MonoBehaviour
    {
        public SocketIOUnity socket;
        public static SocketManager Instance;

        // Actions
        public Action onConnected;
        public Action onDisconnected;
        public Action onError;

        private Queue<Action> mainThreadActions = new Queue<Action>();

        [SerializeField]
        public bool isConnected = false; // Flag to check connect status

        private SocketManager() { }

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public async Task Init(string token)
        {
            if (socket != null && isConnected) // Avoid re-init after connected
            {
                Debug.LogWarning("SocketManager already connected. Skipping Init.");
                return;
            }

            socket = new SocketIOUnity(
                SocketConstants.BaseUri.ToString(),
                new SocketIOOptions
                {
                    Auth = new Dictionary<string, string> { { "token", token } },
                    Transport = SocketIOClient.Transport.TransportProtocol.WebSocket,
                }
            );

            socket.JsonSerializer = new NewtonsoftJsonSerializer();

            socket.OnConnected += (sender, e) =>
                EnqueueAction(() =>
                {
                    isConnected = true;
                    onConnected?.Invoke();
                });

            socket.OnError += (sender, e) => EnqueueAction(() => onError?.Invoke());

            socket.OnDisconnected += (sender, e) =>
                EnqueueAction(() =>
                {
                    isConnected = false;
                    onDisconnected?.Invoke();
                });

            try
            {
                await socket.ConnectAsync();
            }
            catch (Exception ex)
            {
                Debug.Log("Connection error: " + ex.ToString());
                throw;
            }
        }

        public void Disconnect()
        {
            if (socket != null && isConnected)
            {
                socket.Disconnect();
                isConnected = false; // Set isConnected flag when disconnect
            }
        }

        public void Emit(string eventName, object data)
        {
            if (socket != null && isConnected)
            {
                socket.Emit(eventName, data);
            }
            else
            {
                Debug.LogWarning("Cannot emit, socket is not connected!");
            }
        }

        public async Task<T> EmitWithAck<T>(string eventName, string cmd, object data = null)
        {
            if (!socket.Connected)
            {
                Debug.LogWarning("Can not requested when socket is not connected");
                return default(T);
            }

            var tcs = new TaskCompletionSource<T>();

            var payload = new SocketPayload<dynamic> { cmd = cmd, @params = data };

            try
            {
                string jsonPayload = JsonConvert.SerializeObject(payload);

                await socket.EmitAsync(
                    eventName,
                    ack =>
                    {
                        T response = ack.GetValue<T>();
                        tcs.SetResult(response);
                    },
                    jsonPayload
                );

                return await tcs.Task;
            }
            catch (Exception ex)
            {
                Debug.Log(ex.ToString());
                return default(T);
            }
        }

        public void On<T>(string eventName, Action<SocketIOResponse> callback)
        {
            if (socket != null)
            {
                socket.On(eventName, (response) => EnqueueAction(() => callback(response)));
            }
        }

        private void EnqueueAction(Action action)
        {
            lock (mainThreadActions)
            {
                mainThreadActions.Enqueue(action);
            }
        }

        private void Update()
        {
            lock (mainThreadActions)
            {
                while (mainThreadActions.Count > 0)
                {
                    mainThreadActions.Dequeue()?.Invoke();
                }
            }
        }

        private void OnDestroy()
        {
            if (socket != null)
            {
                socket.Disconnect();
            }
        }
    }
}
