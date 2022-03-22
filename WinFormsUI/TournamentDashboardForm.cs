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
    public partial class FrmTournamentDashboard : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();

        public FrmTournamentDashboard()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            LoadTournamentDropDown.DataSource = tournaments;
            LoadTournamentDropDown.DisplayMember = "TournamentName";
        }

        private void BtnCreateTournament_Click(object sender, EventArgs e)
        {
            FrmCreateTournament frm = new FrmCreateTournament();
            frm.Show();
        }

        private void BtnLoadTournament_Click(object sender, EventArgs e)
        {
            TournamentModel tm = (TournamentModel)LoadTournamentDropDown.SelectedItem;
            FrmTournamentViewer frm = new FrmTournamentViewer(tm);
            frm.Show();
        }
    }
}
