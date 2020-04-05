using System;
using System.Collections.Generic;
using System.Text;
using AwesomeProgram.Common;
using AwesomeProgram.Core;

namespace AwesomeProgram.Base
{
    public class PacketParser : IPacketParser
    {
        private readonly IPacketFactory _packetFactory;
        private readonly ILogger _logger;
        private readonly IMetrics _metrics;

        public PacketParser(IPacketFactory packetFactory, ILogger logger, IMetrics metrics)
        {
            _packetFactory = packetFactory;
            _logger = logger;
            _metrics = metrics;
        }

        public Packet Parse(Frame frame)
        {
            return _packetFactory.CreatePacket(string.Empty, default(int), Array.Empty<float>(), Array.Empty<byte>());
        }
    }
}
