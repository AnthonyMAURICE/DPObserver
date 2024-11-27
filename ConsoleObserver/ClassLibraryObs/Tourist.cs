using ClassLibraryObs.ObserverFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObs
{
    public class Tourist(string _name) : Person(_name)
    {
        public void RandomizedSpy()
        {
            Random rnd = new Random();
            if(rnd.Next(1,5) == 2)
            {
                Encrypt();
            }
            this.NotifyObserver();
        }

        public void AddObserver(Counterintelligence counterintelligence)
        {
            this.obs.Add(counterintelligence);
        }

        private void Encrypt()
        {
            this.message = "Я не шпион, клянусь !"; 
        }

    }
}
