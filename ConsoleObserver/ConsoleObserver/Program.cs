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
            regularOne.Subscribe(secretPolice);
            //Other Subscriptions region
            #region
            spyOne.Subscribe(secretPolice);
            regularTwo.Subscribe(secretPolice);
            regularOne.Subscribe(counterintelligence);
            regularTwo.Subscribe(counterintelligence);
            touristOne.Subscribe(counterintelligence);
            touristTwo.Subscribe(counterintelligence);
            #endregion
            spyOne.Encrypt();
            regularOne.Vote();
            //Other actions region
            #region
            regularOne.Encrypt();
            regularTwo.Encrypt();
            regularTwo.Vote();
            touristOne.Encrypt();
            touristTwo.Encrypt();
            #endregion
        }
    }
}
