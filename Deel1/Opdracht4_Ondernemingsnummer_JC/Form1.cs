namespace Opdracht4_Ondernemingsnummer_JC
{
    public partial class FrmOndernemingsnummer : Form
    {
        public FrmOndernemingsnummer()
        {
            InitializeComponent();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtControlenummer.Clear();
            LblResultaat.Text = "";
            TxtOndernemingsnummer.Clear();
            TxtOndernemingsnummer.Focus();
        }

        private void BtnControlenummer_Click(object sender, EventArgs e)
        {
            int intControlenummer, intOndernemingsnummer, intGetal, intRest;
            string stringInput;

            stringInput = TxtOndernemingsnummer.Text;

            if (stringInput.Length != 10)
            {
                MessageBox.Show("Een ondernemingsnummer bestaat uit 10 cijfers");
                TxtOndernemingsnummer.Clear();
                TxtControlenummer.Clear();
                TxtOndernemingsnummer.Focus();
                LblResultaat.Text = "";
                return;
            }

            try
            {
                intOndernemingsnummer = Convert.ToInt32(stringInput);
            }
            catch
            {
                MessageBox.Show("Geef enkel een ondernemingsnummer in!");
                TxtOndernemingsnummer.Clear();
                TxtControlenummer.Clear();
                TxtOndernemingsnummer.Focus();
                LblResultaat.Text = "";
                return;
            }

            intControlenummer = intOndernemingsnummer % 100;
            TxtControlenummer.Text = intControlenummer.ToString();

            intGetal = intOndernemingsnummer / 100;
            intRest = intGetal % 97;

            if (intControlenummer == (97 - intRest))
            {
                LblResultaat.Text = "Dit is een geldig ondernemingsnummer";
            }
            else
            {
                LblResultaat.Text = "Dit is geen geldig ondernemingsnummer";
            }
        }
    }
}