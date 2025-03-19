using clp_front_end.src.utils;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace clp_front_end.src.clients
{
    public class WebSocketClient
    {
        private readonly string wsUrl = "ws://localhost:8000/ws/industrialTreadMill";
        private ClientWebSocket client;
        private readonly CancellationTokenSource globalCts = new CancellationTokenSource();
        private readonly CancellationTokenSource cts = new CancellationTokenSource();
        private bool isReconnecting = false;

        public event Action<string> OnMessageReceived;
        public event Action OnConnected;
        public event Action OnDisconnected;
        public bool IsConnected()
        {
            return client?.State == WebSocketState.Open;
        }

        public WebSocketClient()
        {            
            _ = ConnectToWebSocket();
        }

        private async Task ConnectToWebSocket()
        {
            while (true)
            {
                try
                {
                    client = new ClientWebSocket();
                    await client.ConnectAsync(new Uri(wsUrl), cts.Token);

                    ServiceLogger.Log("Conectado", EventLogEntryType.Information);

                    OnConnected?.Invoke();

                    _ = ListenMessages();

                    break;
                }
                catch (Exception ex)
                {                    
                    ServiceLogger.Log($"Houve um erro ao conectar no WebSocket: {ex.Message}", EventLogEntryType.Error);
                    await Task.Delay(5000);
                }
            }
        }

        public async Task SendMessage<T>(string eventName, T data)
        {
            try
            {
                if (client?.State != WebSocketState.Open)
                {
                    ServiceLogger.Log("Não está conectado", EventLogEntryType.Warning);
                    return;
                }

                var message = new
                {
                    @event = eventName,
                    data
                };

                string jsonMessage = JsonConvert.SerializeObject(message);
                byte[] messageBytes = Encoding.UTF8.GetBytes(jsonMessage);
                await client.SendAsync(new ArraySegment<byte>(messageBytes), WebSocketMessageType.Text, true, CancellationToken.None);
            }
            catch (Exception ex)
            {
                ServiceLogger.Log($"Falha ao enviar mensagem: {ex.Message}", EventLogEntryType.Error);
            }
        }

        private async Task ListenMessages()
        {            
            try
            {                
                byte[] buffer = new byte[4096];

                while (client.State == WebSocketState.Open)
                {
                    var result = await client.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        ServiceLogger.Log("Encerrou a conexão!", EventLogEntryType.Warning);
                        await Reconnect();
                        break;
                    }

                    string message = Encoding.UTF8.GetString(buffer, 0, result.Count);
                    OnMessageReceived?.Invoke(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Mesagem {ex.Message}");
                ServiceLogger.Log($"Falha ao receber mensagem: {ex.Message}", EventLogEntryType.Error);
                await Reconnect();
            }
        }

        public async Task Reconnect()
        {
            if (isReconnecting || globalCts.IsCancellationRequested) return;
            isReconnecting = true;

            await Task.Delay(5000);

            if (!globalCts.IsCancellationRequested)
            {
                await ConnectToWebSocket();
            }

            isReconnecting = false;
        }


        public async Task CloseConnection()
        {
            if (client?.State == WebSocketState.Open)
            {
                globalCts.Cancel();
                await client.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, "Conexão encerrada", CancellationToken.None);
                ServiceLogger.Log("Conexão encerrada manualmente.", EventLogEntryType.Information);
            }
        }
    }
}
