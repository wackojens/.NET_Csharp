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
using TrackerLibrary.Models;

namespace WinFormsUI
{
    public partial class FrmCreateTeam : Form
    {
        public FrmCreateTeam()
        {
            InitializeComponent();
        }

        private void BtnCreatePlayer_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = TxtFirstName.Text;
                p.LastName = TxtLastName.Text;
                p.EmailAdress = TxtEmail.Text;
                p.CellphoneNumber = TxtPhoneNumber.Text;

                GlobalConfig.Connection.CreatePerson(p);
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields.");
            }
        }

        private bool ValidateForm()
        {
            if (TxtFirstName.Text.Length == 0)
            {
                return false;
            }

            if (TxtLastName.Text.Length == 0)
            {
                return false;
            }

            if (TxtEmail.Text.Length == 0)
            {
                return false;
            }

            if (TxtPhoneNumber.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
