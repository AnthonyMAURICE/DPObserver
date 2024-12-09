using ClassLibraryObs;
using ClassLibraryObs.ObserverFolder;

namespace ConsoleObserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleAgent spyOne = new("Bob");
            RegularCitizen regularOne = new("Bill");


            RegularCitizen regularTwo = new("Billy");
            Tourist touristOne = new("Billy-Bob");
            Tourist touristTwo = new("Bobby-Bill");
            Counterintelligence counterintelligence = new();
            SecretPolice secretPolice = new();

            
            counterintelligence.ConnectTo(spyOne);
            counterintelligence.Disconnect();
            spyOne.Subscribe(secretPolice);
            regularOne.Subscribe(secretPolice);

            spyOne.Encrypt();
            regularOne.Vote();
        }
    }
}
