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
        private SocketIOUnity socket;

        public async Task Init(string token)
        {
            socket = new SocketIOUnity(SocketConstants.BaseUri.ToString(), new SocketIOOptions
            {
                Auth = new Dictionary<string, string>{
              { "token", token }
            },
                Transport = SocketIOClient.Transport.TransportProtocol.WebSocket
            });

            // socket.JsonSerializer = new JsonSerializer();

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
                    string rawAckJson = ack.GetValue().ToString();
                    Debug.Log($"SocketManager: Raw ACK JSON for event {eventName}: {rawAckJson}");
                    T response = ack.GetValue<T>();
                    Debug.Log($"SocketManager: Deserialized object (T={typeof(T).Name}): {Newtonsoft.Json.JsonConvert.SerializeObject(response, Formatting.Indented)}");
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
