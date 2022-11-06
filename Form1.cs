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
using System.Text.RegularExpressions;

namespace employeemanagment
{

    public partial class Form1 : Form
    {
        public void getemployeerecord()
        {
            string str = @"data source=BESU\SQLEXPRESS ; initial catalog = SuperMarcketss  ; integrated security= true";
            SqlConnection sqlcon = new SqlConnection(str);

            //   MessageBox.Show("connected successfully");

            string query = "select * from users";
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
        public Form1()
        {
            InitializeComponent();
            getemployeerecord();    

        }

        private void employeemanagment_Load(object sender, EventArgs e)
        {
            getemployeerecord();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

       

        
        private void button1_Click(object sender, EventArgs e)


        {
            Regex reg1 = new Regex(@"^[a-z]{2}[1-9]{3}$");
            Regex reg2 = new Regex(@"^[A-Z]{1}[a-z]{3,8}$");
            Regex reg3 = new Regex(@"^[m|M|f|F]{1}$");
            Regex reg4 = new Regex(@"^[a-z]{3}[A-Z]{2}[@|#|$]{1}");


            if (!reg1.IsMatch(txt_empid.Text))
            {
                errorProvider1.SetError(txt_empid, "invalid employee id");
            }


             if (!reg2.IsMatch(txt_fname.Text))
            {
                errorProvider1.SetError(txt_fname, "invalid firstname");
            }


            if (!reg2.IsMatch(txt_lname.Text))
            {
                errorProvider1.SetError(txt_lname, "invalid last name");
            }


             if (!reg1.IsMatch(txt_rid.Text))
            {
                errorProvider1.SetError(txt_rid, "invalid rollid");
            }

             if (!reg4.IsMatch(txt_password.Text))
            {
                errorProvider1.SetError(txt_password, "invalid password");
            }
            if (!reg3.IsMatch(txt_gender.Text))
            {
                errorProvider1.SetError(txt_gender, "invalid gender");
            }
            else
            {

                string str = @"data source=BESU\SQLEXPRESS ; initial catalog = SuperMarcketss ; integrated security= true";
                SqlConnection sqlcon = new SqlConnection(str);
                sqlcon.Open();
                MessageBox.Show("connected successfully");

                string query = "insert into users values('" + txt_empid.Text + "','" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_gender.Text + "', '" + txt_rid.Text + "', '" + txt_password.Text + "')";
                // validate();
                SqlCommand com = new SqlCommand(query, sqlcon);
                com.ExecuteNonQuery();

                sqlcon.Close();
                // validate();


                getemployeerecord();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Regex reg1 = new Regex(@"^[a-z]{2}[1-9]{3}$");
            Regex reg2 = new Regex(@"^[A-Z]{1}[a-z]{3,8}$");
            Regex reg3 = new Regex(@"^[m|M|f|F]{1}$");
            Regex reg4 = new Regex(@"^[a-z]{3}[A-Z]{2}[@|#|$]{1}");


            if (!reg1.IsMatch(txt_empid.Text))
            {
                errorProvider1.SetError(txt_empid, "invalid employee id");
               
            }


            if (!reg2.IsMatch(txt_fname.Text))
            {
                errorProvider1.SetError(txt_fname, "invalid firstname");
                
            }


            if (!reg2.IsMatch(txt_lname.Text))
            {
                errorProvider1.SetError(txt_lname, "invalid last name");
               
            }


            if (!reg1.IsMatch(txt_rid.Text))
            {
                errorProvider1.SetError(txt_rid, "invalid rollid");
               
            }

            if (!reg4.IsMatch(txt_password.Text))
            {
                errorProvider1.SetError(txt_password, "invalid password");
               
            }
            if (!reg3.IsMatch(txt_gender.Text))
            {
                errorProvider1.SetError(txt_gender, "invalid gender");
                
            }
            else
            { 
                string str = @"data source=BESU\SQLEXPRESS ; initial catalog = SuperMarcketss ; integrated security= true";
                SqlConnection sqlcon = new SqlConnection(str);
                sqlcon.Open();

             
                string query = "update users set Roleid='" + txt_rid.Text + "' , FirstName='" + txt_fname.Text + "',LastName='" + txt_lname.Text + "' ,Gender='" + txt_gender.Text + "', password='" + txt_password.Text + "' where id='" + txt_empid.Text + "'";
                SqlCommand com = new SqlCommand(query, sqlcon);

                com.ExecuteNonQuery();

                sqlcon.Close();
                //validate();

             
                getemployeerecord();
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = @"data source=BESU\SQLEXPRESS ; initial catalog = SuperMarcketss  ; integrated security= true";
            SqlConnection sqlcon = new SqlConnection(str);
            sqlcon.Open();

            string query = "delete  from users where id='" + txt_empid.Text+ "'";
            SqlCommand com = new SqlCommand(query, sqlcon);
            com.ExecuteNonQuery();

            sqlcon.Close();


            getemployeerecord();

        }
      
        private void button4_Click(object sender, EventArgs e)
        {
            string str = @"data source=BESU\SQLEXPRESS ; initial catalog = SuperMarcketss  ; integrated security= true";
            SqlConnection sqlcon = new SqlConnection(str);

            //   MessageBox.Show("connected successfully");

            string query = "select * from users where id='"+txt_empid.Text+"'";
            SqlCommand com = new SqlCommand(query, sqlcon);
            DataTable dt = new DataTable();
            sqlcon.Open();
            SqlDataReader sdr = com.ExecuteReader();
            dt.Load(sdr);
            com.ExecuteNonQuery();

            sqlcon.Close();
            dataGridView1.DataSource = dt;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_empid.Text = "";
            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_fname.Text = "";
            txt_gender.Text = "";
            txt_rid.Text = "";
            txt_password.Text = "";

        }
    }
}
