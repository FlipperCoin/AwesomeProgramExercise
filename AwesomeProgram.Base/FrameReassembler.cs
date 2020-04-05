using System;
using AwesomeProgram.Common;
using AwesomeProgram.Core;

namespace AwesomeProgram.Base
{
    public class FrameReassembler : IFrameReassembler
    {
        private readonly IFrameFactory _frameFactory;
        private readonly ILogger _logger;
        private readonly IMetrics _metrics;
        public event Action<Frame> OnNewFrame;

        public FrameReassembler(IFrameFactory frameFactory, ILogger logger, IMetrics metrics)
        {
            _frameFactory = frameFactory;
            _logger = logger;
            _metrics = metrics;
        }

        public void AddData(byte[] data)
        {
            
        }
    }
}