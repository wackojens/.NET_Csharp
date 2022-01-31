namespace Opdracht9_Cursusgeld_JC
{
    public partial class FrmCursusgeld : Form
    {
        public FrmCursusgeld()
        {
            InitializeComponent();
        }

        private void BtnAfsluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTestNum_Click(object sender, EventArgs e)
        {
            int jaar;

            try
            {
                jaar = Convert.ToInt16(TxtJaar.Text);
                LblNumeriek.Visible = true;
                BtnBereken.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Geef een jaartal in");
                TxtJaar.Clear();
                TxtJaar.Focus();
                return;
            }

            if (jaar % 400 == 0 || jaar % 4 == 0 && jaar % 100 != 0)
            {
                LblSchrikkeljaar.Visible = true;
            }
        }

        private void TxtJaar_TextChanged(object sender, EventArgs e)
        {
            LblNumeriek.Visible = false;
            LblSchrikkeljaar.Visible = false;
            TxtLesuren.Clear();
            TxtCursusgeld.Clear();
            BtnBereken.Enabled = false;
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            int lesuren;
            double cursusgeld, uurPrijs = 1.50;

            try
            {
                lesuren = Convert.ToInt16(TxtLesuren.Text);
            }
            catch
            {
                MessageBox.Show("Geef het aantal lesuren in!");
                TxtLesuren.Clear();
                TxtLesuren.Focus();
                return;
            }

            if (LblSchrikkeljaar.Visible == true)
            {
                cursusgeld = (lesuren + 1) * uurPrijs;
            }    
            else
            {
                cursusgeld = lesuren * uurPrijs;
            }

            TxtCursusgeld.Text = cursusgeld.ToString("C");
        }
    }
}