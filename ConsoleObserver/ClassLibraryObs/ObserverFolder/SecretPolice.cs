using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObs.ObserverFolder
{
    public class SecretPolice : Security
    {
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
            Console.WriteLine("Counting vote...");
            Console.WriteLine(subject.Name +
                (this.DetectIfDissident(((Citizen)subject).Candidate) ?
                " : Dissident detected ! Please report to your nearest police station." :
                " : You're a good citizen"));
        }

        //public void Update(ISubject subject)
        //{
            
        //    Console.WriteLine("Counting vote...");
        //    Console.WriteLine(((Person)subject).Name + 
        //        (this.DetectIfDissident(((Citizen)subject).Candidate) ? 
        //        " : Dissident detected ! Please report to your nearest police station." : 
        //        " : You're a good citizen"));
        //}

        private bool DetectIfDissident(string candidate) 
        {
            return candidate != "Designated Candidate";
        }
    }
}
