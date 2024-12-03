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
            this.Name = _name;
        }
        public void AddObserver(Counterintelligence counterintelligence)
        {
            this.obs.Add(counterintelligence);
        }

        public override void Encrypt()
        {
            if (this.random.Next(1, 5) == 2)
            {
                this.message = "Я не шпион, клянусь !";
            }
            this.NotifyObservers();
        }
    }
}
