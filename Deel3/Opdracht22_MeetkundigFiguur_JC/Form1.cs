namespace Opdracht22_MeetkundigFiguur_JC
{
    public partial class FrmMeetkundigFiguur : Form
    {
        public FrmMeetkundigFiguur()
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
            TxtGrootte.Clear();
            TxtGrootte.Focus();
        }

        private void BtnVierkantVol_Click(object sender, EventArgs e)
        {
            int size;

            TxtResultaat.Clear();

            try
            {
                size = Convert.ToInt16(TxtGrootte.Text);
                if (size < 1 || size > 20)
                {
                    MessageBox.Show("Geef een waarde van 1 tot en met 20 in!");
                    TxtGrootte.Clear();
                    TxtGrootte.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Geef een geheel getal in!");
                TxtGrootte.Clear();
                TxtGrootte.Focus();
                return;
            }

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    TxtResultaat.AppendText("* ");
                }
                TxtResultaat.AppendText(Environment.NewLine);
            }
        }

        private void BtnRuit_Click(object sender, EventArgs e)
        {
            int size;

            TxtResultaat.Clear();

            try
            {
                size = Convert.ToInt16(TxtGrootte.Text);
                if (size < 1 || size > 20)
                {
                    MessageBox.Show("Geef een waarde van 1 tot en met 20 in!");
                    TxtGrootte.Clear();
                    TxtGrootte.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Geef een geheel getal in!");
                TxtGrootte.Clear();
                TxtGrootte.Focus();
                return;
            }

            for (int i = 1; i <= size; i++)
            {
                foreach (int value in Enumerable.Range(1, size-i))
                    TxtResultaat.AppendText(" ");
                foreach (int value in Enumerable.Range(1, 2 * i - 1))
                    TxtResultaat.AppendText("*");
                TxtResultaat.AppendText(Environment.NewLine);
            }

            for (int i = size - 1; i >= 1; i--)
            {
                foreach (int value in Enumerable.Range(1, size - i))
                    TxtResultaat.AppendText(" ");
                foreach (int value in Enumerable.Range(1, 2 * i - 1))
                    TxtResultaat.AppendText("*");
                TxtResultaat.AppendText(Environment.NewLine);
            }
        }

        private void BtnDriehoek_Click(object sender, EventArgs e)
        {
            int size;

            TxtResultaat.Clear();

            try
            {
                size = Convert.ToInt16(TxtGrootte.Text);
                if (size < 1 || size > 20)
                {
                    MessageBox.Show("Geef een waarde van 1 tot en met 20 in!");
                    TxtGrootte.Clear();
                    TxtGrootte.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Geef een geheel getal in!");
                TxtGrootte.Clear();
                TxtGrootte.Focus();
                return;
            }

            for (int i = 1; i <= size; i++)
            {
                foreach (int value in Enumerable.Range(1, size - i))
                    TxtResultaat.AppendText(" ");
                foreach (int value in Enumerable.Range(1, 2 * i - 1))
                    TxtResultaat.AppendText("*");
                TxtResultaat.AppendText(Environment.NewLine);
            }
        }

        private void BtnVierkantRand_Click(object sender, EventArgs e)
        {
            int size;

            TxtResultaat.Clear();

            try
            {
                size = Convert.ToInt16(TxtGrootte.Text);
                if (size < 1 || size > 20)
                {
                    MessageBox.Show("Geef een waarde van 1 tot en met 20 in!");
                    TxtGrootte.Clear();
                    TxtGrootte.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Geef een geheel getal in!");
                TxtGrootte.Clear();
                TxtGrootte.Focus();
                return;
            }

            for (int i = 1; i <= size; i++)
            {
                TxtResultaat.AppendText("* ");
                for (int j = 1; j <= size - 2; j++)
                {
                    if (i == 1 || i == size)
                        TxtResultaat.AppendText("* ");
                    else
                        TxtResultaat.AppendText("  ");
                }
                TxtResultaat.AppendText("* " + Environment.NewLine);
            }
        }
    }
}