using ClassLibraryObs;
using ClassLibraryObs.ObserverFolder;

namespace ClassLibraryObs
{
    public abstract class Person : ISubject
    {
        private string name = string.Empty;

        protected string message = "I'm not a spy, I swear !";     
        protected List<ICitizenObserver> subs = [];

        private Counterintelligence counterintelligence = new();
        private SecretPolice secretPolice = new();

        public string Message { get => message; set => message = value; }
        public string Name { get => name; set => name = value; }
        protected Counterintelligence Counterintelligence { get => counterintelligence; set => counterintelligence = value; }
        protected SecretPolice SecretPolice { get => secretPolice; set => secretPolice = value; }

        public Person() 
        {
            this.name = "Random Person";
        }

        public Person (string _name)
        {
            this.name = _name;
        }

        public abstract void AddObserver();

        public void AddObserver(ICitizenObserver subscriber)
        {
            this.subs.Add(subscriber);
        }

        public void NotifyObserver()
        {
            foreach (ICitizenObserver subscriber in this.subs)
            {
                subscriber.Update(this);
            }
        }

        public void RemoveObserver(ICitizenObserver subscriber)
        {
            this.subs.Remove(subscriber);
        }

    }
}
