// Garrett Waterman
// 1.18.2021
// Class to represent a golf team with 4 players and a scoring rank

using System;

namespace CIS353GroupB
{
	public class Team
	{
		Player[] players = new Player[4];
		string name = "";
		int rank = 0;

		public string Name
        {
			get => name;
			set => name = value;
		}

		public int Rank
        {
			get => rank;
			set => rank = value;
        }

		public void updatePlayer(Player player, int index)
        {
			players[index] = player;
        }

        public Player getPlayer(int index)
        {
            return players[index];
        }

        //sets the compareto interface to compare teams rank for sorting
        public int CompareTo(Team other) 
        {
            return this.rank.CompareTo(other.rank);
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
    }
}