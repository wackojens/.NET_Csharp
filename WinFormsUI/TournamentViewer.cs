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
    public partial class FrmTournamentViewer : Form
    {
        private TournamentModel tournament;
        List<int> rounds = new List<int>();
        List<MatchupModel> selectedMatchups = new List<MatchupModel>(); 

        public FrmTournamentViewer(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            LoadFormData();

            LoadRounds();
        }

        private void LoadFormData()
        {
            LblTournamentName.Text = tournament.TournamentName;
        }

        private void WireUpRoundsList()
        {
            RoundDropDown.DataSource = null;
            RoundDropDown.DataSource = rounds;
        }

        private void WireUpMatchupsList()
        {
            MatchupListBox.DataSource = null;
            MatchupListBox.DataSource = selectedMatchups;
            MatchupListBox.DisplayMember = "DisplayName";
        }

        private void LoadRounds()
        {
            rounds = new List<int>();

            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }

            WireUpRoundsList();
        }

        private void RoundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        private void LoadMatchups()
        {
            int round = (int)RoundDropDown.SelectedItem;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    foreach (MatchupModel m in matchups)
                    {
                        if (m.Winner == null || !UnplayedCheckBox.Checked)
                        {
                            selectedMatchups.Add(m);
                        }
                    }
                }
            }

            WireUpMatchupsList();

            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);

            LblTeam1.Visible = isVisible;
            LblScoreTeam1.Visible = isVisible;
            TxtScoreTeam1.Visible = isVisible;
            LblVersus.Visible = isVisible;
            LblTeam2.Visible = isVisible;
            LblScoreTeam2.Visible = isVisible;
            TxtScoreTeam2.Visible = isVisible;
            BtnScore.Visible = isVisible;
        }

        private void LoadMatchup()
        {
            MatchupModel m = (MatchupModel)MatchupListBox.SelectedItem;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        LblTeam1.Text = m.Entries[0].TeamCompeting.TeamName;
                        TxtScoreTeam1.Text = m.Entries[0].Score.ToString();

                        LblTeam2.Text = "<bye>";
                        TxtScoreTeam2.Text = "0";
                    }
                    else
                    {
                        LblTeam1.Text = "Not yet set";
                        TxtScoreTeam1.Text = "";
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        LblTeam2.Text = m.Entries[1].TeamCompeting.TeamName;
                        TxtScoreTeam2.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        LblTeam2.Text = "Not yet set";
                        TxtScoreTeam2.Text = "";
                    }
                }
            }
        }

        private void MatchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MatchupListBox.SelectedIndex != -1)
            {
                LoadMatchup();
            }
        }

        private void UnplayedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        private string ValidateData()
        {
            string output = "";

            double teamOneScore = 0;
            double teamTwoScore = 0;

            bool scoreOneValid = double.TryParse(TxtScoreTeam1.Text, out teamOneScore);
            bool scoreTwoValid = double.TryParse(TxtScoreTeam2.Text, out teamTwoScore);

            if (!scoreOneValid)
            {
                output = "The score of team one is not a valid number.";
            }
            else if (!scoreTwoValid)
            {
                output = "The score of team two is not a valid number.";
            }
            else if (teamOneScore == 0 && teamTwoScore == 0)
            {
                output = "You did not enter a score for either team.";
            }
            else if (teamOneScore == teamTwoScore)
            {
                output = "We do not allow ties in this application.";
            }

            return output;
        }

        private void BtnScore_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateData();
            if (errorMessage.Length > 0)
            {
                MessageBox.Show($"Input error: { errorMessage }");
                return;
            }

            MatchupModel m = (MatchupModel)MatchupListBox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(TxtScoreTeam1.Text, out teamOneScore);
                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 1.");
                            return;
                        }
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(TxtScoreTeam2.Text, out teamTwoScore);
                        if (scoreValid)
                        {
                            m.Entries[1].Score = teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team 2.");
                            return;
                        }
                    }
                }
            }

            try
            {
                TournamentLogic.UpdateTournamentResults(tournament);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The application had te following error: { ex.Message }");
                return;
            }

            LoadMatchups();
        }
    }
}