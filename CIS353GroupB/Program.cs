/* Name: Jacob Darling, Henry Flores, Skyler Millburn, Garret Waterman
 * Assignment: Group Project
 * Date: 3 MAR 2021
 * Description: Program holds a list of 10 teams participating in a tournament. 
 *              User can add/remove teams, import/export teams, and display all teams
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS353GroupB
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GolfLeague_Form());
        }
    }
}
