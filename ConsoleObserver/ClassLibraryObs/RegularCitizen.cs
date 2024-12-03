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
            this.Name = _name;
        }
        public override void Encrypt()
        {
            
            if (this.random.Next(1, 4) == 2)
            {
                this.message = "Я суперсекретный шпион !";
            }
            this.NotifyObservers();
        }

        public override void Vote()
        {
            
            if (this.random.Next(1, 4) == 2) 
            {
                this.candidate = "Other Candidate";
            }
            this.NotifyObservers();
        }
    }
}
