using System;
using System.Threading.Tasks;
using AwesomeProgram.Core;

namespace AwesomeProgram.Base
{
    public class RabbitMQDispatcher : IDispatcher
    {
        private readonly string _host;
        private readonly int _port;
        private readonly string _exchange;

        public RabbitMQDispatcher(string host, int port, string exchange)
        {
            _host = host;
            _port = port;
            _exchange = exchange;
        }

        public void Dispatch(byte[] data)
        {

        }

        public Task StartAsync()
        {
            return Task.Delay(1500);
        }
    }
}