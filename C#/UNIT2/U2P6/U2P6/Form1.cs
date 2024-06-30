using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2P6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i,no,ans=1;
            no=int.Parse(textBox1.Text);
            for(i=1;i<=no;i++)
            {
                ans=ans * i;
            }
            MessageBox.Show(" Factorial is "+ans.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x;
            x=int.Parse(textBox2.Text);
            if(x%2==0)
            {
                MessageBox.Show(x.ToString() + " is a even");
            }
            else
            {
                MessageBox.Show(x.ToString() + " is a odd");
            }
        }
    }
}
