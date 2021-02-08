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
    public partial class Form1 : Form
    {
        private static List<Team> teams = new List<Team>();

        public Form1()
        {
            InitializeComponent();
        }

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
    }
}
