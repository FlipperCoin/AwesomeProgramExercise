using System;
using AwesomeProgram.Common;
using AwesomeProgram.Core;

namespace AwesomeProgram.Base
{
    public class FrameFactory : IFrameFactory
    {
        public Frame CreateFrame(string awesomeParam1, int awesomeParam2, byte[] awesomeParam3)
        {
            return new Frame();
        }
    }
}