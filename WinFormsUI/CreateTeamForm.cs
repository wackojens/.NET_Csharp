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
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;

        public FrmCreateTeam(ITeamRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            //CreateSampleData();

            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Jens", LastName = "Coomans" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Snej", LastName = "Snamooc" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Jen", LastName = "Cooman" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Nej", LastName = "Namooc" });
        }

        private void WireUpLists()
        {
            SelectTeamMemberDropDown.DataSource = null;

            SelectTeamMemberDropDown.DataSource = availableTeamMembers;
            SelectTeamMemberDropDown.DisplayMember = "FullName";

            TeamMembersListBox.DataSource = null;

            TeamMembersListBox.DataSource = selectedTeamMembers;
            TeamMembersListBox.DisplayMember = "FullName";
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

                selectedTeamMembers.Add(p);

                WireUpLists();

                TxtFirstName.Text = "";
                TxtLastName.Text = "";
                TxtEmail.Text = "";
                TxtPhoneNumber.Text = "";
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

        private void BtnAddPlayer_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)SelectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void BtnRemoveSelectedPlayer_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TeamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void BtnCreateTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = TxtTeamName.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();
        }
    }
}
