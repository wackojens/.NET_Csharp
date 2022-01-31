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
    }
}