using System;
using System.Collections.Generic;
using System.Text;
using AwesomeProgram.Common;

namespace AwesomeProgram.Core
{
    public interface IPacketParser
    {
        Packet Parse(Frame frame);
    }
}
