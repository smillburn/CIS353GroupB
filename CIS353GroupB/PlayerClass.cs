// Garrett Waterman
// 1.18.2021
// Class to represent a a golf player with first name last name handicap score for last game and rank on team

using System;

namespace CIS353GroupB
{
    // A Player class containing first name, last name, handicap, score for last game and rank on team.
    public class Player : IComparable<Player>
    {
        // Variables
        string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        int handicap;
        public int Handicap
        {
            get { return handicap; }
            set { handicap = value; }
        }

        int lastGameScore;
        public int LastGameScore
        {
            get { return lastGameScore; }
            set { lastGameScore = value; }
        }

        int teamRank;
        public int TeamRank
        {
            get { return teamRank; }
            set { teamRank = value; }
        }

        // Constructors
        public Player() : this("John", "Doe", 0, 72, 0) { }

        public Player(string csv)
        {
            string[] parts = csv.Split(',');
            firstName = parts[0];
            lastName = parts[1];
            handicap = int.Parse(parts[2]);
            lastGameScore = int.Parse(parts[3]);
            teamRank = int.Parse(parts[4]);
        }

        public Player(string fname, string lname, int handi, int lgame, int rank)
        {
            firstName = fname;
            lastName = lname;
            handicap = handi;
            lastGameScore = lgame;
            teamRank = rank;
            // Potentially set rank based on other players handicaps
        }

        // Methods
        // Used to display player information
        public string[] toStringArray()
        {
            return new string[5] { firstName, lastName, handicap.ToString(), lastGameScore.ToString(), teamRank.ToString() };
        }

        public string toDisplayString()
        {
            return "Rank: " + this.teamRank + " Name: " + this.firstName + " " + this.lastName + 
                " Handicap: " + this.handicap + " Prev Game: " + this.lastGameScore;
        }

        public override string ToString()
        {
            return this.firstName + "," + this.lastName + "," + this.handicap + "," + this.lastGameScore + "," + this.teamRank;
        }

        public int CompareTo(Player other) //sets the compareto interface to compare players handicaps for sorting
        {
            return this.Handicap.CompareTo(other.Handicap);
        }

        public override bool Equals(object obj) // override Equals to compare two players on handicap
        {
            if (this.Handicap == Convert.ToInt32(obj)) { return true; }
            else { return false; }
        }

        public override int GetHashCode() // required to get Equals override to work
        {
            return this.Handicap.GetHashCode();
        }
    }
}