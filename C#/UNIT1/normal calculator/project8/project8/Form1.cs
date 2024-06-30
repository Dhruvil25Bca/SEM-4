using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double a, b, ans;
            a = Int32.Parse(textBox1.Text);
            b = Int32.Parse(textBox2.Text);
            if (comboBox1.SelectedItem.ToString()=="ADD")
            {
                ans = a + b;
                label4.Text = ans.ToString();
            }
            else if (comboBox1.SelectedItem.ToString() == "SUB")
            {
                ans = a - b;
                label4.Text = ans.ToString();
            }
            else if (comboBox1.SelectedItem.ToString() == "MUL")
            {
                ans = a * b;
                label4.Text = ans.ToString();
            }
            else if (comboBox1.SelectedItem.ToString() == "DIV")
            {
                ans = a / b;
                label4.Text = ans.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
