namespace Opdracht27_Talstelsel_JC
{
    public partial class FrmTalstelsel : Form
    {
        public FrmTalstelsel()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOpnieuw_Click(object sender, EventArgs e)
        {
            TxtHexa.Clear();
            TxtDeci.Clear();
            TxtHexa.Focus();
        }

        private void BtnZetOm_Click(object sender, EventArgs e)
        {
            string hexa;
            long deci;

            hexa = TxtHexa.Text;

            try
            {
                deci = Convert.ToInt64(hexa, 16);
                //deci = Int64.Parse(hexa, System.Globalization.NumberStyles.HexNumber);
            }
            catch
            {
                MessageBox.Show("test");
                return;
            }

            TxtDeci.Text = deci.ToString("N").Replace("."," ");
        }

        private void TxtHexa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '\b') && !(e.KeyChar >= 'A' && e.KeyChar <= 'F'))
            {
                e.Handled = true;
            }
        }
    }
}