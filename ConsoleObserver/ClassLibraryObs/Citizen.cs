using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObs
{
    public abstract class Citizen(string _name) : Person(_name)
    {
        
        protected string vote = "Designated Candidate";

        public string Vote { get => vote; set => vote = value; }

        public override void AddObserver()
        {
            this.AddObserver(this.Counterintelligence);
            this.AddObserver(this.SecretPolice);
        }
    }
}
