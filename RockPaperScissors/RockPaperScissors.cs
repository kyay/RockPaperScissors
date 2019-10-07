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
        private Player playerUser = new Player(Winner.User), playerComputer = new Player(Winner.Computer);
        private Random rGen = new Random();

        private Button[] buttons;


        public RockPaperScissors()
        {
            InitializeComponent();
            buttons = new Button[] { btnRock, btnPaper, btnScissors };
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            //Play click sound
            System.Media.SystemSounds.Exclamation.Play();
            //Get the user and computer choices and set them into their respective players
            Winner winner = Winner.None;
            playerUser.Choice = (Choice)Convert.ToInt32(((Button)sender).Tag);
            playerComputer.Choice = (Choice)rGen.Next(1, 4);

            //Decide who the winner is
            if (playerUser.Choice == playerComputer.Choice)
                winner = Winner.Draw;
            else if (playerUser.Choice.CanBeat(playerComputer.Choice))
                winner = Winner.User;
            else
                winner = Winner.Computer;

            //Increment counters and display winner and stats
            playerUser.OnWinnerAnnounced(winner);
            playerComputer.OnWinnerAnnounced(winner);
            DisplayStats();
            DisplayWinner(winner);
        }

        private void DisplayWinner(Winner winner)
        {
            //Display the winner, then reset for a new game
            MessageBox.Show(winner.GetDescription(), "Winner");
            playerUser.Choice = Choice.None;
            playerComputer.Choice = Choice.None;
        }

        private void RockPaperScissors_Load(object sender, EventArgs e)
        {
            //Play starting sound
            System.Media.SystemSounds.Asterisk.Play();
        }

        private void RockPaperScissors_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Play closing sound
            System.Media.SystemSounds.Hand.Play();
        }

        private void DisplayStats()
        {
            //Display the stats using an overridden ToString() method
            lblUserStats.Text = "User Stats: \n" + playerUser.ToString();
            lblComputerStats.Text = "Computer Stats: \n" + playerComputer.ToString();
        }

        private Choice GetUserDecisionFromButton(Button clickedButton)
        {
            int intUserChoice = -1;

            for(int i = 0; i < buttons.Length; i++)
            {
                if(buttons[i] == clickedButton)
                {
                    intUserChoice = i;
                }
            }
            return (Choice)(intUserChoice + 1);
        }

        private Choice ConvertIntegerToChoice(int intChoice)
        {
            System.Collections.IEnumerator enumerator = Enum.GetValues(typeof(Choice)).GetEnumerator();
            System.Collections.IEnumerator enumerator = Enum.GetValues(typeof(Choice)).GetEnumerator();

            while (enumerator.MoveNext())
            {
                if(intChoice + 1 == enumerator.Current)
                {
                    return Enum.
                }
            }
        }
    }
}
