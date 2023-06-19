using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; 

namespace breakout
{
    public partial class Form1 : Form
    {
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blackBrush = new SolidBrush(Color.Black); 
        Rectangle player = new Rectangle(500, 300, 100, 10);
        Rectangle ball = new Rectangle(400, 30, 10, 10);
        int playerspeed = 7;
        int ballXSpeed = 6; 
        int ballYSpeed = 6;
        bool end;
        SoundPlayer Break = new SoundPlayer(Properties.Resources.Break); 
        SoundPlayer Bounce = new SoundPlayer(Properties.Resources.Bounce);
        Rectangle[] blockArray = new Rectangle[] 
      { 
      new Rectangle(20, 100, 20, 20),
      new Rectangle(150, 100, 20, 20),
      new Rectangle(20, 200, 20, 20),
      new Rectangle(150, 200, 20, 20),
      new Rectangle(80, 145, 20, 20),
      new Rectangle(300, 100, 20, 20),
      new Rectangle(430, 100, 20, 20),
      new Rectangle(300, 200, 20, 20),
      new Rectangle(430, 200, 20, 20 ),
      new Rectangle(360, 146, 20, 20), 
      };

        

        //keys
        bool leftArrowDown = false;
        bool rightArrowDown = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void DOnt_Click(object sender, EventArgs e)
        {
            //just to close the tab
            Application.Exit();
        }

        private void Do_Click(object sender, EventArgs e)
        {

            Gaming.Start();
            this.Focus();
            Nameofgame.Visible = false;
            Do.Visible = false;
            Do.Enabled = false;
            DOnt.Enabled = false;
            DOnt.Visible = false;

            Do.Dispose();
            DOnt.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void Gaming_Tick(object sender, EventArgs e)
        {
            //ball move
            ball.X += ballXSpeed;
            ball.Y += ballYSpeed;
            //movement
            if (leftArrowDown == true && player.X > 0)
            {
                player.X -= playerspeed;
            }

            if (rightArrowDown == true && player.X < this.Width - player.Width)
            {
                player.X += playerspeed;
            }

            //collisions
            if (ball.Y >= this.Height - ball.Height)
            {
               
            }
             else if (ball.Y < 0 )
            {
            
                ballYSpeed *= -1; 
            }

            if (ball.X < 0 || ball.X >= this.Width - ball.Width)
            {
                ballXSpeed *= -1; 
            }
            //Ball bounce 
            if (ball.IntersectsWith(player))
            {
                ballYSpeed *= -1;

                ball.Y = player.Y - ball.Height;

                Bounce.Play(); 
                //ball.Y = player.Y + ball.Width;
            }

            //Block deletion 
            for (int i = 0; i < blockArray.Length; i++)
            {
                if (ball.IntersectsWith(blockArray[i])) 
                {

                    Rectangle top = new Rectangle(blockArray[i].X, blockArray[i].Y, blockArray[i].Width, 1);
                    Rectangle right = new Rectangle(blockArray[i].X + blockArray[i].Width, blockArray[i].Y, 1, blockArray[i].Height);
                    Rectangle bottom = new Rectangle(blockArray[i].X, blockArray[i].Y + blockArray[i].Height, blockArray[i].Width, 1);
                    Rectangle left = new Rectangle(blockArray[i].X, blockArray[i].Y, 1, blockArray[i].Height);

                    if (ball.IntersectsWith(top) || ball.IntersectsWith(bottom))
                    {
                        ballYSpeed *= -1;
                        Break.Play();
                    }
                    else if (ball.IntersectsWith(left) || ball.IntersectsWith(right))
                    {
                        ballXSpeed *= -1;
                        Break.Play(); 
                    }
                    

                    blockArray[i].X = -200;
                    blockArray[i].Y = -200;
                    
                    end = true;
                  
                    for (int p = 0; p < blockArray.Length; p++)
                    {
                        if (blockArray[p].X != -200)
                        {
                             end = false;
                            break;
                        }
                    
                    }
                   
                }
       
                   
                
            }
           

                Refresh();

        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            if (Gaming.Enabled == true)
            {
                e.Graphics.FillRectangle(whiteBrush, player);
                e.Graphics.FillRectangle(whiteBrush, ball);

                for (int i = 0; i < blockArray.Length; i++)
                {
                    e.Graphics.FillRectangle(whiteBrush, blockArray[i]);
                }

                if (end == true)
                {
                    Gaming.Enabled = false;
                    e.Graphics.FillRectangle(blackBrush, player);
                    e.Graphics.FillRectangle (blackBrush, ball);
                    ah.Text = "YOU WIN";
                }

               
            }
            if (ball.Y >= this.Height - ball.Height)
            {
                e.Graphics.FillRectangle(blackBrush, ball);
               e.Graphics.FillRectangle(blackBrush, player);
                for (int i = 0; i < blockArray.Length; i++)
                {
                    e.Graphics.FillRectangle(blackBrush, blockArray[i]);
                }
                ah.Text = "YOU LOST"; 
                Gaming.Stop(); 
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
            }
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
            }
        }
    }
}
