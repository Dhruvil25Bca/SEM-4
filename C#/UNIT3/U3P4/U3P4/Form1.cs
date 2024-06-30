using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3P4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            book b=new book();
            b.getdata(1);
            b.getdata(1,"C#");
            b.getdata(1,"C#",435);
            MessageBox.Show(b.showdata());
        }
    }
}
