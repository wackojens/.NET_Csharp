namespace Opdracht19_Dubbelfeest_JC
{
    public partial class FrmDubbelfeest : Form
    {
        public FrmDubbelfeest()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtPersonen.Clear();
            TxtResultaat.Clear();
            TxtPersonen.Focus();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            int personen;
            double kans = 1, dagen = 365;

            TxtResultaat.Clear();

            try
            {
                personen = Convert.ToInt32(TxtPersonen.Text);
                if (personen < 2)
                {
                    MessageBox.Show("Het aantal personen moet minstens 2 zijn!");
                    TxtPersonen.Clear();
                    TxtPersonen.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Geef een geheel getal in voor het aantal personen! Minimum 2");
                TxtPersonen.Clear();
                TxtPersonen.Focus();
                return;
            }

            for (int i = 1; i < personen; i++)
            {
                kans *= ((dagen - i) / dagen);
            }

            kans = 1 - kans;
            kans *= 100;

            TxtResultaat.Text = "De kans op gelijke verjaardagen is " + Math.Round(kans, 4).ToString() + '%';
        }
    }
}