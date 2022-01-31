namespace Opdracht20_Vermenigvuldigingstafels_JC
{
    public partial class FrmTafels : Form
    {
        public FrmTafels()
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
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    TxtResultaat.AppendText(String.Format("{0, 2} * {1, 2} = {2, 3}", i, j, i * j) + Environment.NewLine);
                }
                TxtResultaat.AppendText(Environment.NewLine);
            }
        }
    }
}