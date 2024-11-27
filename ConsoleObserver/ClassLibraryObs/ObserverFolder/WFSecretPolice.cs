using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObs.ObserverFolder
{
    internal class WFSecretPolice : ICitizenObserver
    {
        public void Update(ISubject subject)
        {
            if (this.DetectIfDissident(((Citizen)subject).Vote))
            {
                subject.HasBeenObserved(this);
            }
        }

        private bool DetectIfDissident(string candidate)
        {
            return candidate != "Designated Candidate";
        }
    }
}
