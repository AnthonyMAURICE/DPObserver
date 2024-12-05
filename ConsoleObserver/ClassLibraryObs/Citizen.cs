using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObs
{
    public abstract class Citizen : Person
    {
        protected string candidate = string.Empty;
        public string Candidate { get => candidate; }

        public abstract void Vote();

    }
}
