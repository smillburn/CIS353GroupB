using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
             * Henry Flores: 12Feb21 */
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
             * Henry Flores: 12Feb21 */
        }

        private void Main_btn_Click(object sender, EventArgs e)
        {
            /*Return to main menu (Title Form)
             * Henry Flores: 12Feb21 */
        }
    }
}
