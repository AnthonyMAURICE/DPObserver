using ClassLibraryObs;

namespace WinFormsObserver
{
    public partial class FormObserver : Form
    {
        Random random = new Random();
        Person person;
        public FormObserver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            errorProvider1.SetError(textBox1, textBox1.Text == string.Empty ? "Enter a name" : string.Empty);
            if (textBox1.Text != string.Empty)
            {
                person = (random.Next(1, 5) == 3) ? new DoubleAgent(textBox1.Text) : new RegularCitizen(textBox1.Text);
                person.AddObserver();
            }
            if (person.GetType() == typeof(DoubleAgent)) 
            {
                Test((DoubleAgent)person);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, textBox2.Text == string.Empty ? "Enter a name" : string.Empty);
            if (textBox2.Text != string.Empty)
            {
                person = new Tourist(textBox2.Text);
                person.AddObserver();
            }
        }

        private void Test(DoubleAgent _person)
        {
            _person.Encrypt();
        }
    }
}
