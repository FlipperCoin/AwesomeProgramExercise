using System;
using System.Collections.Generic;
using System.Text;
using AwesomeProgram.Common;

namespace AwesomeProgram.Core
{
    public interface IPacketFactory
    {
        Packet CreatePacket(string awesomeParam1, int awesomeParams2, float[] awesomeParams3, byte[] awesomeParam4);
    }
}
