using ClassLibraryObs.ObserverFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryObs
{
    public class RegularCitizen : Citizen
    {
        public RegularCitizen(string _name)
        {
            this.name = _name;
        }
        public override void Encrypt()
        {
            if (this.random.Next(1, 4) == 2)
            {
                this.message = "Я суперсекретный шпион !";
            }
            else
            {
                this.message = "I'm not a spy, I swear !";
            }
            this.NotifyObservers();
        }

        public override void Vote()
        {
            if (this.random.Next(1, 4) == 2) 
            {
                this.candidate = "Other Candidate";
            }
            else
            {
                this.candidate = "Designated Candidate";
            }
            this.NotifyObservers();
        }
    }
}
