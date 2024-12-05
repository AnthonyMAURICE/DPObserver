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
            this.message = (this.random.Next(1, 4) == 2) ? "Я суперсекретный шпион !" : "I'm not a spy, I swear !";
            this.NotifyObservers();
        }

        public override void Vote()
        {
            this.candidate = (this.random.Next(1, 4) == 2) ? "Other Candidate" : "Designated Candidate";
            this.NotifyObservers();
        }
    }
}
