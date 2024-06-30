using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace U4P3
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=U4P3;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adp = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\aaa\Documents\mybca.mdf;Integrated Security=True;Connect Timeout=30");
            cmd = new SqlCommand("select * from State",con);
            adp = new SqlDataAdapter(cmd);
            ds = new DataSet();
            adp.Fill(ds);
            comboBox1.DisplayMember="Statename";
            comboBox1.ValueMember = "Statecode";
            comboBox1.DataSource =ds.Tables[0];

           /* SqlCommand cmd1 = new SqlCommand();
           
            cmd1 = new SqlCommand("select * from City", con);
            adp = new SqlDataAdapter(cmd1);
            ds = new DataSet();
            adp.Fill(ds);
            comboBox2.DisplayMember = "Cityname";
            comboBox2.ValueMember = "Cityid";
            comboBox2.DataSource = ds.Tables[0];*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            SqlCommand cmd2 = new SqlCommand();
            cmd2 = new SqlCommand("select Statecode from State where Statename = '"+comboBox1.Text+"'",con);
            cmd2.Connection = con;
            con.Open();
            int i = Convert.ToInt16(cmd2.ExecuteScalar());
            cmd2.CommandText = "select Cityname from City where Statecode ="+i;
            adp = new SqlDataAdapter(cmd2); 
            ds = new DataSet();
            adp.Fill(ds);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
