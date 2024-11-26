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
        public Tourist(string _name) : base(_name)
        {
            
        }
        public void RandomizedSpy()
        {
            Random rnd = new Random();
            if(rnd.Next(1,5) == 2)
            {
                Encrypt();
            }
            this.NotifyObserver();
        }

        public override void AddObserver()
        {
            this.AddObserver(this.Counterintelligence);
        }

        private void Encrypt()
        {
            this.message = "Я не шпион, клянусь !"; 
        }

    }
}
