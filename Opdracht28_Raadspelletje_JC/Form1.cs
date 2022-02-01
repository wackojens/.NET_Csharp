namespace Opdracht28_Raadspelletje_JC
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
            Random r = new();
            getal = r.Next(0, 101);


            do
            {
                try
                {
                    gok = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Geef een getal van 0 tot 100", "Raadspel"));
                    if (gok < 0 || gok > 100)
                    {
                        MessageBox.Show("Getal mag niet kleiner dan 0 of groter dan 100 zijn!");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Geef een numerieke waarde in!");
                    return;
                }
                teller++;

            }
            while (Compare_Guess(gok, getal, teller));
        }


        private bool Compare_Guess(int gok, int getal, int teller)
        {
            if (gok < getal)
            {
                MessageBox.Show("Hoger!");
                return true;
            }
            else if (gok > getal)
            {
                MessageBox.Show("Lager!");
                return true;
            }
            else
            {
                MessageBox.Show("U heeft het getal geraden in " + teller + " beurten.");
                return false;
            }
        }
    
    }
}