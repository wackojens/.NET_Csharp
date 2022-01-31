namespace Opdracht1_euro_JC
{
    public partial class FrmEuroToBEF : Form
    {
        public FrmEuroToBEF()
        {
            InitializeComponent();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtEuro.Text = "";
            TxtBEF.Text = "";
            TxtEuro.Focus();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            double doubleEuro, doubleFrank;
            doubleFrank = 40.3399;
            try
            {
                doubleEuro = Convert.ToDouble(TxtEuro.Text);
            }
            catch
            {
                MessageBox.Show("Voer een numerieke waarde in!");
                TxtEuro.Clear();
                TxtEuro.Focus();
                return;
            }
            TxtBEF.Text = Convert.ToString(doubleEuro * doubleFrank);
        }
    }
}