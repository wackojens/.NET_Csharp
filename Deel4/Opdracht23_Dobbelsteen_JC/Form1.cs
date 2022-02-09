namespace Opdracht23_Dobbelsteen_JC
{
    public partial class FrmDobbelsteen : Form
    {
        public FrmDobbelsteen()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Random r = new();
            int rnd, teller = 1;

            TxtResultaat.Clear();//Vervangt het nut van BtnOpnieuw

            do
            {
                TxtResultaat.AppendText(String.Format("Worp {0, 3} geeft{1, 2}", teller, rnd = r.Next(1,7)) + Environment.NewLine);
                teller++;
            }
            while (rnd != 6);
        }

        private void BtnOpnieuw_Click(object sender, EventArgs e)
        {
            TxtResultaat.Clear();
            BtnStart.Focus();
        }
    }
}