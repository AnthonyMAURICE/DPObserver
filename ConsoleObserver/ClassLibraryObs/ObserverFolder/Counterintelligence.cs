using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryObs.ObserverFolder
{
    public class Counterintelligence : ICitizenObserver
    {
        public void Update(ISubject subject)
        {
            Console.WriteLine("Scanning in progress...");
            Console.WriteLine(((Person)subject).Name + 
                (this.DetectIfEncryption(((Person)subject).Message) ?  
                " : Spy detected ! Please report to your nearest police station." : 
                " : Have a nice day."));
        }

        public bool DetectIfEncryption(string message)
        {
            return Regex.IsMatch(message, @"\p{IsCyrillic}");
        }
    }
}
