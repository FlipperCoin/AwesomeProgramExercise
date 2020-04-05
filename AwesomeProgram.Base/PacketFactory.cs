using System;
using System.Collections.Generic;
using System.Text;
using AwesomeProgram.Common;
using AwesomeProgram.Core;

namespace AwesomeProgram.Base
{
    public class PacketFactory : IPacketFactory
    {
        public Packet CreatePacket(string awesomeParam1, int awesomeParams2, float[] awesomeParams3, byte[] awesomeParam4)
        {
            return new Packet();
        }
    }
}
