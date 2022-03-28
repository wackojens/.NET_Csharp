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
    public partial class FrmCreateTournament : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public FrmCreateTournament()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            SelectTeamDropDown.DataSource = null;

            SelectTeamDropDown.DataSource = availableTeams;
            SelectTeamDropDown.DisplayMember = "TeamName";

            TournamentTeamsListBox.DataSource = null;

            TournamentTeamsListBox.DataSource = selectedTeams;
            TournamentTeamsListBox.DisplayMember = "TeamName";

            PrizesListBox.DataSource = null;

            PrizesListBox.DataSource = selectedPrizes;
            PrizesListBox.DisplayMember = "PlaceName";
        }

        private void BtnAddTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)SelectTeamDropDown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
        }

        private void BtnCreatePrize_Click(object sender, EventArgs e)
        {
            // call the FrmCreatePrize
            FrmCreatePrize frm = new FrmCreatePrize(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            // get back from the form a PrizeModel
            // take the prizeModel and put it into our list of selected prizes
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void CreateNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCreateTeam frm = new FrmCreateTeam(this);
            frm.Show();
        }

        private void BtnRemoveSelectedTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)TournamentTeamsListBox.SelectedItem;

            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpLists();
            }
        }

        private void BtnRemoveSelectedPrize_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)PrizesListBox.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);

                WireUpLists();
            }
        }

        private void BtnCreateTournament_Click(object sender, EventArgs e)
        {
            //validate data
            decimal fee = 0;

            bool feeAcceptable = decimal.TryParse(TxtEntryFee.Text, out fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid entry fee", "Invalid fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //create our tournament model
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = TxtTournamentName.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            //create our matchups
            TournamentLogic.CreateRounds(tm);

            //create tournament entry
            //create all of the prize entries
            //create all of the team entries
            GlobalConfig.Connection.CreateTournament(tm);

            tm.AlertUsersToNewRound();

            FrmTournamentViewer frm = new FrmTournamentViewer(tm);
            frm.Show();
            this.Close();
        }
    }
}
