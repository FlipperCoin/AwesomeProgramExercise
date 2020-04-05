using System;
using System.Collections.Generic;
using System.Text;
using AwesomeProgram.Common;

namespace AwesomeProgram.Core
{
    public interface IFrameReassembler
    {
        void AddData(byte[] data);
        event Action<Frame> OnNewFrame;
    }
}
