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
        public CreateTeams_Form()
        {
            InitializeComponent();
        }

        private void RandGen_btn_Click(object sender, EventArgs e)
        {
            /*Fill form with random data. Need to make a random class with arrays of first names,
             * last names, handicaps, last score, and team score and randomly select one for entry. 
             * Maybe use IComparable to sort players by score and use array values to display their rank.
             * Henry Flores: 12Feb21
             * 
             * 
             * Created class with list of names and numbers to autofill the textboxes,
             * I used a regex to match textbox name for the correct field and used the methods in new class
             * to auto fill the appropiate textbox. Still would like to see some kind of way to calculate
             * the score based on the random handicap and score that was generated. Maybe this textbox shouldn't
             * exist in the CreateTeams Form?
             * Henry Flroes: 15Feb21 */

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
             * Henry Flores: 12Feb21 */
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
                    control.Text = null;
            }
        }

        private void Main_btn_Click(object sender, EventArgs e)
        {
            /*Return to main menu (Title Form)
             * Henry Flores: 12Feb21 */
            this.Close();
        }
    }
}
