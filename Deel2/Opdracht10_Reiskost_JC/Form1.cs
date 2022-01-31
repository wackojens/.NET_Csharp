namespace Opdracht10_Reiskost_JC
{
    public partial class FrmReiskost : Form
    {
        public FrmReiskost()
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
            TxtAantalDagen.Clear();
            TxtPersonen.Clear();
            TxtKortingPerc.Clear();
            TxtResultaat.Clear();
            TxtBestemming.Focus();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            string bestemming;
            int vluchtklasse, aantalDagen, aantalPersonen;
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
                MessageBox.Show("Geef een numerieke waarde!");
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
                return;
            }

            try
            {
                aantalDagen = Math.Abs(Convert.ToInt16(TxtAantalDagen.Text));
            }
            catch
            {
                MessageBox.Show("Geef een geheel getal in!");
                TxtAantalDagen.Clear();
                TxtAantalDagen.Focus();
                return;
            }

            try
            {
                aantalPersonen = Math.Abs(Convert.ToInt16(TxtPersonen.Text));
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
                kortingPerc = Math.Abs(Convert.ToDouble(TxtKortingPerc.Text));
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in");
                TxtKortingPerc.Clear();
                TxtKortingPerc.Focus();
                return;
            }

            if (vluchtklasse == 1)
            {
                totaalVlucht = basisVlucht * 1.3 * aantalPersonen;
            }
            else if (vluchtklasse == 3)
            {
                totaalVlucht = basisVlucht * 0.8 * aantalPersonen;
            }
            else
            {
                totaalVlucht = (vluchtklasse * basisVlucht) * aantalPersonen;
            }

            if (aantalPersonen > 3)
            {
                totaalVerblijf = ((basisDag * 2 * 1) + (basisDag * 1 *  0.5) + (basisDag * (aantalPersonen - 3) * 0.3)) * aantalDagen;
            }
            else if (aantalPersonen == 3)
            {
                totaalVerblijf = ((basisDag * 2) + (basisDag * 0.5)) * aantalDagen;
            }
            else
            {
                totaalVerblijf = aantalDagen * aantalPersonen * basisDag;
            }

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

        readonly ToolTip tTip = new();
        private void TxtKlasse_Enter(object sender, EventArgs e)
        { 
            tTip.ShowAlways = true;
            tTip.Show("1=Bussinessclass" + Environment.NewLine +
                      "2=Standaard lijnvlucht" + Environment.NewLine +
                      "3=Charter", TxtKlasse, 100, 0);
        }

        private void TxtKlasse_Leave(object sender, EventArgs e)
        {
            tTip.Hide(TxtKlasse);
        }
    }
}