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
        void AddObserver(ICitizenObserver subscriber);
        void RemoveObserver(ICitizenObserver subscriber);
        void NotifyObserver();
        void HasBeenObserved(ICitizenObserver observer);
    }
}
