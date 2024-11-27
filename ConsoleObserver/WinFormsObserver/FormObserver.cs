using ClassLibraryObs;

namespace WinFormsObserver
{
    public partial class FormObserver : Form
    {
        DoubleAgent spyOne = new("Bob");
        DoubleAgent spyTwo = new("Legit");
        RegularCitizen regularOne = new("Bill");
        RegularCitizen regularTwo = new("Billy");
        Tourist touristOne = new("Billy-Bob");
        Tourist touristTwo = new("Bobby-Bill");
        SecurityOffice securityOffice = new();
        List<Person> persons;

        public FormObserver()
        {
            persons = [spyOne, spyTwo, regularOne, regularTwo, touristOne, touristTwo];
            InitializeComponent();
        }

        private void FormObserver_Load(object sender, EventArgs e)
        {
            foreach (Person person in this.persons)
            {
                listBoxPersons.Items.Add(person.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            securityOffice.WFAddObserversCI(persons[listBoxPersons.SelectedIndex]);
            listBoxPersons.Items[listBoxPersons.SelectedIndex] += " (CI)";
            persons[listBoxPersons.SelectedIndex].Ci = true;
            EnabledButtons();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Person person in persons)
            {
                if (person.GetType() == typeof(DoubleAgent))
                {
                    ((DoubleAgent)person).Encrypt();
                }
                if (person.GetType() == typeof(RegularCitizen))
                {
                    ((RegularCitizen)person).RandomizedVote();
                }
                if (person.GetType() == typeof(Tourist))
                {
                    ((Tourist)person).RandomizedSpy();
                }
                if (person.Busted || person.Spy)
                {
                    listBoxBusted.Items.Add(person.Name.ToString() + (person.Spy ? " - Spy" : string.Empty) + (person.Busted ? " - Dissident" : string.Empty));
                }
            }
            button1.Enabled = false;
            button4.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            securityOffice.WFAddObserversSP(persons[listBoxPersons.SelectedIndex]);
            listBoxPersons.Items[listBoxPersons.SelectedIndex] += " (SP)";
            persons[listBoxPersons.SelectedIndex].Sp = true;
            EnabledButtons();
        }

        private void listBoxPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPersons.SelectedIndex != -1)
            {
                EnabledButtons();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            securityOffice.WFRemoveObserversCI(persons[listBoxPersons.SelectedIndex]);
            listBoxPersons.Items[listBoxPersons.SelectedIndex] = persons[listBoxPersons.SelectedIndex].Name;
            persons[listBoxPersons.SelectedIndex].Ci = false;
            EnabledButtons();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            securityOffice.WFRemoveObserversSp(persons[listBoxPersons.SelectedIndex]);
            listBoxPersons.Items[listBoxPersons.SelectedIndex] = persons[listBoxPersons.SelectedIndex].Name;
            persons[listBoxPersons.SelectedIndex].Sp = false;
            EnabledButtons();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnabledButtons()
        {
            button3.Enabled = true;
            button1.Enabled = !persons[listBoxPersons.SelectedIndex].Ci;
            button2.Enabled = !persons[listBoxPersons.SelectedIndex].Sp && !(persons[listBoxPersons.SelectedIndex].GetType() == typeof(Tourist));
            button4.Enabled = persons[listBoxPersons.SelectedIndex].Ci;
            button5.Enabled = persons[listBoxPersons.SelectedIndex].Sp;
        }
    }
}
