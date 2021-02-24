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
    public partial class CreateTeams_Form : Form
    {
        /* Creates form local teamArray which will be used to create a copy of the main data located in program.cs
         * using the assignment in the form constructor underneath the InitializerComponent
         * Henry Flores: 23Feb21 */
        private Team[] teamArray = new Team[10];
        
        public CreateTeams_Form()
        {
            InitializeComponent();
            teamArray = Program.TeamArray;
        }

        private void RandGen_btn_Click(object sender, EventArgs e)
        {
            /*Fill form with random data. Need to make a random class with arrays of first names,
             * last names, handicaps, last score, and team score and randomly select one for entry. 
             * Maybe use IComparable to sort players by score and use array values to display their rank.
             * Henry Flores: 12Feb21
             * 
             * Created class with list of names and numbers to autofill the textboxes,
             * I used a regex to match textbox name for the correct field and used the methods in new class
             * to auto fill the appropiate textbox. Still would like to see some kind of way to calculate
             * the score based on the random handicap and score that was generated. Maybe this textbox shouldn't
             * exist in the CreateTeams Form?
             * Henry Flores: 15Feb21
             * 
             * Added for loop to auto generate team number based on whether or not it exists. Will use first
             * available team
             * Henry Flores: 21Feb21 */

            for (int x = 0; x < 10; x++)
            {
                if (teamArray[x] == null)
                {
                    TeamNum_textBox.Text = (x + 1).ToString();
                    break;
                }
            }
            foreach (Control control in this.Controls)
            {
                if (Regex.Match(control.Name, "^P[0-9]_Fname.*").Success)
                {
                    control.Text = RandGenTeam.GetFirstName();
                }
            }
            foreach (Control control in this.Controls)
            {
                if (Regex.Match(control.Name, "^P[0-9]_Lname.*").Success)
                {
                    control.Text = RandGenTeam.GetLastName();
                }
            }
            foreach (Control control in this.Controls)
            {
                if (Regex.Match(control.Name, "^P[0-9]_hCap.*").Success)
                {
                    control.Text = RandGenTeam.GetHandicap();
                }
            }
            foreach (Control control in this.Controls)
            {
                if (Regex.Match(control.Name, "^P[0-9]_lastGame.*").Success)
                {
                    control.Text = RandGenTeam.GetScore();
                }
            }
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            /*Use data from textboxes to assign player info to a team. Use Team.Equals to determine if duplicate
             * Offer error message if Team# > 10
             * Henry Flores: 12Feb21
             * 
             * Added logic to assign the values in the textboxes to the player array for the associated team. A
             * temp player class is instantiated in the loop to hold all of the data for the four players
             * sequencially. Once all the data is stored, then the player is updated to the form local team array.
             * Once all 4 players are stored the the form local team array, it is copied back to the main team
             * array in the program.cs file.
             * If there is no team number or it is outside 1-10, then a message box will show indicating an error
             * Henry Flores: 23Feb21 */
            if (TeamNum_textBox.Text == "")
            {
                MessageBox.Show("Please enter a team number");
            }
            else if (int.Parse(TeamNum_textBox.Text) < 1 || int.Parse(TeamNum_textBox.Text) > 10)
            {
                MessageBox.Show("Please enter a valid team number between 1 and 10");
            }
            else
            {
                int teamNum = int.Parse(TeamNum_textBox.Text) - 1;
                if (teamArray[teamNum] == null)
                {
                    teamArray[teamNum] = new Team();
                }
                for (int x = 1; x < 5; x++)
                {
                    Player temp = new Player();
                    //MessageBox.Show("x = " + x);

                    string firstName = "P" + x + "_Fname_textBox";
                    string lastName = "P" + x + "_Lname_textBox";
                    string handicap = "P" + x + "_hCap_textBox";
                    string lastGame = "P" + x + "_lastGame_textBox";
                    foreach (Control control in this.Controls)
                    {
                        if (control.Name == firstName)
                        {
                            temp.FirstName = control.Text;
                        }
                        if (control.Name == lastName)
                        {
                            temp.LastName = control.Text;
                        }
                        if (control.Name == handicap)
                        {
                            temp.Handicap = int.Parse(control.Text);
                        }
                        if (control.Name == lastGame)
                        {
                            temp.LastGameScore = int.Parse(control.Text);
                        }
                    }
                    //MessageBox.Show("pulled data from text box");
                    teamArray[teamNum].updatePlayer(temp, x - 1);
                    //MessageBox.Show("test");
                }
                Program.TeamArray = teamArray;
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            /*Clear all of the text boxes
             * Henry Flores: 12Feb21
             * 
             * Added the logic to clear all of the textbox fields
             * Henry Flores: 15Feb21 */
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = null;
                }
            }
            MessageBox.Show("Form Cleared", "Success!");
        }

        private void Main_btn_Click(object sender, EventArgs e)
        {
            /*Return to main menu (Title Form)
             * Henry Flores: 12Feb21 */
            this.Close();
        }

        private void Debug_btn_Click(object sender, EventArgs e)
        {
            TeamNum_textBox.Text = 1.ToString();
            for (int x = 1; x < 5; x++)
            {
                Player temp = teamArray[0].getPlayer(x - 1);

                string firstName = "P" + x + "_Fname_textBox";
                string lastName = "P" + x + "_Lname_textBox";
                string handicap = "P" + x + "_hCap_textBox";
                string lastGame = "P" + x + "_lastGame_textBox";
                foreach (Control control in this.Controls)
                {
                    if (control.Name == firstName)
                    {
                        control.Text = temp.FirstName;
                    }
                    if (control.Name == lastName)
                    {
                        control.Text = temp.LastName;
                    }
                    if (control.Name == handicap)
                    {
                        control.Text = temp.Handicap.ToString();
                    }
                    if (control.Name == lastGame)
                    {
                        control.Text = temp.LastGameScore.ToString();
                    }
                }
            }
        }
    }
}
