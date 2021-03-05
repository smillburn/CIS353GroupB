﻿/* Name: Jacob Darling, Henry Flores, Skyler Millburn, Garret Waterman
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
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Diagnostics;

namespace CIS353GroupB
{
    public partial class GolfLeague_Form : Form
    {
        // holds current list of teams in the league
        private List<Team> teams = new List<Team>();

        // File dialog to import files from file system
        OpenFileDialog openFileDialog1 = new OpenFileDialog
        {
            InitialDirectory = AppDomain.CurrentDomain.BaseDirectory //opens filedialog at application root
        };

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
                    if (tempTeam.Equals(team))
                    {
                        duplicate = true;
                    }
                }
                while (duplicate)
                {
                    tempTeam.Name = RandGenTeam.GetTeamName();
                    duplicate = false;
                    foreach (Team team in teams)
                    {
                        if (tempTeam.Equals(team))
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

            foreach ( TextBox t in tabCreateTeam.Controls.OfType<TextBox>() )
            {
                t.Text = "";
            }
        }
        private void SaveTeams(Team team)
        {
            // save/append? team to file - single file??
            FileStream outFile = new FileStream("teams.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            using (StreamWriter writer = new StreamWriter(outFile))
            {
                writer.WriteLine(team.ToString() + "\n");
            }
        }
        private void LoadTeams()
        {
            //need to take the teams.txt file and move it into the tree view append teams.
            // turn each team into object, then append object to "teams" list. finally, update treview with method.
            if (File.Exists("teams.txt"))
            {
                //var teams = new List<Team>(); // create list to hold teams in text file

                FileStream inFile = new FileStream("teams.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
                using (StreamReader reader = new StreamReader(inFile))
                {
                    string line;
                    int index = 0; // runs through and keeps track of teams outside of the lines will always be 0-4
                    int lnumber = 0;
                    int t = 0; //to help add new team objects to team list

                    while ((line = reader.ReadLine()) != null)
                    {
                        // need to make some assumptions about the text file this information is in.
                        // each object will be 5 lines followed by a blank line.
                        // line 1 is team name and rank
                        // each line, 2-4, will contain a full player object.

                        if (index >= 0 && index < 5)
                        {

                            switch (index)
                            {
                                case (0):
                                    teams.Add(new Team());
                                    teams[t].Name = line.Split(',')[0];
                                    break;
                                case (1):
                                    Player Player1 = new Player(line);
                                    teams[t].updatePlayer(Player1, 0);
                                    break;
                                case (2):
                                    Player Player2 = new Player(line);
                                    teams[t].updatePlayer(Player2, 1);
                                    break;
                                case (3):
                                    Player Player3 = new Player(line);
                                    teams[t].updatePlayer(Player3, 2);
                                    break;
                                case (4):
                                    Player Player4 = new Player(line);
                                    teams[t].updatePlayer(Player4, 3);
                                    teams[t].Sort();
                                    teams[t].CalculateTeamScore();
                                    //teams.Add(teams[t]);
                                    //populateTeams(); maybe do this last
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            index = -1;
                            t++;
                        }

                        lnumber++;
                        index++;
                    }
                }
                populateTeams();
            }
        }
        // Handles the update/Add button
        private void btnUpdate_Click( object sender, EventArgs e )
        {
            try
            {
                Team tempTeam = new Team();
                tempTeam.Name = txtTeamName.Text != "" ? txtTeamName.Text : throw new ArgumentNullException();
                tempTeam.Rank = int.Parse(txtTeamRank.Text);
                Player tempPlayer = new Player();
                tempPlayer = validatePlayer(txtG1FName, txtG1LName, txtG1Handicap, txtG1GameScore, txtG1Rank);
                tempTeam.updatePlayer(tempPlayer, 0);
                tempPlayer = validatePlayer(txtG2FName, txtG2LName, txtG2Handicap, txtG2GameScore, txtG2Rank);
                tempTeam.updatePlayer(tempPlayer, 1);
                tempPlayer = validatePlayer(txtG3FName, txtG3LName, txtG3Handicap, txtG3GameScore, txtG3Rank);
                tempTeam.updatePlayer(tempPlayer, 2);
                tempPlayer = validatePlayer(txtG4FName, txtG4LName, txtG4Handicap, txtG4GameScore, txtG4Rank);
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
            catch ( ArgumentNullException )
            {
                MessageBox.Show("Error parsing team. One or more field is empty");
            }
            // catch parse exception
            catch ( FormatException )
            {
                MessageBox.Show("Error parsing team. Rank, Handicap or score is not a number");
            }
        }
        // validates user input
        public Player validatePlayer(TextBox fname, TextBox lname, TextBox handicap, TextBox score, TextBox rank)
        {
            Player player = new Player();
            player.FirstName = fname.Text != "" ? fname.Text : throw new ArgumentNullException();
            player.LastName = lname.Text != "" ? lname.Text : throw new ArgumentNullException();
            player.Handicap = int.Parse(handicap.Text);
            player.LastGameScore = int.Parse(score.Text);
            player.TeamRank = int.Parse(rank.Text);

            return player;
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
            // Import dialog box
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;

                FileStream inFile = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
                try
                {
                    using (StreamReader reader = new StreamReader(inFile))
                    {
                        string line;
                        int lnumber = 0;
                        while ((line = reader.ReadLine()) != null)
                        {

                            // pull in a single team from a csv, assumes only 4 team members
                            switch (lnumber)
                            {
                                case (0):
                                    txtTeamName.Text = line.Split(',')[0];
                                    txtTeamRank.Text = line.Split(',')[1];
                                    break;

                                case (1):
                                    txtG1FName.Text = line.Split(',')[0];
                                    txtG1LName.Text = line.Split(',')[1];
                                    txtG1Handicap.Text = line.Split(',')[2];
                                    txtG1GameScore.Text = line.Split(',')[3];
                                    txtG1Rank.Text = line.Split(',')[4];
                                    break;

                                case (2):
                                    txtG2FName.Text = line.Split(',')[0];
                                    txtG2LName.Text = line.Split(',')[1];
                                    txtG2Handicap.Text = line.Split(',')[2];
                                    txtG2GameScore.Text = line.Split(',')[3];
                                    txtG2Rank.Text = line.Split(',')[4];
                                    break;

                                case (3):
                                    txtG3FName.Text = line.Split(',')[0];
                                    txtG3LName.Text = line.Split(',')[1];
                                    txtG3Handicap.Text = line.Split(',')[2];
                                    txtG3GameScore.Text = line.Split(',')[3];
                                    txtG3Rank.Text = line.Split(',')[4];
                                    break;

                                case (4):
                                    txtG4FName.Text = line.Split(',')[0];
                                    txtG4LName.Text = line.Split(',')[1];
                                    txtG4Handicap.Text = line.Split(',')[2];
                                    txtG4GameScore.Text = line.Split(',')[3];
                                    txtG4Rank.Text = line.Split(',')[4];
                                    break;

                                default:
                                    break;

                            }

                            lnumber++;
                        }
                    }
                }
                catch
                {

                }
            }
        }
        // handles export button
        private void btnExport_Click( object sender, EventArgs e )
        {
            SaveTeams(teams[cboxTeams.SelectedIndex]);
            
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
                treeNodes.Add(new TreeNode("Rank: " + team.Rank + " " + team.Name + " Team Score: " + team.TeamTotalScore, childNodes.ToArray()));
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
        // Limits users to only alpha characters in certain textboxes. Handle keypress event
        private void limitToAlpha( object sender, KeyPressEventArgs e )
        {
            // allow only control characters, and alpha characters
            if ( !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) )
            {
                MessageBox.Show("This field accepts letters only");
                e.Handled = true;
            }
        }

        private void GolfLeague_Form_Load(object sender, EventArgs e)
        {
            LoadTeams();
        }
    }
}
