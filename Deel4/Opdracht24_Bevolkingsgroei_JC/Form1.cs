namespace Opdracht24_Bevolkingsgroei_JC
{
    public partial class FrmBevolkingsgroei : Form
    {
        public FrmBevolkingsgroei()
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
            TxtGroeiPercent.Clear();
            TxtBevolking.Clear();
            TxtLand.Clear();
            TxtLand.Focus();
        }

        private void BtnBereken_Click(object sender, EventArgs e)
        {
            double groeiPercent;
            int bevolkingStart, bevolking, jaren = 0;

            try
            {
                bevolkingStart = Convert.ToInt32(TxtBevolking.Text);
            }
            catch
            {
                MessageBox.Show("Geef een geheel getal in!");
                TxtBevolking.Clear();
                TxtBevolking.Focus();
                return;
            }

            try
            {
                groeiPercent = Convert.ToDouble(TxtGroeiPercent.Text);
            }
            catch
            {
                MessageBox.Show("Geef een numerieke waarde in!");
                TxtGroeiPercent.Clear();
                TxtGroeiPercent.Focus();
                return;
            }

            bevolking = bevolkingStart;
            groeiPercent = groeiPercent / 100 + 1;

            do
            {
                bevolking = Convert.ToInt32(bevolking * groeiPercent);
                jaren++;
            }
            while (bevolking < (bevolkingStart * 2));

            TxtResultaat.Text = "Verdubbeling bevolking " + TxtLand.Text + " na " + jaren + " jaren." + Environment.NewLine +
            Environment.NewLine + "Nieuw bevolkingsaantal op dat moment: " + bevolking;
        }
    }
}