using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U4P2
{
    public partial class Form1 : Form
    {
        public SqlConnection con;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "Select password from tblbca where password='" +textBox2.Text+"'";
            cmd.Connection = con;
            string op;
            op = Convert.ToString(cmd.ExecuteScalar());
            if (op == textBox2.Text)
            {
                MessageBox.Show("Successfully login completed");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();


            }
            else
            {
                MessageBox.Show("Invaild username and password");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=BCA1;Integrated Security=True;Encrypt=False");
            con.Open();
            MessageBox.Show(con.State.ToString());

        }
    }
}
