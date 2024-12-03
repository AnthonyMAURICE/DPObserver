using ClassLibraryObs.ObserverFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObs
{
    public interface ISubject
    {
        void AddObserver(IObserver<Person> subscriber);
        void RemoveObserver(Security subscriber);
        void NotifyObserver();
        void HasBeenObserved(Security observer);
    }
}
