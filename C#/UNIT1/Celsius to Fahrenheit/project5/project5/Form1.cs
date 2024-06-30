using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float f, c;
            if (radioButton1.Checked == true)
            {
                f = float.Parse(textBox1.Text);
                c=(5*(f-32))/9;
                MessageBox.Show(f.ToString()+" Fahrenheit is Equal to "+c.ToString()+" Celsius");
            }
            else if(radioButton2.Checked==true)
            {
                c = float.Parse(textBox1.Text);
                f = ((9*c)/5) + 32;
                MessageBox.Show(c.ToString() + " Celsisus is Equal to "+f.ToString() + " Fahrenheit");
            }
        }
    }
}
