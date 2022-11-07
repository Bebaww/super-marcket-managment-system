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

namespace employeemanagment
{
    public partial class product_managment : Form
    {
        public product_managment()
        {
            InitializeComponent();
            getemployeerecord();
        }
        string str = @"data source=BESU\SQLEXPRESS ; initial catalog = SuperMarcketss  ; integrated security= true";
        public void getemployeerecord()
        {
            SqlConnection sqlcon = new SqlConnection(str);

            //   MessageBox.Show("connected successfully");

            string query = "select * from product";
            SqlCommand com = new SqlCommand(query, sqlcon);
            DataTable dt = new DataTable();
            sqlcon.Open();
            SqlDataReader sdr = com.ExecuteReader();
            dt.Load(sdr);
            com.ExecuteNonQuery();

            sqlcon.Close();
            dataGridView1.DataSource = dt;

            //getemployeerecord();





        }
        private void employeemanagment_Load(object sender, EventArgs e)
        {
            getemployeerecord();
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(str);
            sqlcon.Open();
            MessageBox.Show("connected successfully");

            string query = "insert into product values('" +txt_productname.Text + "','" + txt_batchno.Text + "','" + productiondate.Text + "','" + expirydate.Text + "', '" + txt_type.Text + "')";
            // validate();
            SqlCommand com = new SqlCommand(query, sqlcon);
            com.ExecuteNonQuery();

            sqlcon.Close();
            getemployeerecord();
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(str);
            sqlcon.Open();


            string query = "update product set name='" +txt_productname.Text + "' , productiondate='" + productiondate.Text + "',expirydate='" + expirydate.Text + "' ,type='" +txt_type.Text + "' where batchno='" +txt_batchno.Text + "'";
            SqlCommand com = new SqlCommand(query, sqlcon);

            com.ExecuteNonQuery();

            sqlcon.Close();
            //validate();


            getemployeerecord();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(str);
            sqlcon.Open();

            string query = "delete  from product where batchno='" + txt_batchno.Text + "'";
            SqlCommand com = new SqlCommand(query, sqlcon);
            com.ExecuteNonQuery();

            sqlcon.Close();


            getemployeerecord();
        }

        private void search_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(str);

            //   MessageBox.Show("connected successfully");

            string query = "select * from product where batchno='" + txt_batchno.Text + "'";
            SqlCommand com = new SqlCommand(query, sqlcon);
            DataTable dt = new DataTable();
            sqlcon.Open();
            SqlDataReader sdr = com.ExecuteReader();
            dt.Load(sdr);
            com.ExecuteNonQuery();

            sqlcon.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
