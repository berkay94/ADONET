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

namespace Ornek
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=10.10.22.199;Initial Catalog=NORTHWND2;User ID=test2;Password=test2");

        SqlDataAdapter dap;
        DataTable tbl;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbl = new DataTable();
            dap =new SqlDataAdapter("Select CustomerID,CompanyName From Customers", con);
            dap.Fill(tbl);
            listBox1.DataSource = tbl;
            listBox1.DisplayMember = "CompanyName";
            listBox1.ValueMember = "CustomerID";


            tbl = new DataTable();
            dap = new SqlDataAdapter("Select ShipperID,CompanyName From Shippers", con);
            dap.Fill(tbl);
            comboBox1.DataSource = tbl;
            comboBox1.DisplayMember = "CompanyName";
            comboBox1.ValueMember = "ShipperID";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                dap = new SqlDataAdapter("Select CONVERT(nvarchar(10),OrderID)+' '+CONVERT(nvarchar(20),OrderDate,10) as 'DisplayColumn' From Orders Where CustomerID=@cId and Shipvia=@sid", con);

                dap.SelectCommand.Parameters.AddWithValue("@cId", listBox1.SelectedValue);

                dap.SelectCommand.Parameters.AddWithValue("@sid", comboBox1.SelectedValue);

                tbl = new DataTable();
                dap.Fill(tbl);
                listBox2.DataSource = tbl;
                listBox2.DisplayMember = "DisplayColumn";

            
        }
    }
}
