using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS353GroupB
{
    static class Program
    {
        /* This creates the "main" team array that will hold the data. Local form team arrays
         * will copy the data over to the form for use, and return a copy if any changes are
         * are made using the public accessor
         * Henry Flores: 23Feb21 */
        static Team[] teamArray = new Team[10];
        public static Team[] TeamArray
        {
            get { return teamArray; }
            set { teamArray = value; }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*for (int x = 0; x < teamArray.Length; x++)
            {
                teamArray[x] = new Team();
            }*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GolfLeague_Form());
        }
    }
}
