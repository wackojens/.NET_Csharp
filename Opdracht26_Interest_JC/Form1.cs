namespace Opdracht26_Interest_JC
{
    public partial class FrmIntrest : Form
    {
        public FrmIntrest()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtBeginKap.Clear();
            TxtEindKap.Clear();
            TxtIntrest.Clear();
            TxtResultaat.Clear();
            TxtBeginKap.Focus();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            double beginkap, eindkap, intrest, totaal;
            int teller = 0;

            try
            {
                beginkap = Math.Abs(Convert.ToDouble(TxtBeginKap.Text));
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtBeginKap.Clear();
                TxtBeginKap.Focus();
                return;
            }

            try
            {
                eindkap = Math.Abs(Convert.ToDouble(TxtEindKap.Text));
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtEindKap.Clear();
                TxtEindKap.Focus();
                return;
            }

            try
            {
                intrest = Math.Abs(Convert.ToDouble(TxtIntrest.Text));
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtIntrest.Clear();
                TxtIntrest.Focus();
                return;
            }

            totaal = beginkap;
            intrest = 1 + intrest / 100;

            do
            {
                totaal *= intrest;
                teller++;
                TxtResultaat.AppendText("Waarde na " + teller + " jaren: " + totaal.ToString("C") + Environment.NewLine);
            }
            while (totaal < eindkap);
        }

        private void TxtBeginKap_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtBeginKap.Text, " ^ [0-9,]"))
            {
                MessageBox.Show("Geef enkel cijfers of een komma in!");
                TxtBeginKap.Clear();
            }
        }

        private void TxtEindKap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point(comma)
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            //https://www.delftstack.com/howto/csharp/how-to-make-a-textbox-that-only-accepts-numbers-in-csharp/
        }
    }
}