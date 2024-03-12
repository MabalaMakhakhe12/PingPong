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
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).PongBall.Image = Image.FromFile(@"C:\Users\hp\Documents\PongGamePart1-main\PongGamePart1-main\MOG.png");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).PongBall.Image = Image.FromFile(@"C:\Users\hp\Documents\PongGamePart1-main\PongGamePart1-main\No.png");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }

        private void characterOne_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).PongBall.Image = Image.FromFile(@"C:\Users\hp\Documents\PongGamePart1-main\PongGamePart1-main\ForeverAlone.png");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).PongBall.Image = Image.FromFile(@"C:\Users\hp\Documents\PongGamePart1-main\PongGamePart1-main\TrollFace.png");
            (this.Owner as Pong).pongTimer.Start();
            this.Hide();
        }
    }
}
