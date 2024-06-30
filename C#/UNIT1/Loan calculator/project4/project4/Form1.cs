using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            pmt();
        }
        private void pmt()
        {
            double a, b, c, d;
            double e;
            a = Int32.Parse(textBox1.Text);
            b = Int32.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);
            d = (a * b) / c;
            if (checkBox1.Checked)
            {
                e = (a*10) / 100;
                d = d - e;
            }
            textBox4.Text = d.ToString()+"/-";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
