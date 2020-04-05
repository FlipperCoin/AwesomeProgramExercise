using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeProgram.Core
{
    public interface IDispatcher : IAsyncStartable
    {
        void Dispatch(byte[] data);
    }
}
