﻿/* Name: Jacob Darling, Henry Flores, Skyler Millburn, Garret Waterman
 * Assignment: Group Project
 * Date: 18 JAN 2021
 * Description: Class to represent a a golf player with first name last name handicap score for last game and rank on team
 */

using System;

namespace CIS353GroupB
{
    // A Player class containing first name, last name, handicap, score for last game and rank on team.
    public class Player : IComparable<Player>
    {
        // Variables
        string firstName;
        // First name Accessor
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        string lastName;
        // Last name Accessor
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        int handicap;
        // Handicap Accessor
        public int Handicap
        {
            get { return handicap; }
            set { handicap = value; }
        }

        int lastGameScore;
        // last game score Accessor
        public int LastGameScore
        {
            get { return lastGameScore; }
            set { lastGameScore = value; }
        }

        int teamRank;
        // Team rank Accessor
        public int TeamRank
        {
            get { return teamRank; }
            set { teamRank = value; }
        }

        // default Constructor
        public Player() : this("John", "Doe", 0, 72, 0) { }
        // csv player constructor
        public Player(string csv)
        {
            string[] parts = csv.Split(',');
            firstName = parts[0];
            lastName = parts[1];
            handicap = int.Parse(parts[2]);
            lastGameScore = int.Parse(parts[3]);
            teamRank = int.Parse(parts[4]);
        }
        // Constructor with specific values
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
        // converts player to a display string used in the treeview
        public string toDisplayString()
        {
            return "Rank: " + this.teamRank + " Name: " + this.firstName + " " + this.lastName + 
                " Handicap: " + this.handicap + " Prev Game: " + this.lastGameScore;
        }
        // Override toString to convert player object to csv format
        public override string ToString()
        {
            return this.firstName + "," + this.lastName + "," + this.handicap + "," + this.lastGameScore + "," + this.teamRank;
        }
        //sets the compareto interface to compare players handicaps for sorting
        public int CompareTo(Player other) 
        {
            return (this.LastGameScore - this.Handicap).CompareTo(other.LastGameScore - other.Handicap);
            //return this.Handicap.CompareTo(other.Handicap);
        }
        // override Equals to compare two players on handicap
        public override bool Equals(object obj) 
        {
            if (this.Handicap == Convert.ToInt32(obj)) { return true; }
            else { return false; }
        }
        // required to get Equals override to work
        public override int GetHashCode() 
        {
            return this.Handicap.GetHashCode();
        }
    }
}