using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryObs.ObserverFolder
{
    internal class WFCounterintelligence : ICitizenObserver
    {
        public void Update(ISubject subject)
        {
            if ((this.DetectIfEncryption(((Person)subject).Message)))
            {
                subject.HasBeenObserved(this);
            }
        }

        public bool DetectIfEncryption(string message)
        {
            return Regex.IsMatch(message, @"\p{IsCyrillic}");
        }
    }
}
