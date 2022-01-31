namespace Opdracht14_Leeftijd_JC
{
    public partial class FrmLeeftijd : Form
    {
        public FrmLeeftijd()
        {
            InitializeComponent();
            this.Text = "Leeftijd in dagen, maanden en jaren" + "                " + DateTime.Now.ToString("D");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTijd.Text = DateTime.Now.ToString("HH:mm:ss tt");    
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            DateTime geboorteDatum;
            var vandaag = DateTime.Today;
            int dagen, maanden, jaren;

            try
            {
                geboorteDatum = Convert.ToDateTime(TxtGeboorteDat.Text);
            }
            catch
            {
                MessageBox.Show("Geef je geboortedatum op volgende wijze in: 'dd/mm/yyyy'");
                TxtDagen.Clear();
                TxtMaanden.Clear();
                TxtJaren.Clear();
                TxtGeboorteDat.Clear();
                TxtGeboorteDat.Focus();
                return;
            }

            dagen = (vandaag.Date - geboorteDatum.Date).Days;
            TxtDagen.Text = Convert.ToString(dagen);

            maanden = Convert.ToInt32(Math.Floor(dagen / 30.437));
            TxtMaanden.Text = Convert.ToString(maanden);

            jaren = vandaag.Year - geboorteDatum.Year;
            if (geboorteDatum > vandaag.AddYears(-jaren))
                jaren -= 1;
            TxtJaren.Text = Convert.ToString(jaren);
        }
    }
}