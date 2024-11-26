using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObs.ObserverFolder
{
    public class SecretPolice : ICitizenObserver
    {
        public void Update(ISubject subject)
        {
            
            Console.WriteLine("Counting vote...");
            Console.WriteLine(((Person)subject).Name + (this.DetectIfDissident(((Citizen)subject).Vote) ? " : Dissident detected ! Please report to your nearest police station." : " : Good day Citizen"));
        }

        private bool DetectIfDissident(string candidate) 
        {
            return candidate != "Designated Candidate";
        }
    }
}
