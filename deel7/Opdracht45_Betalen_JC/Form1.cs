namespace Opdracht45_Betalen_JC
{
    public partial class FrmCoupures : Form
    {
        public FrmCoupures()
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
            TxtBedrag.Clear();
            TxtBedrag.Focus();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            TxtResultaat.Clear();

            int[] centen = new int[] {50000,20000,10000,5000,2000,1000,500,200,100,50,20,10,5,2,1}; 
            double doubleBedrag, euro;
            int aantal, intBedrag;

            try
            {
                doubleBedrag = Convert.ToDouble(TxtBedrag.Text);
                if (doubleBedrag <= 0)
                {
                    MessageBox.Show("Waarde moet hoger dan 0 zijn!");
                    TxtBedrag.Clear();
                    TxtBedrag.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtBedrag.Clear();
                TxtBedrag.Focus();
                return;
            }

            doubleBedrag *= 100;
            intBedrag = Convert.ToInt32(Math.Floor(doubleBedrag));

            foreach (int munt in centen)
            {
                aantal = intBedrag / munt;
                intBedrag %= munt;
                euro = munt / 100.00;
                euro = Math.Round(euro, 2);

                if (aantal > 0) 
                    TxtResultaat.AppendText(aantal + " stuks van " + euro + Environment.NewLine);
            }
        }

        private void TxtBedrag_KeyPress(object sender, KeyPressEventArgs e)
        {
            string[] splitByDecimal = (sender as TextBox).Text.Split(',');

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && splitByDecimal.Length > 1 && splitByDecimal[1].Length == 2)
            {
                e.Handled = true;
            }
        }
    }
}