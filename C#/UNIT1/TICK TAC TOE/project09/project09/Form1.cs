using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project09
{
    public partial class Form1 : Form
        {
        Boolean player;
        public Form1()
            {
            InitializeComponent();
            }

        private void Form1_Load(object sender, EventArgs e)
            {

            }
        private void button1_Click(object sender, EventArgs e)
         {
            if (((Button)sender).Text != "X" && ((Button)sender).Text != "O")
            {
                if (player == false)
                    {
                    ((Button)sender).Text = "X";
                    }
                else
                    {
                    ((Button)sender).Text = "O";
                    }
                checkwinner();
                player = !player;
             }
          }
        
        private void checkwinner()
        {
            string smb;
            string msgplayer;
            if (player == false)
            {
                smb = "X";
                msgplayer = "player1";
                if (button1.Text == smb && button2.Text == smb && button3.Text == smb)
                {
                    MessageBox.Show(msgplayer + " win!!!");
                    cleargame();
                }
                else if (button4.Text == smb && button5.Text == smb && button6.Text == smb)
                {
                    MessageBox.Show(msgplayer + " win!!!");
                    cleargame();
                }
                else if (button7.Text == smb && button8.Text == smb && button9.Text == smb)
                {
                    MessageBox.Show(msgplayer + " win!!!");
                    cleargame();
                }
                else if (button1.Text == smb && button4.Text == smb && button7.Text == smb)
                {
                    MessageBox.Show(msgplayer + " win!!!");
                    cleargame();
                }
                else if (button2.Text == smb && button5.Text == smb && button8.Text == smb)
                {
                    MessageBox.Show(msgplayer + " win!!!");
                    cleargame();
                }
                else if (button3.Text == smb && button6.Text == smb && button9.Text == smb)
                {
                    MessageBox.Show(msgplayer + " win!!!");
                    cleargame();
                }
                else if (button1.Text == smb && button5.Text == smb && button9.Text == smb)
                {
                    MessageBox.Show(msgplayer + " win!!!");
                    cleargame();
                }
                else if (button3.Text == smb && button5.Text == smb && button7.Text == smb)
                {
                    MessageBox.Show(msgplayer + " win!!!");
                    cleargame();
                }
                else
                {
                }
            }
            else
            {
                smb = "O";
                msgplayer = "player2";
				if(button1.Text==smb && button2.Text==smb && button3.Text==smb)
                {
                    MessageBox.Show(msgplayer+" win!!!");
                    cleargame();
                }
                else if (button4.Text == smb && button5.Text == smb && button6.Text == smb)
                {
                    MessageBox.Show(msgplayer + " win!!!");
                    cleargame();
                }
                else if (button7.Text == smb && button8.Text == smb && button9.Text == smb)
                {
                    MessageBox.Show(msgplayer + " win!!!");
                    cleargame();
                }
                else if (button1.Text == smb && button4.Text == smb && button7.Text == smb)
                {
                    MessageBox.Show(msgplayer + " win!!!");
                    cleargame();
                }
                else if (button2.Text == smb && button5.Text == smb && button8.Text == smb)
                {
                    MessageBox.Show(msgplayer + " win!!!");
                    cleargame();
                }
                else if (button3.Text == smb && button6.Text == smb && button9.Text == smb)
                {
                    MessageBox.Show(msgplayer + " win!!!");
                    cleargame();
                }
                else if (button1.Text == smb && button5.Text == smb && button9.Text == smb)
                {
                    MessageBox.Show(msgplayer + " win!!!");
                    cleargame();
                }
                else if (button3.Text == smb && button5.Text == smb && button7.Text == smb)
                {
                    MessageBox.Show(msgplayer + " win!!!");
                    cleargame();
                }
                else
                { 
                }
            }
        }
        private void cleargame()
        {
            foreach (var control in this.Controls)
            { 
                if(control.GetType()==typeof(Button))
    			{
					((Button)control).Text="";
				}
				player=false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text != "X" && ((Button)sender).Text != "O")
            {
                if (player == false)
                {
                    ((Button)sender).Text = "X";
                }
                else
                {
                    ((Button)sender).Text = "O";
                }
                checkwinner();
                player = !player;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text != "X" && ((Button)sender).Text != "O")
            {
                if (player == false)
                {
                    ((Button)sender).Text = "X";
                }
                else
                {
                    ((Button)sender).Text = "O";
                }
                checkwinner();
                player = !player;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text != "X" && ((Button)sender).Text != "O")
            {
                if (player == false)
                {
                    ((Button)sender).Text = "X";
                }
                else
                {
                    ((Button)sender).Text = "O";
                }
                checkwinner();
                player = !player;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text != "X" && ((Button)sender).Text != "O")
            {
                if (player == false)
                {
                    ((Button)sender).Text = "X";
                }
                else
                {
                    ((Button)sender).Text = "O";
                }
                checkwinner();
                player = !player;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text != "X" && ((Button)sender).Text != "O")
            {
                if (player == false)
                {
                    ((Button)sender).Text = "X";
                }
                else
                {
                    ((Button)sender).Text = "O";
                }
                checkwinner();
                player = !player;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text != "X" && ((Button)sender).Text != "O")
            {
                if (player == false)
                {
                    ((Button)sender).Text = "X";
                }
                else
                {
                    ((Button)sender).Text = "O";
                }
                checkwinner();
                player = !player;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text != "X" && ((Button)sender).Text != "O")
            {
                if (player == false)
                {
                    ((Button)sender).Text = "X";
                }
                else
                {
                    ((Button)sender).Text = "O";
                }
                checkwinner();
                player = !player;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text != "X" && ((Button)sender).Text != "O")
            {
                if (player == false)
                {
                    ((Button)sender).Text = "X";
                }
                else
                {
                    ((Button)sender).Text = "O";
                }
                checkwinner();
                player = !player;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
