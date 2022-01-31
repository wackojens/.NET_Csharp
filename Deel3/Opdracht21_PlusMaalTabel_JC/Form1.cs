namespace Opdracht21_PlusMaalTabel_JC
{
    public partial class FrmPlusMaalTabel : Form
    {
        public FrmPlusMaalTabel()
        {
            InitializeComponent();
            TxtMaximum.Text = "10";
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnWissen_Click(object sender, EventArgs e)
        {
            Reset_Form();
        }

        private void TxtMaximum_Leave(object sender, EventArgs e)
        {
            int check;
            Font fontBig = new("Lucida Sans Typewriter", 20.0f, FontStyle.Bold | FontStyle.Underline);
            Font fontSmall = new("Lucida Sans Typewriter", 8.0f, FontStyle.Regular);

            try
            {
                check = Convert.ToInt16(TxtMaximum.Text);

                if (check > 20)
                {
                    Timer1.Enabled = true;
                    TxtResultaat.Font = fontBig;
                    TxtResultaat.Text = "Getal mag niet groter dan 20 zijn!";
                }
                else if (check < 1)
                {
                    Reset_Form();
                    MessageBox.Show("Getal moet minstens 1 zijn");
                    return;
                }
                else
                {
                    Timer1.Enabled = false;
                    TxtResultaat.Font = fontSmall;
                    TxtResultaat.Clear();
                }


            }
            catch
            {
                Reset_Form();
                MessageBox.Show("Geef een geheel getal in! (1 to 20)");
                return;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (TxtResultaat.Text == "")
                TxtResultaat.Text = "Getal mag niet groter dan 20 zijn!";
            else
                TxtResultaat.Text = "";
        }

        private void BtnOptellen_Click(object sender, EventArgs e)
        {
            string str = "+";
            Print_Tabel(str);
        }

        private void BtnVermenigvuldigen_Click(object sender, EventArgs e)
        {
            string str = "*";
            Print_Tabel(str);
        }

        private void Reset_Form()
        {
            Timer1.Enabled = false;
            TxtResultaat.Clear();
            TxtMaximum.Text = "10";
            TxtMaximum.Focus();
        }

        private void Print_Tabel(string e)
        {
            int nummer;

            nummer = Convert.ToInt16(TxtMaximum.Text);
            if (nummer > 20)
                return;

            TxtResultaat.Text = "    ";
            for (int i = 1; i <= nummer; i++)
            {
                TxtResultaat.AppendText(String.Format("{0, 4}", i));
            }
            TxtResultaat.AppendText(Environment.NewLine + Environment.NewLine);

            if (e == "*")
            {
                for (int i = 1; i <= nummer; i++)
                {
                    TxtResultaat.AppendText(String.Format("{0, 4}", i));
                    for (int j = 1; j <= nummer; j++)
                    {
                        TxtResultaat.AppendText(String.Format("{0 , 4}", i * j));
                    }
                    TxtResultaat.AppendText(Environment.NewLine);
                }
            }
            else if (e == "+")
            {
                for (int i = 1; i <= nummer; i++)
                {
                    TxtResultaat.AppendText(String.Format("{0, 4}", i));
                    for (int j = 1; j <= nummer; j++)
                    {
                        TxtResultaat.AppendText(String.Format("{0 , 4}", i + j));
                    }
                    TxtResultaat.AppendText(Environment.NewLine);
                }
            }
        }
    }
}