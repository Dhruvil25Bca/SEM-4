using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean clr;
        string op;
        float oprand;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {
            if(op!="")
            {
                equal_Click(sender, e);
                op = "";
            }
            op = ((Button)sender).Text;
            oprand = Convert.ToSingle(textBox1.Text);
            clr = true;
        }

        private void oprand_click(object sender, EventArgs e)
        {
            if(((Button)sender).Text=="."&&textBox1.Text.IndexOf(".")>=0)
            {
                return;
            }
            if(clr==true)
            {
                textBox1.Clear();
                clr= false;
            }
            textBox1.Text = textBox1.Text + ((Button)sender).Text;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if(op=="+")
            {
                textBox1.Text=Convert.ToString(oprand+Convert.ToSingle(textBox1.Text));
            }
            if(op=="-")
            {
                textBox1.Text=Convert.ToString(oprand-Convert.ToSingle(textBox1.Text));
            }
            if(op=="*")
            {
                textBox1.Text = Convert.ToString(oprand * Convert.ToSingle(textBox1.Text));
            }
            if (op=="/")
            {
                textBox1.Text = Convert.ToString(oprand / Convert.ToSingle(textBox1.Text));
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Single num = Convert.ToSingle(textBox1.Text);
            textBox1.Text = Convert.ToString(num * num);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int ans, num, i;
            num=int.Parse(textBox1.Text);
            ans = 1;
            for(i=1;i<=num;i++)
            {
                ans = ans * i;
            }
            textBox1.Text=ans.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text=Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            clr = false;
            textBox1.Clear();
            op = "";
            oprand = 0;
        }
    }
}
