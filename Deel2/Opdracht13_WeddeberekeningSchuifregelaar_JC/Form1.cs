namespace Opdracht13_WeddeberekeningSchuifregelaar_JC
{
    public partial class FrmWeddeberekening : Form
    {
        public FrmWeddeberekening()
        {
            InitializeComponent();
        }

        private void TrbInkomen_Scroll(object sender, EventArgs e)
        {
            Ttp1.SetToolTip(TrbInkomen, TrbInkomen.Value.ToString());

            double belasting, inkomen = TrbInkomen.Value;

            if (inkomen < 10000)
            {
                belasting = 0;
            }
            else if (inkomen >= 10000 && inkomen < 50000)
            {
                belasting = Math.Round((inkomen * 0.5), 1);
            }
            else
            {
                belasting = Math.Round((inkomen * 0.9), 1);
            }

            LblBelastingVal.Text = belasting.ToString();

            /* indien je met belastingsschijven wil werken:
            
            if (inkomen >= 50000)
            {
                belasting = Math.Round(((inkomen - 49999) * 0.9) + (40000 * 0.2), 1);
            }   
            else if (inkomen >= 10000)
            {
                belasting = Math.Round(((inkomen - 9999) * 0.2), 1);
            }
            else
            {
                belasting = 0;
            }

            LblBelastingVal.Text = belasting.ToString();
            */
        }
    }
}