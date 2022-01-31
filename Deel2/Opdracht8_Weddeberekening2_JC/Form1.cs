namespace Opdracht8_Weddeberekening2_JC
{
    public partial class FrmWeddeberekening : Form
    {
        public FrmWeddeberekening()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtPersoneel.Clear();
            TxtUurloon.Clear();
            TxtAantalUren.Clear();
            TxtPersoneel.Focus();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            string personeel;
            int uren;
            decimal uurloon, bruto, belasting, netto;

            TxtResultaat.Clear();

            personeel = TxtPersoneel.Text;

            try
            {
                uurloon = Convert.ToDecimal(TxtUurloon.Text);
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtUurloon.Clear();
                TxtUurloon.Focus();
                return;
            }

            try
            {
                uren = Convert.ToInt16(TxtAantalUren.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geheel getal in!");
                TxtAantalUren.Clear();
                TxtAantalUren.Focus();
                return;
            }

            bruto = uren * uurloon;

            if (bruto > 50000)
            {
                belasting = ((bruto - 50000) * 0.5M) + (25000 * 0.4M) + (10000 * 0.3M) + (5000 * 0.2M);
            }
            else if (bruto > 25000)
            {
                belasting = ((bruto - 25000) * 0.4M) + (10000 * 0.3M) + (5000 * 0.2M);
            }
            else if (bruto > 15000)
            {
                belasting = ((bruto - 15000) * 0.3M) + (5000 * 0.2M);
            }
            else if (bruto > 10000)
            {
                belasting = (bruto - 10000) * 0.2M;
            }
            else
                belasting = 0;

            netto = bruto - belasting;

            TxtResultaat.Text = "LOONFICHE VAN " + personeel + Environment.NewLine +
                Environment.NewLine +
                "Aantal gewerkte uren: " + uren + Environment.NewLine +
                "Uurloon: " + uurloon.ToString("C") + Environment.NewLine +
                "Brutojaarwedde: " + bruto.ToString("C") + Environment.NewLine +
                "Belasting: " + belasting.ToString("C") + Environment.NewLine +
                "Nettojaarwedde: " + netto.ToString("C");
        }
    }
}