using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pictureBox1.Image = Image.FromFile("D:\\Study\\sem-4\\Dot new git\\dotnet-c--main\\UNIT01\\FLAG\\program9\\india.png");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                pictureBox1.Image = Image.FromFile("D:\\Study\\sem-4\\Dot new git\\dotnet-c--main\\UNIT01\\FLAG\\program9\\america.png");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                pictureBox1.Image = Image.FromFile("D:\\Study\\sem-4\\Dot new git\\dotnet-c--main\\UNIT01\\FLAG\\program9\\canada.png");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                pictureBox1.Image = Image.FromFile("D:\\Study\\sem-4\\Dot new git\\dotnet-c--main\\UNIT01\\FLAG\\program9\\shrilanka.jpg");
            }
        }
    }
}
