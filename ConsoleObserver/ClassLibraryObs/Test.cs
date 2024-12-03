using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObs
{
    internal class Test : IDisposable
    {
        private List<IObserver<Person>> _observers;
        private IObserver<Person> _observer;

        public Test(List<IObserver<Person>> observers, IObserver<Person> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}
