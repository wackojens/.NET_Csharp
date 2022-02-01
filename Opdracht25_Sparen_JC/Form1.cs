namespace Opdracht25_Sparen_JC
{
    public partial class FrmSparen : Form
    {
        public FrmSparen()
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
            TxtSpaarbedrag.Clear();
            TxtVerhoging.Clear();
            TxtWeekgeld.Clear();
            TxtWeekgeld.Focus();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            double weekgeld, totaal, verhoging, gewenst, startgeld;
            int teller = 0;

            TxtResultaat.Clear();

            try
            {
                weekgeld = Convert.ToDouble(TxtWeekgeld.Text);
                if (CheckNegative(weekgeld))
                {
                    TxtWeekgeld.Clear();
                    TxtWeekgeld.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtWeekgeld.Clear();
                TxtWeekgeld.Focus();
                return;
            }

            try
            {
                verhoging = Convert.ToDouble(TxtVerhoging.Text);
                if (CheckNegative(verhoging))
                {
                    TxtVerhoging.Clear();
                    TxtVerhoging.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtVerhoging.Clear();
                TxtVerhoging.Focus();
                return;
            }

            try
            {
                gewenst = Convert.ToDouble(TxtSpaarbedrag.Text);
                if (CheckNegative(gewenst))
                {
                    TxtSpaarbedrag.Clear();
                    TxtSpaarbedrag.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtSpaarbedrag.Clear();
                TxtSpaarbedrag.Focus();
                return;
            }

            
            /* methode met elke week een verhoging (zoals opdracht bedoeld lijkt): 
            
            totaal = weekgeld;

            do
            {
                weekgeld += verhoging;
                totaal += weekgeld;
                teller++;
            }
            while (totaal < gewenst);
            
            TxtResultaat.Text = "Spaarbedrag na " + teller + " weken: " + totaal.ToString("C") + Environment.NewLine +
                Environment.NewLine + "Weekgeld op dat moment: " + weekgeld.ToString("C");
            */
            


            // methode met een eenmalige verhoging (zoals de voorbeeldafbeelding laat zien):

            teller = Convert.ToInt32(Math.Ceiling(gewenst / (weekgeld + verhoging)));

            TxtResultaat.Text = "Spaarbedrag na " + teller + " weken: " + (weekgeld * teller).ToString("C") + Environment.NewLine +
                Environment.NewLine + "Extra weekgeld op dat moment: " + (verhoging * teller).ToString("C") + Environment.NewLine +
                Environment.NewLine + "Totaal spaargeld: " + ((weekgeld + verhoging) * teller).ToString("C");
            
        }

        private static bool CheckNegative(double number)
        {
            if (number < 0)
            {
                MessageBox.Show("Waarde moet positief zijn!");
                return true;
            }
            else
                return false;
        }
        
    }
}