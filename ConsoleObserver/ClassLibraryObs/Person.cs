using ClassLibraryObs;
using System;

namespace ClassLibraryObs
{
    public abstract class Person : IObservable<Person>
    {
        protected string name = string.Empty;
        protected string message = string.Empty;     
        protected List<IObserver<Person>> obs = [];
        protected Random random = new();


        public string Message { get => message; }
        public string Name { get => name; }


        public abstract void Encrypt();

        public void AddObserver(IObserver<Person> observer)
        {
            this.obs.Add(observer);
        }

        public void RemoveObserver(IObserver<Person> observer)
        {
            this.obs.Remove(observer);
        }

        public IDisposable Subscribe(IObserver<Person> observer)
        {
            if (!this.obs.Contains(observer))
            {
                this.obs.Add(observer);
            }
            return new SecurityNetwork(this.obs, observer);
        }

        public void Unsubscribe(IObserver<Person> observer)
        {
            if (this.obs.Contains(observer))
            {
                this.obs.Remove(observer);
            }
        }

        public void NotifyObservers()
        {
            foreach (IObserver<Person> observer in this.obs)
            {
                observer.OnNext(this);
            }
        }
    }
}
