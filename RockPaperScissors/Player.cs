using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
	public class Player
	{
		private Winner winner;
		private Choice choice;
		private int winCount;
		private int lossCount;
		private int drawCount;

		public Winner Winner
		{
			get
			{
				return winner;
			}
		}

		public Choice Choice
		{
			get
			{
				return choice;
			}
			set
			{
				choice = value;
			}
		}

		public int WinCount
		{
			get
			{
				return winCount;
			}
		}

		public int LossCount
		{
			get
			{
				return lossCount;
			}
		}

		public int DrawCount
		{
			get
			{
				return drawCount;
			}
		}
		public Player()
		{
			winner = Winner.None;
		}

		public Player(Winner wnrWinner)
		{
			this.winner = wnrWinner;
		}

		public void OnWinnerAnnounced(Winner wnrNewWinner)
		{
			if (wnrNewWinner == Winner)
				winCount++;
			else if (wnrNewWinner == Winner.Draw)
				drawCount++;
			else if (wnrNewWinner == Winner.None)
			{
				//Do Nothing
			}
			else
				lossCount++;
		}

		public override string ToString()
		{
			return //"Player symbol: " + Winner.ToString() + "\n" +
				"Win count: " + WinCount + "\n" +
				"Loss count: " + LossCount + "\n" +
				"Draw count: " + DrawCount + "\n" +
				"Current Choice: " + choice;
		}
	}
}
