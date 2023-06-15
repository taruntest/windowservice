using Azure.Storage.Queues;
using System;
using System.Threading.Tasks;
using System.Timers;

namespace MessageSenderService
{
    public class HeartbeatService
    {
        readonly Timer _timer;
        private readonly string serviceName;
        private QueueClient _queueClient;

        public HeartbeatService(string serviceName, string connectionString)
        {
            _timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds) { AutoReset = true };
            _timer.Elapsed += async (sender, eventArgs) => await SendHeartbeat();
            _queueClient = new QueueClient(connectionString, "heartbeat");
            this.serviceName = serviceName;
        }

        public void Start() { _timer.Start(); }
        public void Stop() { _timer.Stop(); }

        private async Task SendHeartbeat()
        {
            await _queueClient.SendMessageAsync($"Heartbeat from {serviceName} {DateTime.Now}");
        }
    }
}
