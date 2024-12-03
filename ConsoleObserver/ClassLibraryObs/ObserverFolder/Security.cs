using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObs.ObserverFolder
{
    public abstract class Security : IObserver<Person>
    {   
        private readonly IDisposable? _disposed;
        public abstract void OnCompleted();
        public abstract void OnError(Exception error);
        public abstract void OnNext(Person value);

        public void Unsubscribe()
        {
            _disposed?.Dispose();
        }

    }
}
