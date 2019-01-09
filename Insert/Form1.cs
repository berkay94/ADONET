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

namespace Insert
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=10.10.22.199;Initial Catalog=NORTHWND2;User ID=test2;Password=test2");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            string sql = "insert into Categories(CategoryName,Description) Values('"+ textBox1.Text+"','" +textBox2.Text+"')";
            SqlCommand cmd = new SqlCommand(sql,con);
            con.Open();
            
            k=cmd.ExecuteNonQuery();
            con.Close();


           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = 0;
            string sql = "insert into Categories(CategoryName,Description) Values(@catname,@desc) Select @@ IDENTITY";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@catname", textBox1.Text);
            cmd.Parameters.AddWithValue("@desc", textBox2.Text);
            con.Open();
            k =Convert.ToInt32( cmd.ExecuteScalar());
            label3.Text = "ID:" + k.ToString();
            con.Close();

            //cmd.ExecuteNonQuery()//Etkilenen kayıt sayısını geri verir
            //cmd.ExecuteReader();//DataReader nesnesi geri verir
            //cmd.ExecuteScalar();//Tek bir değer verir

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int k = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText="InsertB";
            cmd.Parameters.AddWithValue("@Categoryname", textBox1.Text);
            cmd.Parameters.AddWithValue("@Description", textBox2.Text);
           
            k = cmd.ExecuteNonQuery();
            if (k == 1)
            {
                MessageBox.Show("eklendi");
            }
            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
