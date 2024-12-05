using ClassLibraryObs.ObserverFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObs
{
    public class Tourist : Person
    {
        public Tourist(string _name)
        {
            this.name = _name;
        }
        public void AddObserver(Counterintelligence counterintelligence)
        {
            this.obs.Add(counterintelligence);
        }

        public override void Encrypt()
        {
            this.message = (this.random.Next(1, 5) == 2)? "Я не шпион, клянусь !" : "I'm not a spy, I swear !";
            this.NotifyObservers();
        }
    }
}
