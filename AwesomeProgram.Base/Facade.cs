using System;
using System.Collections.Generic;
using System.Text;
using AwesomeProgram.Common;
using AwesomeProgram.Core;

namespace AwesomeProgram.Base
{
    public class Facade : IFacade
    {
        private readonly IReceiver _receiver;
        private readonly IFrameReassembler _frameReassembler;
        private readonly IPacketParser _packetParser;
        private readonly IAggregator<Packet> _aggregator;
        private readonly ISerializer<IEnumerable<Packet>> _packetsSerializer;
        private readonly IDispatcher _dispatcher;
        private readonly ILogger _logger;
        private readonly IMetrics _metrics;

        public Facade(IReceiver receiver, IFrameReassembler frameReassembler, IPacketParser packetParser, IAggregator<Packet> aggregator, ISerializer<IEnumerable<Packet>> packetsSerializer, IDispatcher dispatcher, ILogger logger, IMetrics metrics)
        {
            _receiver = receiver;
            _frameReassembler = frameReassembler;
            _packetParser = packetParser;
            _aggregator = aggregator;
            _packetsSerializer = packetsSerializer;
            _dispatcher = dispatcher;
            _logger = logger;
            _metrics = metrics;
        }

        public void Init()
        {
            _receiver.OnDataReceived += _frameReassembler.AddData;

            _frameReassembler.OnNewFrame += (frame) =>
            {
                Packet packet = _packetParser.Parse(frame);
                _aggregator.AddItem(packet);
            };

            _aggregator.OnNewItemGroup += (groupedItems) =>
            {
                byte[] serializedGroup = _packetsSerializer.Serialize(groupedItems);
                _dispatcher.Dispatch(serializedGroup);
            };
        }
    }
}
