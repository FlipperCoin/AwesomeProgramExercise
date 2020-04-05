using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeProgram.Core
{
    public interface IAggregator<T>
    {
        void AddItem(T item);
        event Action<IEnumerable<T>> OnNewItemGroup;
    }
}
