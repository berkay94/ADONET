using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Select
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=10.10.22.199;Initial Catalog=NORTHWND2;User ID=test2;Password=test2");

        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select FirstName,LastName,BirthDate from Employees",con);
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            if(rdr.HasRows)
            {
                while (rdr.Read())
                {
                    listBox1.Items.Add($"{rdr["FirstName"]} {rdr["LastName"]} -> {rdr["BirthDate"]}");
                }
            }
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
           

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string ad, soyad,str;
            DateTime? trh=new DateTime(1900,1,1);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select FirstName,LastName,BirthDate from Employees",con);

            da.Fill(ds);

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                //listBox1.Items.Add($"{item["FirstName"]} {item["LastName"]} -> {item["BirthDate"]}");
                ad = item["FirstName"].ToString();
                soyad = item["LastName"].ToString();
                str = item["BirthDate"].ToString();
                if(str!="")
                trh = Convert.ToDateTime(str);
                listBox1.Items.Add($"{ad} {soyad} -> {trh.ToString()}");

            }
           

        }

        
    }
}
