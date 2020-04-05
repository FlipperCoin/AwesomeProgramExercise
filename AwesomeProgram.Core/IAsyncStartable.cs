using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeProgram.Core
{
    public interface IAsyncStartable
    {
        Task StartAsync();
    }
}
