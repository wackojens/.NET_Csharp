namespace Opdracht5_Bioscoop_JC
{
    public partial class FrmBioscoop : Form
    {
        public FrmBioscoop()
        {
            InitializeComponent();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            TxtNormaal.Clear();
            TxtKorting.Clear();
            TxtPrijs.Clear();
            TxtStudent.Clear();
            TxtNormaal.Focus();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            int normaal, korting, student;
            float prijs;

            TxtPrijs.Clear();

            try
            {
                if (string.IsNullOrEmpty(TxtNormaal.Text))
                    normaal = 0;
                else
                    normaal = Convert.ToInt16(TxtNormaal.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geheel getal in!");
                TxtNormaal.Clear();
                TxtNormaal.Focus();
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(TxtKorting.Text))
                    korting = 0;
                else
                    korting = Convert.ToInt16(TxtKorting.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geheel getal in!");
                TxtKorting.Clear();
                TxtKorting.Focus();
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(TxtStudent.Text))
                    student = 0;
                else
                    student = Convert.ToInt16(TxtStudent.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geheel getal in!");
                TxtStudent.Clear();
                TxtStudent.Focus();
                return;
            }
            
            if (normaal < 0 || korting < 0 || student < 0)
            {
                MessageBox.Show("Waarden mogen niet negatief zijn!");
                TxtNormaal.Clear();
                TxtKorting.Clear();
                TxtStudent.Clear();
                TxtNormaal.Focus();
                return;
            }

            prijs = (float)Convert.ToDouble(normaal * 9.1 + korting * 8.1 + student * 6.9);
            TxtPrijs.Text = prijs.ToString();
        }

        private void BtnAfsluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}