using ClassLibraryObs.ObserverFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryObs
{
    public class DoubleAgent : Citizen
    {
        public DoubleAgent(string _name)
        {
            this.name = _name;
        }
        public override void Encrypt()
        {
            this.message = "Я не шпион, клянусь !";
            this.NotifyObservers();
        }

        public override void Vote()
        {
            this.candidate = "Designated Candidate";
            this.NotifyObservers();
        }
    }
}
