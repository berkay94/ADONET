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

namespace Disconnected
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=10.10.22.199;Initial Catalog=NORTHWND2;User ID=test2;Password=test2");

        SqlDataAdapter dap;
        DataSet ds;
        DataTable tbl;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbl = new DataTable();
            dap = new SqlDataAdapter("Select CategoryId,CategoryName From Categories order by CategoryId", con);
            dap.Fill(tbl);
            comboBox1.DataSource = tbl;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryId";

            

         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dap = new SqlDataAdapter("Select ProductId,ProductName From Products Where CategoryId=@id", con);
                dap.SelectCommand.Parameters.AddWithValue("@id", comboBox1.SelectedValue);
                tbl = new DataTable();
                dap.Fill(tbl);
                listBox1.DataSource = tbl;
                listBox1.DisplayMember = "ProductName";
                listBox1.ValueMember = "ProductId";
            }

            catch
            {

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dap = new SqlDataAdapter("UrunSiparisleri", con);
                dap.SelectCommand.CommandType = CommandType.StoredProcedure;
                dap.SelectCommand.Parameters.AddWithValue("@productId", listBox1.SelectedValue);

                tbl = new DataTable();
                dap.Fill(tbl);
                dataGridView1.DataSource = tbl;
            }

            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
