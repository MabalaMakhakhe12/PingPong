using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Pong : Form
    {
        //location Variables
        int cpuDirection = 5;
        int ballXCoordinate = 5;
        int ballYCoordinate = 5;
        //Score Variables
        int playerScore = 0;
        int cpuScore = 0;
        //Size Variables
        int bottomBoundary;
        int centrePoint;
        int xMidpoint;
        int yMidpoint;
        // Detection Variables
        bool playerDetectedUp;
        bool playerDetectedDown;
        // Special Keys
        int spaceBarClicked = 0;
        public Pong()
        {
            InitializeComponent();
            bottomBoundary= ClientSize.Height - player1.Height;
            xMidpoint = ClientSize.Width / 2;
            yMidpoint = ClientSize.Height / 2;
        }

        private void Pong_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Code inside PongTimer method to fire every 20 milliseconds which allows the ball to move
        /// detects which side the ball hit and also checks scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pongTimer_Tick(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);
            // Adjusts where the ball is
            PongBall.Top -= ballYCoordinate;
            PongBall.Left -= ballXCoordinate;
            // Makes the CPU move
            cpuPlayer.Top += cpuDirection;
            // Check if cpu has reached the top or bottom
            if (cpuPlayer.Top <= 0 || cpuPlayer.Top >= bottomBoundary)
            {
                cpuDirection = -cpuDirection;
            }
            // Check if the ball has exited the left side of the screen
            if(PongBall.Left <= 0)
            {
                PongBall.Left = xMidpoint;
                PongBall.Top = yMidpoint;
                ballXCoordinate = -ballXCoordinate;
                cpuScore++;
                cpuScoreLabel.Text = Convert.ToString(cpuScore);
            }

            // Check if the ball has exited the right side of the screen
            if(PongBall.Left + PongBall.Width > ClientSize.Width)
            {
                PongBall.Left = xMidpoint;
                PongBall.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;
                playerScore++;
                playerScoreLabel.Text = Convert.ToString(playerScore);
            }

            //Ensure the ball is within the boundaries of the screen
            if(PongBall.Top <= 0 || PongBall.Top + PongBall.Height >= ClientSize.Height)
            {
                ballYCoordinate = -ballYCoordinate;
            }
            if(PongBall.Bounds.IntersectsWith(player1.Bounds) || PongBall.Bounds.IntersectsWith(cpuPlayer.Bounds))
            {
                // Sends the ball in the opposite direction
                ballXCoordinate = -ballXCoordinate;
            }

            // Move player up
            if (playerDetectedUp == true && player1.Top > 0)
            {
                player1.Top -= 10;
            }
            if (playerDetectedDown == true && player1.Top < bottomBoundary)
            {
                player1.Top += 10;
            }
            if (playerScore >= 10)
            {
                pongTimer.Stop();
                MessageBox.Show("You Win!");
            }
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                playerDetectedUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                playerDetectedDown = false;
            }
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            //if player presses the up arrow key move the paddle upwards.
            if (e.KeyCode == Keys.Up)
            {
                playerDetectedUp = true;
            }
            //if player presses the down arrow key move the paddle downwards.
            if (e.KeyCode == Keys.Down)
            {
                playerDetectedDown = true;
            }
            // if player presses the c kay, open the character selection screen
            if(e.KeyCode == Keys.C)
            {
                Form character = new CharacterForm();
                character.Owner = this;
                pongTimer.Stop();
                character.Show();
            }
            //if player presses the space bar pause the game
            if (e.KeyCode == Keys.Space)
            {
                if (spaceBarClicked % 2 == 0)
                {
                    pongTimer.Stop();
                }
                else
                {
                    pongTimer.Start();
                }
            }
            spaceBarClicked++;

        }
    }
}
