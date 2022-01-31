namespace Opdracht15_SnelsteAtleet_JC
{
    public partial class FrmSnelsteAtleet : Form
    {
        public FrmSnelsteAtleet()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            atleten.Clear();
            TxtAtleet.Clear();
            TxtSeconden.Clear();
            TxtResultaat.Clear();
            TxtAtleet.Focus();
        }

        Dictionary<string, int> atleten = new();

        private void BtnNieuw_Click(object sender, EventArgs e)
        {
            int totSeconden;

            TxtResultaat.Clear();

            try
            {
                totSeconden = Convert.ToInt32(TxtSeconden.Text);
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtSeconden.Clear();
                TxtSeconden.Focus();
                return;
            }

            if (atleten.ContainsKey(TxtAtleet.Text))
            {
                atleten[TxtAtleet.Text] = totSeconden;
            }
            else
            {
                atleten.Add(TxtAtleet.Text, totSeconden);
            }

            TxtAtleet.Clear();
            TxtSeconden.Clear();
            TxtAtleet.Focus();
        }

        private void TxtSeconden_Leave(object sender, EventArgs e)
        {
            BtnNieuw.Focus();
        }

        private void BtnSnelste_Click(object sender, EventArgs e)
        {
            int uren, minuten, seconden, totSeconden, snelste = 0;
            string naam = "";

            if (TxtAtleet.Text != "" && TxtSeconden.Text != "")
            {
                try
                {
                    totSeconden = Convert.ToInt32(TxtSeconden.Text);
                }
                catch
                {
                    MessageBox.Show("Geef een numerieke waarde in!");
                    TxtSeconden.Clear();
                    TxtSeconden.Focus();
                    return;
                }

                if (atleten.ContainsKey(TxtAtleet.Text))
                {
                    atleten[TxtAtleet.Text] = totSeconden;
                }
                else
                {
                    atleten.Add(TxtAtleet.Text, totSeconden);
                }

                TxtAtleet.Clear();
                TxtSeconden.Clear();
            }

            foreach (string s in atleten.Keys)
            {
                if (snelste == 0)
                {
                    naam = s;
                    snelste = atleten[s];
                }
                else if (atleten[s] < snelste)
                {
                    naam = s;
                    snelste = atleten[s];
                }
            }

            uren = snelste / 3600;
            minuten = (snelste % 3600) / 60;
            seconden = (snelste % 3600) % 60;


            TxtResultaat.Text = "De snelste atleet is " + naam + Environment.NewLine +
                "Totaal aantal seconden " + snelste + Environment.NewLine +
                Environment.NewLine +
                "aantal uren: " + uren + Environment.NewLine +
                "aantal minuten: " + minuten + Environment.NewLine +
                "aantal seconden: " + seconden;
        }
    }
}