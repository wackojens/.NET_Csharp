namespace Opdracht44_Lotto2_JC
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
            TxtResultaat.Clear();

            int[] cijfers = new int[6];
            int r, teller = 0;

            Random random = new();

            do
            {
                r = random.Next(1, 46);

                if (!cijfers.Contains(r))
                {
                    cijfers[teller] = r;
                    TxtResultaat.AppendText(String.Format("Getal {0,1}: {1,2}", teller + 1, r) + Environment.NewLine);
                    teller++;
                }

            }
            while (teller < 6);
        }
    }
}