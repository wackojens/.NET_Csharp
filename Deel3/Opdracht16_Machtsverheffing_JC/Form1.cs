namespace Opdracht16_Machtsverheffing_JC
{
    public partial class FrmMachtsverheffing : Form
    {
        public FrmMachtsverheffing()
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
            double getal;

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

            for (int number = 1; number <= 10; number++)
            {
                TxtResultaat.AppendText("Macht " + number + " van " + getal + " is " + Math.Pow(getal, number) + Environment.NewLine);
            }

            TxtGetal.Focus();
        }
    }
}