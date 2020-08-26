/* Filename:            Scoreboard.cs
 * Author:              Mikhail Goulding
 * Created:             02 February 2020
 * Operating System:    Windows 10
 * Version:             1.0
 * Description          This file holds the Scoreboard form. The Scoreboard displays your total wins, losses, ties and total games played.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Scoreboard : Form // This class is a form containing the scoreboard.
    {
        public Scoreboard()
        {
            InitializeComponent();
        }
        public void Win(int x) 
        {
            winScoreLbl.Text = x.ToString();
        }
        public void Lose(int x)
        {
            loseScoreLbl.Text = x.ToString();
        }
        public void Tie(int x)
        {
            TieScoreLbl.Text = x.ToString();
        }
        public void Played(int x)
        {
            PlayedScoreLbl.Text = x.ToString(); ;
        }
    }
}
