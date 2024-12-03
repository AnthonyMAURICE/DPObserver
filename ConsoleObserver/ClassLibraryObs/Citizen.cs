using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObs
{
    public abstract class Citizen : Person
    {
        
        protected string candidate = "Designated Candidate";

        public string Candidate { get => candidate; set => candidate = value; }

        public abstract void Vote();

    }
}
