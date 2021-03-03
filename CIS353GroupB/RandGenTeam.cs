using System;
using System.Collections.Generic;
using System.Text;

namespace CIS353GroupB
{
    class RandGenTeam
    {
        static string[] randFnames = {"Glennis", "Maynard", "Branda", "Rosalinda", "Sebrina", "Ronda",
            "Lurlene", "Rachelle", "Petronila", "Carmen", "Guadalupe", "Teisha",
            "Merlin", "Raeann", "Marvella", "Carol", "Benton", "Gita", "Blanche",
            "Claris", "Abdul", "Jamison", "Dominique", "Theo", "Mike", "Markus",
            "Clint", "Zachery", "Stacy", "Cyrus", "Charlie", "Kip", "Ismael",
            "Devin", "Hollis", "Earnest", "Gustavo", "Alton", "Delbert", "Tod" };
        static string[] randLnames = {"Taubman", "Wedderburn", "Gash", "Nicol", "Seaton", "Barrientez",
            "Kaczmarek", "Beesley", "Biondo", "Yearout", "Stoll", "Mills", "Redel",
            "Gilson", "Gilroy", "Pricer", "Clemens", "Montalto", "Ratzlaff", "Sorrell",
            "Kuck", "Hamner", "Guion", "Vail", "Scharf", "Weckerly", "Maharaj", "Howell",
            "Ambler", "Figueras", "Kolstad", "Coon", "Chavera", "Mcgonigle", "Keese",
            "Sheard", "Lundberg", "Loughlin", "Hynson", "Fleckenstein"};
        static int[] handicap = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static int[] lastGameScore = {65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80,
            81, 82, 83, 84, 85, 86, 87, 88, 89, 90};
        static Random rand = new Random();
        static public string GetFirstName()
        {
            return randFnames[rand.Next(0, randFnames.Length - 1)];
        }
        static public string GetLastName()
        {
            return randLnames[rand.Next(0, randLnames.Length - 1)];
        }
        static public string GetHandicap()
        {
            return handicap[rand.Next(0, handicap.Length - 1)].ToString();
        }
        static public string GetScore()
        {
            return lastGameScore[rand.Next(0, lastGameScore.Length - 1)].ToString();
        }
        static public Player getPlayer()
        {
            return new Player(GetFirstName(), GetLastName(), int.Parse(GetHandicap()), int.Parse(GetScore()), 1);
        }
    }
}
