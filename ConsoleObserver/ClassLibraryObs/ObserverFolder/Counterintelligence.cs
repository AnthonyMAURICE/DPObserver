using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryObs.ObserverFolder
{
    public class Counterintelligence : Security
    {
        //public void Update(ISubject subject)
        //{
        //    Console.WriteLine("Scanning in progress...");
        //    Console.WriteLine(((Person)subject).Name + 
        //        (this.DetectIfEncryption(((Person)subject).Message) ?  
        //        " : Spy detected ! Please report to your nearest police station." : 
        //        " : Have a nice day."));
        //}

        public bool DetectIfEncryption(string message)
        {
            return Regex.IsMatch(message, @"\p{IsCyrillic}");
        }

        public override void OnCompleted()
        {
            // Notify the observer when the subject has finished sending a group of notifications
        }

        public override void OnError(Exception error)
        {
            Console.WriteLine(error.Message);
        }

        public override void OnNext(Person subject)
        {
            Console.WriteLine("Scanning in progress...");
            Console.WriteLine(subject.Name +
                (this.DetectIfEncryption(subject.Message) ?
                " : Spy detected ! Please report to your nearest police station." :
                " : Have a nice day."));
        }
    }
}
