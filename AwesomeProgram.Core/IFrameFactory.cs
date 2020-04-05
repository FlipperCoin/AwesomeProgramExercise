using System.Collections.Generic;
using System.Text;
using AwesomeProgram.Common;

namespace AwesomeProgram.Core
{
    public interface IFrameFactory
    {
        Frame CreateFrame(string awesomeParam1, int awesomeParam2, byte[] awesomeParam3);
    }
}
