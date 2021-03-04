/* Name: Jacob Darling, Henry Flores, Skyler Millburn, Garret Waterman
 * Assignment: Group Project
 * Date: 3 MAR 2021
 * Description: Program holds a list of 10 teams participating in a tournament. 
 *              User can add/remove teams, import/export teams, and display all teams
 */
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
        // holds current list of teams in the league
        private List<Team> teams = new List<Team>();

        public GolfLeague_Form()
        {
            InitializeComponent();
            populateTeams();
        }
        // populates fields when a team is added or changed. 
        private void populateTeams()
        {
            // Sort teams by rank
            teams.Sort(( x, y ) => x.TeamTotalScore.CompareTo(y.TeamTotalScore));
            int count = 1;
            foreach (Team team in teams)
            {
                team.Rank = count;
                count++;
            }
            cboxTeams.Items.Clear();
            // disable buttons until team is selected
            btnUpdate.Enabled = false;
            btnImport.Enabled = false;
            btnExport.Enabled = false;
            btnDelete.Enabled = false;
            // Clear old values from team update tab
            clearTeamUpdate();
            // Add teams to the combobox
            foreach (Team team in teams)
            {
                cboxTeams.Items.Add(team.Name);
            }
            // Add 2 extra values to the combobox if there is less than 10 teams
            if (cboxTeams.Items.Count < 10)
            {
                cboxTeams.Items.Add("Add new team");
                cboxTeams.Items.Add("Add random team");
            }
            cboxTeams.SelectedIndex = -1;
            // Populate the tree view to display all the team information
            treeView1.Nodes.Clear();
            populateTreeView();
        }
        // Event to handle selected team changed
        private void cboxTeams_SelectedIndexChanged( object sender, EventArgs e )
        {
            btnUpdate.Enabled = true;
            if(cboxTeams.SelectedItem.ToString() != "Add new team" && cboxTeams.SelectedItem.ToString() != "Add random team")
            {
                Team selectedTeam = teams[cboxTeams.SelectedIndex];
                btnUpdate.Text = "Update Team";
                btnDelete.Enabled = true;
                btnExport.Enabled = true;
                populateTeamUpdate(selectedTeam);
            }
            // Add a team filled with random data and enable add buttons
            else if (cboxTeams.SelectedItem.ToString() == "Add random team")
            {
                btnImport.Enabled = true;
                btnUpdate.Text = "Add Team";
                btnDelete.Enabled = false;

                Team tempTeam = new Team();
                tempTeam.Name = RandGenTeam.GetTeamName();
                bool duplicate = false;
                foreach (Team team in teams)
                {
                    if (tempTeam.Name.Equals(team))
                        duplicate = true;
                }
                while (duplicate)
                {
                    tempTeam.Name = RandGenTeam.GetTeamName();
                    duplicate = false;
                    foreach (Team team in teams)
                    {
                        if (tempTeam.Name.Equals(team))
                            duplicate = true;
                    }
                }
                tempTeam.Rank = 1;

                for ( int i = 0; i < 4; i++ )
                {
                    tempTeam.updatePlayer(RandGenTeam.getPlayer(), i);
                }
                populateTeamUpdate(tempTeam);
            }
            // clear form and enable add buttons
            else
            {
                btnImport.Enabled = true;
                btnUpdate.Text = "Add Team";
                btnDelete.Enabled = false;
                clearTeamUpdate();
            }
        }
        // Fills textboxes with team information
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
        // clears textboxes string values
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
        // Handles the update/Add button
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
            tempPlayer = new Player();
            tempPlayer.FirstName = txtG2FName.Text;
            tempPlayer.LastName = txtG2LName.Text;
            tempPlayer.Handicap = int.Parse(txtG2Handicap.Text);
            tempPlayer.LastGameScore = int.Parse(txtG2GameScore.Text);
            tempPlayer.TeamRank = int.Parse(txtG2Rank.Text);
            tempTeam.updatePlayer(tempPlayer, 1);
            tempPlayer = new Player();
            tempPlayer.FirstName = txtG3FName.Text;
            tempPlayer.LastName = txtG3LName.Text;
            tempPlayer.Handicap = int.Parse(txtG3Handicap.Text);
            tempPlayer.LastGameScore = int.Parse(txtG3GameScore.Text);
            tempPlayer.TeamRank = int.Parse(txtG3Rank.Text);
            tempTeam.updatePlayer(tempPlayer, 2);
            tempPlayer = new Player();
            tempPlayer.FirstName = txtG4FName.Text;
            tempPlayer.LastName = txtG4LName.Text;
            tempPlayer.Handicap = int.Parse(txtG4Handicap.Text);
            tempPlayer.LastGameScore = int.Parse(txtG4GameScore.Text);
            tempPlayer.TeamRank = int.Parse(txtG4Rank.Text);
            tempTeam.updatePlayer(tempPlayer, 3);
            tempTeam.Sort();
            tempTeam.CalculateTeamScore();
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
        // handles the delete team button
        private void btnDelete_Click( object sender, EventArgs e )
        {
            teams.RemoveAt(cboxTeams.SelectedIndex);
            populateTeams();
        }
        // handles the clear button
        private void btnClear_Click( object sender, EventArgs e )
        {
            clearTeamUpdate();
        }
        // Handles import button
        private void btnImport_Click( object sender, EventArgs e )
        {
            Team tempTeam = new Team();
            tempTeam.Name = RandGenTeam.GetTeamName();
            tempTeam.Rank = 1;

            for (int i =0; i < 4; i++ )
            {
                tempTeam.updatePlayer(RandGenTeam.getPlayer(), i);
            }
            populateTeamUpdate(tempTeam);
        }
        // handles export button
        private void btnExport_Click( object sender, EventArgs e )
        {
            MessageBox.Show(teams[cboxTeams.SelectedIndex].ToString());
        }
        // Populates the tree view
        private void populateTreeView()
        {
            foreach (Team team in teams)
            {
                var treeNodes = new List<TreeNode>();
                var childNodes = new List<TreeNode>();

                for ( int i = 0; i < 4; i++ )
                {

                    Player tempPlayer = team.getPlayer(i);
                    if(tempPlayer.FirstName != "")
                    {
                        childNodes.Add(new TreeNode(tempPlayer.toDisplayString()));
                    }
                }
                treeNodes.Add(new TreeNode(team.Rank + " " + team.Name + " Team Score: " + team.TeamTotalScore, childNodes.ToArray()));
                treeView1.Nodes.AddRange(treeNodes.ToArray());
            }
        }

        // Limits users to only digits in certain textboxes. Handle keypress event
        private void limitToNumbers( object sender, KeyPressEventArgs e )
        {
            // allow only control characters, and 3 digits
            if ( !char.IsControl(e.KeyChar) && ( !char.IsDigit(e.KeyChar) || ( sender as TextBox ).TextLength >= 3 ) )
            {
                MessageBox.Show("This field accepts 3 digits only");
                e.Handled = true;
            }
        }
    }
}
