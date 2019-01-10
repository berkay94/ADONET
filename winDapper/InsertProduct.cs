using Dapper;
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

namespace winDapper
{
    public partial class InsertProduct : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=10.10.22.199;Initial Catalog=NORTHWND2;User ID=test2;Password=test2");
        public InsertProduct()
        {
            InitializeComponent();
        }

        private void InsertProduct_Load(object sender, EventArgs e)
        {
            var categories = con.Query<Categories>("Select * From Categories");
            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";

            var suppliers = con.Query<Suppliers>("Select * From Suppliers");
            comboBox2.DataSource = suppliers;
            comboBox1.DisplayMember = "CompanyName";
            comboBox1.ValueMember = "SupplierId";

        }
    }
}
