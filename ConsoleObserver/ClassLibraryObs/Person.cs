using ClassLibraryObs;
using ClassLibraryObs.ObserverFolder;

namespace ClassLibraryObs
{
    public abstract class Person : ISubject
    {
        private string name = string.Empty;
        private bool busted = false;
        private bool spy = false;
        private bool ci = false;
        private bool sp = false;
        protected string message = "I'm not a spy, I swear !";     
        protected List<ICitizenObserver> obs = [];

        public string Message { get => message; set => message = value; }
        public string Name { get => name; set => name = value; }
        public bool Sp { get => sp; set => sp = value; }
        public bool Ci { get => ci; set => ci = value; }
        public bool Busted { get => busted; set => busted = value; }
        public bool Spy { get => spy; set => spy = value; }

        public Person() 
        {
            this.name = "Random Person";
        }

        public Person (string _name)
        {
            this.name = _name;
        }

        public void AddObserver(ICitizenObserver observer)
        {
            this.obs.Add(observer);
        }

        public void NotifyObserver()
        {
            foreach (ICitizenObserver observer in this.obs)
            {
                observer.Update(this);
            }
        }

        public void RemoveObserver(ICitizenObserver observer)
        {
            this.obs.Remove(observer);
        }

        public void HasBeenObserved(ICitizenObserver observer)
        {
            if (observer.GetType() == typeof(WFSecretPolice))
            {
                this.busted = true;
            }
            else
            {
                this.spy = true;
            }
        }
    }
}
