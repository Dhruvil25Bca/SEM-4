using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int r,g,b;
            r=hScrollBar1.Value;
            g=hScrollBar2.Value;
            b=hScrollBar3.Value;
            label4.Text = r.ToString();
            label5.Text = g.ToString();
            label6.Text = b.ToString();
            pictureBox1.BackColor = Color.FromArgb(255, r, b, g);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            int r, g, b;
            r = hScrollBar1.Value;
            g = hScrollBar2.Value;
            b = hScrollBar3.Value;
            label4.Text = r.ToString();
            label5.Text = g.ToString();
            label6.Text = b.ToString();
            pictureBox1.BackColor = Color.FromArgb(255, r, b, g);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            int r, g, b;
            r = hScrollBar1.Value;
            g = hScrollBar2.Value;
            b = hScrollBar3.Value;
            label4.Text = r.ToString();
            label5.Text = g.ToString();
            label6.Text = b.ToString();
            pictureBox1.BackColor = Color.FromArgb(255, r, b, g);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor=pictureBox1.BackColor;
        }
    }
}
