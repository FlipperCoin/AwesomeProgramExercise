using System;
using AwesomeProgram.Core;

namespace AwesomeProgram.Base
{
    public class YamlSerializer<T> : ISerializer<T>
    {
        public byte[] Serialize(T obj)
        {
            return Array.Empty<byte>();
        }
    }
}