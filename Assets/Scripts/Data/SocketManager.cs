using System.Collections.Generic;
using SocketIOClient;
using System;
using System.Threading.Tasks;
using Data.Constants;
using Data.Models;
using UnityEngine;
using Newtonsoft.Json;

namespace Data.Socket
{
    public class SocketManager
    {
        private static SocketManager _instance;
        public static SocketManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SocketManager();
                }
                return _instance;
            }
        }

        public SocketIOUnity socket;

        private SocketManager() { }

        public async Task Init(string token)
        {
            if (socket != null && socket.Connected) // Tránh init lại nếu đã kết nối
            {
                Debug.LogWarning("SocketManager already connected. Skipping Init.");
                return;
            }

            socket = new SocketIOUnity(SocketConstants.BaseUri.ToString(), new SocketIOOptions
            {
                Auth = new Dictionary<string, string>{
              { "token", token }
            },
                Transport = SocketIOClient.Transport.TransportProtocol.WebSocket
            });

            socket.JsonSerializer = new SocketIOClient.Newtonsoft.Json.NewtonsoftJsonSerializer();

            socket.OnConnected += (sender, e) =>
            {
                Debug.Log("User connected");
            };

            socket.OnDisconnected += (sender, e) =>
            {
                Debug.Log("User disconnected");
            };

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

        public async Task<T> EmitWithAck<T>(
            string eventName,
            string cmd,
            object data = null
        )
        {
            if (!socket.Connected)
            {
                Debug.LogWarning("Can not requested when socket is not connected");
                return default(T);
            }

            var tcs = new TaskCompletionSource<T>();

            var payload = new SocketPayload<dynamic>
            {
                cmd = cmd,
                @params = data
            };

            try
            {
                string jsonPayload = JsonConvert.SerializeObject(payload);

                await socket.EmitAsync(eventName, ack =>
                {
                    T response = ack.GetValue<T>();
                    tcs.SetResult(response);
                }, jsonPayload);

                return await tcs.Task;
            }
            catch (Exception ex)
            {
                Debug.Log(ex.ToString());
                return default(T);
            }
        }
    }
}
