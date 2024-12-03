using ClassLibraryObs;
using System;

namespace ClassLibraryObs
{
    public abstract class Person : IObservable<Person>
    {
        protected string name = string.Empty;
        protected string message = "I'm not a spy, I swear !";     
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
            if (!obs.Contains(observer))
            {
                obs.Add(observer);
            }
            return new Test(obs, observer);
        }

        public void Unsubscribe(IObserver<Person> observer)
        {
            if (obs.Contains(observer))
            {
                obs.Remove(observer);
            }
        }

        public void NotifyObservers()
        {
            foreach (IObserver<Person> observer in obs)
            {
                observer.OnNext(this);
            }
        }
    }
}
