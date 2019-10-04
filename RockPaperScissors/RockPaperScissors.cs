using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
	public partial class RockPaperScissors : Form
	{
		Player playerUser = new Player(Winner.User), playerComputer = new Player(Winner.Computer);
		Random rGen = new Random();

		public RockPaperScissors()
		{
			InitializeComponent();
		}

		private void btnChoice_Click(object sender, EventArgs e)
		{
			Winner winner = Winner.None;
			playerUser.Choice = (Choice)Convert.ToInt32(((Button)sender).Tag);
			playerComputer.Choice = (Choice)rGen.Next(1, 4);

			if (playerUser.Choice == playerComputer.Choice)
				winner = Winner.Draw;
			else if (playerUser.Choice.CanBeat(playerComputer.Choice))
				winner = Winner.User;
			else
				winner = Winner.Computer;

			playerUser.OnWinnerAnnounced(winner);
			playerComputer.OnWinnerAnnounced(winner);
			DisplayStats();
			DisplayWinner(winner);
		}

		private void DisplayWinner(Winner winner)
		{
			MessageBox.Show(winner.GetDescription(), "Winner");
			playerUser.Choice = Choice.None;
			playerComputer.Choice = Choice.None;
		}

		private void DisplayStats()
		{
			lblUserStats.Text = "User Stats: \n" + playerUser.ToString();
			lblComputerStats.Text = "Computer Stats: \n" + playerComputer.ToString();
		}
	}
}
