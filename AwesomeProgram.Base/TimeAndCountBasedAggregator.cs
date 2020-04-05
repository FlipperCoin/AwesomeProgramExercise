using System;
using System.Collections.Generic;
using AwesomeProgram.Core;

namespace AwesomeProgram.Base
{
    public class TimeAndCountBasedAggregator<T> : IAggregator<T>
    {
        private readonly ITimer _timer;
        private readonly int _maxItems;
        private readonly ILogger _logger;
        private readonly IMetrics _metrics;

        public event Action<IEnumerable<T>> OnNewItemGroup;

        public TimeAndCountBasedAggregator(TimeSpan maxTime, int maxItems, ILogger logger, IMetrics metrics) : 
            this(new TimerWrapper(), maxItems, logger, metrics)
        {
            
        }

        public TimeAndCountBasedAggregator(ITimer timer, int maxItems, ILogger logger, IMetrics metrics)
        {
            _timer = timer;
            _maxItems = maxItems;
            _logger = logger;
            _metrics = metrics;
        }

        public void AddItem(T item)
        {
            
        }
    }
}