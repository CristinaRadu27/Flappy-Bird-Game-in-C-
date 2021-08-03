using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form
{
    public partial class Form1 : Form
    {

        int vitezaConducta = 8;
        int gravitate = 10;
        int score = 0;
        


        public Form1 ()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravitate;
            conductaInferioara.Left -= vitezaConducta; 
            conductaSuperioara.Left -= vitezaConducta;
            scoreText.Text = "Score: " + score;

            if (conductaInferioara.Left < -20)
            {
                conductaInferioara.Left = 775 ;
                score++;

            }
            if(conductaSuperioara.Left <-40)
            {
                conductaSuperioara.Left = 825;
                score++;
            }

            if(flappyBird.Bounds.IntersectsWith(conductaInferioara.Bounds) ||
               flappyBird.Bounds.IntersectsWith(conductaSuperioara.Bounds)||
               flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

            if(score > 10)
            {
                vitezaConducta = 10;

            }
             if(score > 15 )
            {
                vitezaConducta = 12;
            }
             
             if(score > 20)
            {
                vitezaConducta = 14;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravitate = -10;

            }

        }


        private void gamekeysiup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravitate = 10;

            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game over !!!"; 
            
        }

        private void scoreText_Click(object sender, EventArgs e)
        {

        }
    }
}
 