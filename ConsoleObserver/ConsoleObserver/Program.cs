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

            List<Person> persons = [regularOne, regularTwo, spyOne, touristOne, touristTwo];

            foreach (Person person in persons) 
            {
                person.AddObserver();
            }

            spyOne.Encrypt();
            regularOne.RandomizedVote();
            regularTwo.RandomizedVote();
            touristOne.RandomizedSpy();
            touristTwo.RandomizedSpy();
        }
    }
}
