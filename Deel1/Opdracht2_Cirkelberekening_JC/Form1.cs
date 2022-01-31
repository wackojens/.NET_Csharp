namespace Opdracht2_Cirkelberekening_JC
{
    public partial class FrmCircle : Form
    {
        public FrmCircle()
        {
            InitializeComponent();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtStraal.Clear();
            TxtOppervlakte.Clear();
            TxtOmtrek.Clear();
            TxtStraal.Focus();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            double doubleStraal;
            try
            {
                doubleStraal = Convert.ToDouble(TxtStraal.Text);
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtStraal.Clear();
                TxtStraal.Focus();
                return;
            }
            TxtOppervlakte.Text = 
                Convert.ToString((doubleStraal * doubleStraal) * 3.14159);
            TxtOmtrek.Text =
                Convert.ToString((doubleStraal * 2) * 3.14159);
        }
    }
}