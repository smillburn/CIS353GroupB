/* Name: Jacob Darling, Henry Flores, Skyler Millburn, Garret Waterman
 * Assignment: Group Project
 * Date: 18 JAN 2021
 * Description: Class to represent a golf team with 4 players and a scoring rank
 */
using System;

namespace CIS353GroupB
{
	public class Team
	{
		Player[] players = new Player[4];
		string name = "";
		int rank = 0;
        // Name Accessor
		public string Name
        {
			get => name;
			set => name = value;
		}
        // Rank Accessor
		public int Rank
        {
			get => rank;
			set => rank = value;
        }
        //Team Score to use in CompareTo
        public int TeamTotalScore
        {
            get; set;
        }
        // Default constructor
        public Team()
        {
            for (int x = 0; x < players.Length; x++)
                players[x] = new Player();
        }
        // Updates an individual players information based on player index
		public void updatePlayer(Player player, int index)
        {
			players[index] = player;
        }
        // Gets an individual player based on player index
        public Player getPlayer(int index)
        {
            return players[index];
        }
        public void Sort()
        {
            Array.Sort(players);
            for (int i = 0; i < 4; i++)
            {
                players[i].TeamRank = (i + 1);
            }
        }
        public void CalculateTeamScore()
        {
            int score = 0;
            for (int x = 0; x < 4; x++)
            {
                score += (players[x].LastGameScore - players[x].Handicap);
            }
            TeamTotalScore = score;
        }
        //sets the compareto interface to compare teams rank for sorting
        public int CompareTo(Team other) 
        {
            return this.TeamTotalScore.CompareTo(other.TeamTotalScore);
        }
        // override Equals to compare check if team already exists
        public override bool Equals(object obj) 
        {
            if (obj == null || !(obj is Team))
            {
                return false;
            }
            else
            {
                return name == ((Team)obj).name;
            }
        }
        // required to get Equals override to work
        public override int GetHashCode() 
        {
            return this.rank.GetHashCode();
        }
        // Override the ToString function for serialization
        public override string ToString()
        {
            return this.name + "," + this.rank + "\n" + players[0].ToString() + "\n" + players[1].ToString() + "\n" + players[2].ToString() + "\n" + players[3].ToString();
            ;
        }
    }
}