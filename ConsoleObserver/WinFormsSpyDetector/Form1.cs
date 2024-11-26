using ClassLibraryObs;

namespace WinFormsSpyDetector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            for (int i = 0; i < 6; i++) 
            {
                listBox1.Items.Add(new Person());
            }
        }
    }
}
