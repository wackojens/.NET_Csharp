namespace Opdracht6_Weddeberekening_JC
{
    public partial class FrmWeddeberekening : Form
    {
        public FrmWeddeberekening()
        {
            InitializeComponent();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtPersoneel.Clear();
            TxtUurloon.Clear();
            TxtAantalUren.Clear();
            TxtResultaat.Clear();
            TxtPersoneel.Focus();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            string personeel;
            int aantalUren;
            decimal uurloon, bruto, netto, belasting;

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
                aantalUren = Convert.ToInt16(TxtAantalUren.Text);
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtAantalUren.Clear();
                TxtAantalUren.Focus();
                return;
            }

            if (aantalUren < 0 || uurloon <0)
            {
                MessageBox.Show("Waarden kunnen niet negatief zijn");
                TxtUurloon.Clear();
                TxtAantalUren.Clear();
                return;
            }

            bruto = uurloon * aantalUren;
            belasting = bruto * 0.3M;
            netto = bruto * 0.7M; // of bruto - belasting

            TxtResultaat.Text = "LOONFICHE VAN " + personeel + Environment.NewLine +
                Environment.NewLine +
                "Aantal gewerkte uren: " + aantalUren + Environment.NewLine +
                "Uurloon: " + uurloon.ToString("C") + Environment.NewLine +
                "Brutojaarwedde: " + bruto.ToString("C") + Environment.NewLine +
                "Belasting: " + belasting.ToString("C") + Environment.NewLine +
                "Nettojaarwedde: " + netto.ToString("C");
        }
    }
}