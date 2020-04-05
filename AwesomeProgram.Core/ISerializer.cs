using System.Collections.Generic;
using System.Text;

namespace AwesomeProgram.Core
{
    public interface ISerializer<T>
    {
        byte[] Serialize(T obj);
    }
}
