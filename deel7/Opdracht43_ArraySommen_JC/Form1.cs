namespace Opdracht43_ArraySommen_JC
{
    public partial class FrmArraySom : Form
    {
        public FrmArraySom()
        {
            InitializeComponent();
        }

        private void BtnSluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSom_Click(object sender, EventArgs e)
        {
            TxtResultaat.Clear();

            int[] getallen1 = new int[10], getallen2 = new int[10], sommen = new int[10];
            int r1, r2;

            Random random1 = new();
            Random random2 = new();

            for (int i = 0; i < getallen1.Length; i++)
            {
                r1 = random1.Next(0, 100);
                r2 = random2.Next(0,100);

                getallen1[i] = r1;
                getallen2[i] = r2;
                sommen[i] = r1 + r2;

                TxtResultaat.AppendText(string.Format("{0,3} + {1,3} = {2,3}", getallen1[i], getallen2[i], sommen[i]) + Environment.NewLine);
                // Cijfers in arrays steken is overbodig: format("...", r1, r2, r1+r2)
            }
        }
    }
}