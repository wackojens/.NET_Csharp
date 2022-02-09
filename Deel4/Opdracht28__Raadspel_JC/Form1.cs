namespace Opdracht28__Raadspel_JC
{
    public partial class FrmRaadspel : Form
    {
        public FrmRaadspel()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            int gok, getal, teller = 0;
            string checkReturn;
            Random r = new();
            getal = r.Next(0, 101);


            do
            {
                checkReturn = Microsoft.VisualBasic.Interaction.InputBox("Geef een getal van 0 tot 100", "Raadspel");
                if (checkReturn.Length > 0)
                {
                    try
                    {
                        gok = Convert.ToInt32(checkReturn);
                        if (gok < 0 || gok > 100)
                        {
                            MessageBox.Show("Getal mag niet kleiner dan 0 of groter dan 100 zijn!");
                            gok = -1;
                            teller--;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Geef een geheel getal in!");
                        gok = -1;
                        teller--;
                    }
                    teller++;
                }
                else
                {
                    break;
                }

            }
            while (Compare_Guess(gok, getal, teller));

            pictureBox1.Image = Properties.Resources.thumbsupdown;
        }

        private bool Compare_Guess(int gok, int getal, int teller)
        {
            if (gok == -1)
            {
                return true;
            }
            else if (gok < getal)
            {
                pictureBox1.Image = Properties.Resources.thumbs_up;
                return true;
            }
            else if (gok > getal)
            {
                pictureBox1.Image = Properties.Resources.thumbs_down;
                return true;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.clap;
                MessageBox.Show("U heeft het getal geraden in " + teller + " beurten.");
                return false;
            }
        }
    }
}