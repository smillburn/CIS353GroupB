using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS353GroupB
{
    public partial class Title_Form : Form
    {
        //private static List<Team> teams = new List<Team>();
        //Commented above line: Henry Flores: 12Feb21

        private void Title_Form_Load(object sender, EventArgs e)
        {
            
        }

        public Title_Form()
        {
            InitializeComponent();
        }

        private void StartNew_button_Click(object sender, EventArgs e)
        {
            /*Need determine how to persist data across multiple forms
             * seperate static class and close title form? use title form?
             * Henry Flores: 12Feb21 */
            //this.Close(); //close Title form and open CreateTeams form
            CreateTeams_Form createTeams = new CreateTeams_Form();
            createTeams.ShowDialog();
            
        }

        private void Import_btn_Click(object sender, EventArgs e)
        {
            /*Change form to offer browse button? Import team data from a CSV file?
             * Henry Flores: 12Feb21 */
        }

        private void Display_btn_Click(object sender, EventArgs e)
        {
            /*Change form to Display Form to display the current team data
             * Henry Flores: 12Feb21 */
        }

        private void Export_btn_Click(object sender, EventArgs e)
        {
            /*Change form to offer browse button? Export data to CSV file?
             * Henry Flores: 12Feb21
        }


        /* Commenting out previous code to save it
         * Henry Flores: 12Feb21
         * 
        private void Form1_Load(object sender, EventArgs e)
        {
            updateTeamList();
        }

        public void updateTeamList()
        {
            cboxTeams.Items.Clear();
            foreach (Team team in teams)
            {
                cboxTeams.Items.Add(team);
            }
            btnAdd.Visible = teams.Count < 10 ? true : false;
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            teams.Add(new Team { Name = "FUZZY", Rank = 2 });
            teams[0].updatePlayer(new Player { FirstName = "Fred", LastName = "Orange", Handicap = 5, LastGameScore = 73, TeamRank = 1 }, 0);

            updateTeamList();
        }
        
        private void DisplayTeam(object sender, EventArgs e)
        {
            string[] player = teams[cboxTeams.SelectedIndex].getPlayer(0).toStringArray();
            lstTeam.Items.Add(new ListViewItem(teams[cboxTeams.SelectedIndex].getPlayer(0).toStringArray()));
        }
        
        private void lstTeam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        */
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
