using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CIS353GroupB
{
    public partial class GolfLeague_Form : Form
    {

        private List<Team> teams = new List<Team>();

        public GolfLeague_Form()
        {
            InitializeComponent();
            populateTeams();
        }

        private void populateTeams()
        {
            cboxTeams.Items.Clear();
            btnUpdate.Enabled = false;
            btnImport.Enabled = false;
            btnExport.Enabled = false;
            btnDelete.Enabled = false;
            clearTeamUpdate();
            foreach (Team team in teams)
            {
                cboxTeams.Items.Add(team.Name);
            }
            if (cboxTeams.Items.Count < 10)
            {
                cboxTeams.Items.Add("Add new team");
            }
            cboxTeams.SelectedIndex = -1;
        }

        private void cboxTeams_SelectedIndexChanged( object sender, EventArgs e )
        {
            btnUpdate.Enabled = true;
            if(cboxTeams.SelectedItem.ToString() != "Add new team")
            {
                Team selectedTeam = teams[cboxTeams.SelectedIndex];
                btnUpdate.Text = "Update Team";
                btnDelete.Enabled = true;
                btnExport.Enabled = true;
                populateTeamUpdate(selectedTeam);
            }
            else
            {
                btnImport.Enabled = true;
                btnUpdate.Text = "Add Team";
                btnDelete.Enabled = false;
                clearTeamUpdate();
            }
        }
        private void populateTeamUpdate(Team team)
        {
            txtTeamName.Text = team.Name;
            txtTeamRank.Text = team.Rank.ToString();
            Player player = team.getPlayer(0);
            txtG1FName.Text = player.FirstName;
            txtG1LName.Text = player.LastName;
            txtG1Handicap.Text = player.Handicap.ToString();
            txtG1GameScore.Text = player.LastGameScore.ToString();
            txtG1Rank.Text = player.TeamRank.ToString();
            player = team.getPlayer(1);
            txtG2FName.Text = player.FirstName;
            txtG2LName.Text = player.LastName;
            txtG2Handicap.Text = player.Handicap.ToString();
            txtG2GameScore.Text = player.LastGameScore.ToString();
            txtG2Rank.Text = player.TeamRank.ToString();
            player = team.getPlayer(2);
            txtG3FName.Text = player.FirstName;
            txtG3LName.Text = player.LastName;
            txtG3Handicap.Text = player.Handicap.ToString();
            txtG3GameScore.Text = player.LastGameScore.ToString();
            txtG3Rank.Text = player.TeamRank.ToString();
            player = team.getPlayer(3);
            txtG4FName.Text = player.FirstName;
            txtG4LName.Text = player.LastName;
            txtG4Handicap.Text = player.Handicap.ToString();
            txtG4GameScore.Text = player.LastGameScore.ToString();
            txtG4Rank.Text = player.TeamRank.ToString();
        }

        private void clearTeamUpdate()
        {
            cboxTeams.Text = "";
            txtTeamName.Text = "";
            txtTeamRank.Text = "";
            txtG1FName.Text = "";
            txtG1LName.Text = "";
            txtG1Handicap.Text = "";
            txtG1GameScore.Text = "";
            txtG1Rank.Text = "";
            txtG2FName.Text = "";
            txtG2LName.Text = "";
            txtG2Handicap.Text = "";
            txtG2GameScore.Text = "";
            txtG2Rank.Text = "";
            txtG3FName.Text = "";
            txtG3LName.Text = "";
            txtG3Handicap.Text = "";
            txtG3GameScore.Text = "";
            txtG3Rank.Text = "";
            txtG4FName.Text = "";
            txtG4LName.Text = "";
            txtG4Handicap.Text = "";
            txtG4GameScore.Text = "";
            txtG4Rank.Text = "";
        }

        private void btnUpdate_Click( object sender, EventArgs e )
        {
            Team tempTeam = new Team();
            tempTeam.Name = txtTeamName.Text;
            tempTeam.Rank = int.Parse(txtTeamRank.Text);
            Player tempPlayer = new Player();
            tempPlayer.FirstName = txtG1FName.Text;
            tempPlayer.LastName = txtG1LName.Text;
            tempPlayer.Handicap = int.Parse(txtG1Handicap.Text);
            tempPlayer.LastGameScore = int.Parse(txtG1GameScore.Text);
            tempPlayer.TeamRank = int.Parse(txtG1Rank.Text);
            tempTeam.updatePlayer(tempPlayer, 0);
            tempPlayer.FirstName = txtG2FName.Text;
            tempPlayer.LastName = txtG2LName.Text;
            tempPlayer.Handicap = int.Parse(txtG2Handicap.Text);
            tempPlayer.LastGameScore = int.Parse(txtG2GameScore.Text);
            tempPlayer.TeamRank = int.Parse(txtG2Rank.Text);
            tempTeam.updatePlayer(tempPlayer, 1);
            tempPlayer.FirstName = txtG3FName.Text;
            tempPlayer.LastName = txtG3LName.Text;
            tempPlayer.Handicap = int.Parse(txtG3Handicap.Text);
            tempPlayer.LastGameScore = int.Parse(txtG3GameScore.Text);
            tempPlayer.TeamRank = int.Parse(txtG3Rank.Text);
            tempTeam.updatePlayer(tempPlayer, 2);
            tempPlayer.FirstName = txtG4FName.Text;
            tempPlayer.LastName = txtG4LName.Text;
            tempPlayer.Handicap = int.Parse(txtG4Handicap.Text);
            tempPlayer.LastGameScore = int.Parse(txtG4GameScore.Text);
            tempPlayer.TeamRank = int.Parse(txtG4Rank.Text);
            tempTeam.updatePlayer(tempPlayer, 3);
            if ( btnUpdate.Text == "Update Team" )
            {
                teams[cboxTeams.SelectedIndex] = tempTeam;
            }
            else
            {
                teams.Add(tempTeam);
            }
            populateTeams();
        }

        private void btnDelete_Click( object sender, EventArgs e )
        {
            teams.RemoveAt(cboxTeams.SelectedIndex);
            populateTeams();
        }

        private void btnClear_Click( object sender, EventArgs e )
        {
            clearTeamUpdate();
        }

        private void btnImport_Click( object sender, EventArgs e )
        {
            Team tempTeam = new Team();
            tempTeam.Name = "FuzzyWuzzy";
            tempTeam.Rank = 1;
            Player tempPlayer = new Player("Fuzzy,Wuzzy,1,2,3");
            for (int i =0; i < 4; i++ )
            {
                tempTeam.updatePlayer(RandGenTeam.getPlayer(), i);
            }
            populateTeamUpdate(tempTeam);
        }

        private void btnExport_Click( object sender, EventArgs e )
        {
            MessageBox.Show(teams[cboxTeams.SelectedIndex].ToString());
        }
    }
}
