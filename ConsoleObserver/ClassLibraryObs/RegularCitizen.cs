using ClassLibraryObs.ObserverFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryObs
{
    public class RegularCitizen(string _name) : Citizen(_name)
    {

        public void RandomizedVote()
        {
            Random random = new();
            if (random.Next(1, 4) == 2) 
            {
                this.vote = "Other Candidate";
            }
            this.NotifyObserver();
        }
    }
}
