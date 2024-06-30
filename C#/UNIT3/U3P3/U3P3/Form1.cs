using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3P3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee e1= new Employee();
            Employee e2= new Employee(3012);
            Employee e3= new Employee(3012,"Chirag");
            Employee e4= new Employee(3012,"Chirag",700000);
            MessageBox.Show(e1.showdata());
            MessageBox.Show(e2.showdata());
            MessageBox.Show(e3.showdata());
            MessageBox.Show(e4.showdata());
        }
    }
}
