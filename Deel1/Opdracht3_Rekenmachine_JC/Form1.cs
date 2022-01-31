namespace Opdracht3_Rekenmachine_JC
{
    public partial class FrmRekenmachine : Form
    {
        public FrmRekenmachine()
        {
            InitializeComponent();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtGetal1.Clear();
            TxtGetal2.Clear();
            TxtResultaat.Clear();
            TxtGetal1.Focus();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            double doubleGetal1, doubleGetal2;

            TxtResultaat.Clear();

            try
            {
                doubleGetal1 = Convert.ToDouble(TxtGetal1.Text);
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtGetal1.Clear();
                TxtGetal1.Focus();
                try
                {
                    doubleGetal2 = Convert.ToDouble(TxtGetal2.Text);
                }
                catch
                {
                    MessageBox.Show("Geef een numerieke waarde in!");
                    TxtGetal2.Clear();
                    TxtGetal2.Focus();
                    return;
                }
                return;
            }

            try
            {
                doubleGetal2 = Convert.ToDouble(TxtGetal2.Text);
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtGetal2.Clear();
                TxtGetal2.Focus();
                return;
            }

            TxtResultaat.Text = 
                Convert.ToString(doubleGetal1 + doubleGetal2);
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            double doubleGetal1, doubleGetal2;

            TxtResultaat.Clear();

            try
            {
                doubleGetal1 = Convert.ToDouble(TxtGetal1.Text);
            }
            catch
            {

                MessageBox.Show("Geef een numerieke waarde in!");
                TxtGetal1.Clear();
                TxtGetal1.Focus();
                try
                {
                    doubleGetal2 = Convert.ToDouble(TxtGetal2.Text);
                }
                catch
                {
                    MessageBox.Show("Geef een numerieke waarde in!");
                    TxtGetal2.Clear();
                    TxtGetal2.Focus();
                    return;
                }
                return;
            }

            try
            {
                doubleGetal2 = Convert.ToDouble(TxtGetal2.Text);
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtGetal2.Clear();
                TxtGetal2.Focus();
                return;
            }

            TxtResultaat.Text =
                Convert.ToString(doubleGetal1 - doubleGetal2);
        }

        private void BtnMaal_Click(object sender, EventArgs e)
        {
            double doubleGetal1, doubleGetal2;

            TxtResultaat.Clear();

            try
            {
                doubleGetal1 = Convert.ToDouble(TxtGetal1.Text);
            }
            catch
            {

                MessageBox.Show("Geef een numerieke waarde in!");
                TxtGetal1.Clear();
                TxtGetal1.Focus();
                try
                {
                    doubleGetal2 = Convert.ToDouble(TxtGetal2.Text);
                }
                catch
                {
                    MessageBox.Show("Geef een numerieke waarde in!");
                    TxtGetal2.Clear();
                    TxtGetal2.Focus();
                    return;
                }
                return;
            }

            try
            {
                doubleGetal2 = Convert.ToDouble(TxtGetal2.Text);
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtGetal2.Clear();
                TxtGetal2.Focus();
                return;
            }

            TxtResultaat.Text =
                Convert.ToString(doubleGetal1 * doubleGetal2);
        }

        private void BtnDelen_Click(object sender, EventArgs e)
        {
            double doubleGetal1, doubleGetal2;

            TxtResultaat.Clear();

            try
            {
                doubleGetal1 = Convert.ToDouble(TxtGetal1.Text);
            }
            catch
            {

                MessageBox.Show("Geef een numerieke waarde in!");
                TxtGetal1.Clear();
                TxtGetal1.Focus();
                try
                {
                    doubleGetal2 = Convert.ToDouble(TxtGetal2.Text);
                }
                catch
                {
                    MessageBox.Show("Geef een numerieke waarde in!");
                    TxtGetal2.Clear();
                    TxtGetal2.Focus();
                    return;
                }
                return;
            }

            try
            {
                doubleGetal2 = Convert.ToDouble(TxtGetal2.Text);
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtGetal2.Clear();
                TxtGetal2.Focus();
                return;
            }

            TxtResultaat.Text =
                Convert.ToString(doubleGetal1 / doubleGetal2);
        }
    }
}