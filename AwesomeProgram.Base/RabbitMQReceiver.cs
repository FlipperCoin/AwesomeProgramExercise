using System;
using System.Threading.Tasks;
using AwesomeProgram.Core;

namespace AwesomeProgram.Base
{
    public class RabbitMQReceiver : IReceiver
    {
        public event Action<byte[]> OnDataReceived;

        public RabbitMQReceiver(string host, int port, string exchange)
        {
            
        }

        public Task StartAsync()
        {
            return Task.Delay(1500);
        }
    }
}