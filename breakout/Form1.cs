using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace breakout
{
    public partial class Form1 : Form
    {
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        Rectangle player = new Rectangle(500, 300, 100, 10);
        Rectangle Ball = new Rectangle(480, 30, 10, 10);
        int playerspeed = 4;
        int ballspeed = 6; 


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
            //movement
            if (leftArrowDown == true && player.X > 0)
            {
                player.X -= playerspeed;
            }

            if (rightArrowDown == true && player.X < this.Width - player.Width)
            {
                player.X += playerspeed;
            }

            Refresh();

        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            if (Gaming.Enabled == true)
            {
                e.Graphics.FillRectangle(whiteBrush, player);
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
