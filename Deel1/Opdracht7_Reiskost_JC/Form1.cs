namespace Opdracht7_Reiskost_JC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtBestemming.Clear();
            TxtBasisVlucht.Clear();
            TxtKlasse.Clear();
            TxtBasisDag.Clear();
            TxtAantalDag.Clear();
            TxtPersonen.Clear();
            TxtKorting.Clear();
            TxtResultaat.Clear();
            TxtBestemming.Focus();
        }

        private void TxtKlasse_Enter(object sender, EventArgs e)
        {
            LblOpties.Visible = true; 
        }

        private void TxtKlasse_Leave(object sender, EventArgs e)
        {
            LblOpties.Visible = false;
        }

        private void BtnBerekenen_Click(object sender, EventArgs e)
        {
            string bestemming;
            int vluchtklasse, aantalDag, personen;
            double basisVlucht, basisDag, kortingPerc, totaalVlucht, totaalVerblijf, totaalReis, kortingNum, teBetalen;

            TxtResultaat.Clear();

            bestemming = TxtBestemming.Text;

            try
            {
                basisVlucht = Math.Abs(Convert.ToDouble(TxtBasisVlucht.Text));
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtBasisVlucht.Clear();
                TxtBasisVlucht.Focus();
                return;
            }

            try
            {
                vluchtklasse = Math.Abs(Convert.ToInt16(TxtKlasse.Text));
                if (vluchtklasse < 1 || vluchtklasse > 3)
                {
                    MessageBox.Show("Geef een geheel getal van 1 t.e.m. 3!");
                    TxtKlasse.Clear();
                    TxtKlasse.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Geef een geheel getal van 1 t.e.m. 3!");
                TxtKlasse.Clear();
                TxtKlasse.Focus();
                return;
            }

            try
            {
                basisDag = Math.Abs(Convert.ToDouble(TxtBasisDag.Text));
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtBasisDag.Clear();
                TxtBasisDag.Focus();
                return ;
            }

            try
            {
                aantalDag = Math.Abs(Convert.ToInt16(TxtAantalDag.Text));
            }
            catch
            {
                MessageBox.Show("Geef een geheel getal in!");
                TxtAantalDag.Clear();
                TxtAantalDag.Focus();
                return;
            }

            try
            {
                personen = Math.Abs(Convert.ToInt16(TxtPersonen.Text));
            }
            catch
            {
                MessageBox.Show("Geef een geheel getal in!");
                TxtPersonen.Clear();
                TxtPersonen.Focus();
                return;
            }

            try
            {
                kortingPerc = Math.Abs(Convert.ToDouble(TxtKorting.Text));
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in");
                TxtKorting.Clear();
                TxtKorting.Focus();
                return;
            }

            totaalVlucht = (vluchtklasse * basisVlucht) * personen;
            totaalVerblijf = aantalDag * personen * basisDag;
            totaalReis = totaalVlucht + totaalVerblijf;
            kortingNum = totaalReis * kortingPerc / 100;
            teBetalen = totaalReis - kortingNum;

            TxtResultaat.Text = "REISKOST VOLGENS BESTELLING NAAR: " + bestemming + Environment.NewLine +
                Environment.NewLine +
                "Totale vluchtprijs: " + totaalVlucht.ToString("C") + Environment.NewLine +
                "Totale verblijfprijs: " + totaalVerblijf.ToString("C") + Environment.NewLine +
                "Totale reisprijs: " + totaalReis.ToString("C") + Environment.NewLine +
                "Korting: " + kortingNum.ToString("C") + Environment.NewLine +
                Environment.NewLine +
                "Te betalen: " + teBetalen.ToString("C");
        }
    }
}