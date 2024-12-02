using ClassLibraryObs.ObserverFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryObs
{
    public class SecurityOffice
    {
        private Counterintelligence counterintelligence = new();
        private SecretPolice secretPolice = new(); 

        public void ConsoleManageObservers(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                person.AddObserver(this.counterintelligence);
                if(person.GetType() != typeof(Tourist))
                {
                    person.AddObserver(this.secretPolice);
                }
            }
        }

        private WFCounterintelligence wFCounterintelligence = new();
        private WFSecretPolice wFSecretPolice = new();

        public void WFAddObserversCI(Person person) 
        {
            person.AddObserver(this.wFCounterintelligence);
        }

        public void WFRemoveObserversCI(Person person) 
        {
            person.RemoveObserver(this.wFCounterintelligence);
        }

        public void WFAddObserversSP(Person person)
        {
            person.AddObserver(this.wFSecretPolice);
        }

        public void WFRemoveObserversSp(Person person)
        {
            person.RemoveObserver(this.wFSecretPolice);
        }
    }
}
