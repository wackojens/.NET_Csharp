namespace Opdracht18_Lotto_JC
{
    public partial class FrmLotto : Form
    {
        public FrmLotto()
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
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Random r = new();

            for (int i = 1; i <= 6; i++)
            {
                TxtResultaat.AppendText("Getal " + i + " : " + (_ = r.Next(1, 46)) + Environment.NewLine);
            }
        }
    }
}