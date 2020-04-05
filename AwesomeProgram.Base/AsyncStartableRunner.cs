using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeProgram.Core;

namespace AwesomeProgram.Base
{
    public class AsyncStartableRunner : IAsyncStartableRunner
    {
        private readonly IEnumerable<IAsyncStartable> _asyncStartables;
        private readonly ILogger _logger;
        private readonly IMetrics _metrics;

        public AsyncStartableRunner(IEnumerable<IAsyncStartable> asyncStartables, ILogger logger, IMetrics metrics)
        {
            _asyncStartables = asyncStartables;
            _logger = logger;
            _metrics = metrics;
        }

        public void StartSync()
        {
            StartAsync().Wait();
        }

        public Task StartAsync()
        {
            Task[] runningStartables = _asyncStartables.Select(startable => startable.StartAsync()).ToArray();

            return Task.WhenAll(runningStartables);
        }
    }
}
