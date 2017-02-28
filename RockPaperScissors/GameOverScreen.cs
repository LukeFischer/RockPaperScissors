using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
            finalLabel.Font = new Font("Ariel", 14, FontStyle.Bold);
            finalLabel.Text = "You won" + " " + (Form1.pattern.Count()) + " " + "round!"; 
        }
    }
}
