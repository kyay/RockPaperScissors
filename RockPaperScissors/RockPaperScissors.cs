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

        public RockPaperScissors()
        {
            InitializeComponent();
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            playerUser.Choice = (Choice)Convert.ToInt32(((Button)sender).Tag);
        }
    }
}
