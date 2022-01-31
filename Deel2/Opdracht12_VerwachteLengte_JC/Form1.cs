namespace Opdracht12_VerwachteLengte_JC
{
    public partial class FrmVerwLeng : Form
    {
        public FrmVerwLeng()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RadJongen_CheckedChanged(object sender, EventArgs e)
        {
            TxtVerJongen.Enabled = true;
            TxtVerMeisje.Clear();
            TxtVerMeisje.Enabled = false;
        }

        private void RadMeisje_CheckedChanged(object sender, EventArgs e)
        {
            TxtVerMeisje.Enabled = true;
            TxtVerJongen.Clear();
            TxtVerJongen.Enabled = false;
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            double lengVader, lengMoeder, lengJongen, lengMeisje;

            TxtVerMeisje.Clear();
            TxtVerJongen.Clear();

            try
            {
                lengVader = Convert.ToDouble(TxtVader.Text);
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtVader.Clear();
                TxtVader.Focus();
                return;
            }

            try
            {
                lengMoeder = Convert.ToDouble(TxtMoeder.Text);
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtMoeder.Clear();
                TxtMoeder.Focus();
                return;
            }

            if (TxtVerMeisje.Enabled == true)
            {
                lengMeisje = (lengVader + lengMoeder - 4) / 2;
                TxtVerMeisje.Text = lengMeisje.ToString();
            }

            if (TxtVerJongen.Enabled == true)
            {
                lengJongen = (lengVader + lengMoeder + 22) / 2;
                TxtVerJongen.Text = lengJongen.ToString();
            }
        }
    }
}