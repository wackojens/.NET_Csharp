namespace Project1
{
    public partial class FrmFuel : Form
    {
        public FrmFuel()
        {
            InitializeComponent();
        }

        private void FrmFuel_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnLeegmaken_Click(object sender, EventArgs e)
        {
            TxtKilometers.Text = "";
            TxtLiters.Text = "";
            TxtVerbruik.Text = "";
            TxtKilometers.Focus();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            Decimal DecKilometers, DecLiters;
            try
            {
                DecKilometers = decimal.Parse(TxtKilometers.Text);
            }
            catch
            {
                MessageBox.Show("Voer een geldige numerieke waarde in!");
                TxtKilometers.Clear();
                TxtKilometers.Focus();
                return;
            }
            try
            {
                DecLiters = decimal.Parse(TxtLiters.Text);
            }
            catch
            {
                MessageBox.Show("Voer een geldige numerieke waarde in!");
                TxtLiters.Clear();
                TxtLiters.Focus();
                return;
            }
            TxtVerbruik.Text = Convert.ToString((DecLiters / DecKilometers) * 100);
        }
    }
}