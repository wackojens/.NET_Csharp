using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAcces;
using TrackerLibrary.Models;

namespace WinFormsUI
{
    public partial class FrmCreatePrize : Form
    {
        public FrmCreatePrize()
        {
            InitializeComponent();
        }

        private void BtnCreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    TxtPlaceName.Text, 
                    TxtPlaceNumber.Text, 
                    TxtPrizeAmount.Text, 
                    TxtPrizePercentage.Text);

                GlobalConfig.Connection.CreatePrize(model);

                TxtPlaceName.Clear();
                TxtPlaceNumber.Clear();
                TxtPrizeAmount.Text = "0";
                TxtPrizePercentage.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(TxtPlaceNumber.Text, out placeNumber);
            decimal prizeAmount;
            double prizePercentage;
            bool prizeAmountValid = decimal.TryParse(TxtPrizeAmount.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(TxtPrizePercentage.Text, out prizePercentage);

            if (!placeNumberValidNumber)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (TxtPlaceName.Text.Length == 0)
            {
                output = false;
            }

            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
