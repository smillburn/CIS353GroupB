/* Name: Jacob Darling, Henry Flores, Skyler Millburn, Garret Waterman
 * Assignment: Group Project
 * Date: 3 MAR 2021
 * Description: This class contains a series of random values to fill the team and player objects
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CIS353GroupB
{
    class RandGenTeam
    {
        // First Names values
        static string[] randFnames = {"Glennis", "Maynard", "Branda", "Rosalinda", "Sebrina", "Ronda",
            "Lurlene", "Rachelle", "Petronila", "Carmen", "Guadalupe", "Teisha",
            "Merlin", "Raeann", "Marvella", "Carol", "Benton", "Gita", "Blanche",
            "Claris", "Abdul", "Jamison", "Dominique", "Theo", "Mike", "Markus",
            "Clint", "Zachery", "Stacy", "Cyrus", "Charlie", "Kip", "Ismael",
            "Devin", "Hollis", "Earnest", "Gustavo", "Alton", "Delbert", "Tod" };
        // Last names values
        static string[] randLnames = {"Taubman", "Wedderburn", "Gash", "Nicol", "Seaton", "Barrientez",
            "Kaczmarek", "Beesley", "Biondo", "Yearout", "Stoll", "Mills", "Redel",
            "Gilson", "Gilroy", "Pricer", "Clemens", "Montalto", "Ratzlaff", "Sorrell",
            "Kuck", "Hamner", "Guion", "Vail", "Scharf", "Weckerly", "Maharaj", "Howell",
            "Ambler", "Figueras", "Kolstad", "Coon", "Chavera", "Mcgonigle", "Keese",
            "Sheard", "Lundberg", "Loughlin", "Hynson", "Fleckenstein"};
        // Handicap values
        static int[] handicap = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // Game Score values
        static int[] lastGameScore = {65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80,
            81, 82, 83, 84, 85, 86, 87, 88, 89, 90};
        // Team name values
        static string[] randTnames = { "Fuzzy Wuzzy", "Retro Ducks", "Gecko Stars", "Dream Busters",
            "Killer Executioners", "Carnivore Kickers", "Night Flyers", "Muffin Bombers", "Mighty Mavericks",
            "Smokin Lunatics", "Aero Bullets", "Militant Wasps", "Scorpion Sonics", "Crimson Wasps",
            "Wild Predators", "Demolition Mashers", "Zulu Falcons", "Reptile Fighters", "Skull Crunchers",
            "Silent Tanks", "Banzai Stars", "Spinning Gangstaz", "Flash Dragons", "Eccentric Sonics"};
        static Random rand = new Random();
        // Gets a random first name
        static public string GetFirstName()
        {
            return randFnames[rand.Next(0, randFnames.Length)];
        }
        // Gets a random last name
        static public string GetLastName()
        {
            return randLnames[rand.Next(0, randLnames.Length)];
        }
        // Gets a random handicap value
        static public string GetHandicap()
        {
            return handicap[rand.Next(0, handicap.Length)].ToString();
        }
        // Gets a random score
        static public string GetScore()
        {
            return lastGameScore[rand.Next(0, lastGameScore.Length)].ToString();
        }
        // Gets a random team name
        static public string GetTeamName()
        {
            return randTnames[rand.Next(0, lastGameScore.Length)].ToString();
        }
        // Gets a full random player with a default rank of 1
        static public Player getPlayer()
        {
            return new Player(GetFirstName(), GetLastName(), int.Parse(GetHandicap()), int.Parse(GetScore()), 1);
        }
    }
}
