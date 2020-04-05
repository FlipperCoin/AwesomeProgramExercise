using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeProgram.Runner
{
    class Configuration
    {
        public RabbitParams Receiver { get; set; }
        public RabbitParams Dispatcher { get; set; }
        public AggregatorParams OutputAggregation { get; set; }
    }

    internal class RabbitParams
    {
        public string Hostname { get; set; }
        public int Port { get; set; }
        public string Exchange { get; set; }
    }

    internal class AggregatorParams
    {
        public int MaxSeconds { get; set; }
        public int MaxItems { get; set; }
    }
}
