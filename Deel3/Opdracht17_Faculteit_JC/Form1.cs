namespace Opdracht17_Faculteit_JC
{
    public partial class FrmFaculteit : Form
    {
        public FrmFaculteit()
        {
            InitializeComponent();
            TxtGetal.Text = "1";
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtGetal.Text = "1";
            TxtResultaat.Clear();
            TxtGetal.Focus();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            double getal, faculteit;

            TxtResultaat.Clear();

            try
            {
                getal = Convert.ToDouble(TxtGetal.Text);
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtGetal.Text = "1";
                TxtGetal.Focus();
                return;
            }

            if (getal == 0)
            {
                faculteit = 1;
            }
            else
            {
                faculteit = getal;
                while (getal > 2)
                {
                    getal --;
                    faculteit *= getal;
                }
            }

            TxtResultaat.Text = faculteit.ToString();

            TxtGetal.Focus();
        }
    }
}