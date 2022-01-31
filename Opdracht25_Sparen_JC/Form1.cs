namespace Opdracht25_Sparen_JC
{
    public partial class FrmSparen : Form
    {
        public FrmSparen()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtResultaat.Clear();
            TxtSpaarbedrag.Clear();
            TxtVerhoging.Clear();
            TxtWeekgeld.Clear();
            TxtWeekgeld.Focus();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            double weekgeld, verhoging, gewenst;
            int teller = 0;

            try
            {
                weekgeld = Convert.ToDouble(TxtWeekgeld.Text);
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtWeekgeld.Clear();
                TxtWeekgeld.Focus();
                return;
            }

            try
            {
                verhoging = Convert.ToDouble(TxtVerhoging.Text);
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtVerhoging.Clear();
                TxtVerhoging.Focus();
                return;
            }

            try
            {
                gewenst = Convert.ToDouble(TxtSpaarbedrag.Text);
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtSpaarbedrag.Clear();
                TxtSpaarbedrag.Focus();
                return;
            }


        }
    }
}