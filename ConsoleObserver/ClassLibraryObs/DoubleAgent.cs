using ClassLibraryObs.ObserverFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryObs
{
    public class DoubleAgent(string _name) : Citizen(_name)
    {
        public void Encrypt()
        {
            this.message = "Я не шпион, клянусь !";
            this.NotifyObserver();
        }
    }
}
