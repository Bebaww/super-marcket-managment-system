using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employeemanagment
{
    public partial class LOG_IN : Form
    {
        public LOG_IN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "admin" & txt_password.Text == "admin")
            {
                MENU menu = new MENU();
                menu.Show();
            }
            else if (txt_username.Text == "cashier" & txt_password.Text == "cashier")
            {
                product_managment p = new product_managment();
                p.Show();
            }
            else
                MessageBox.Show("incorrect password or username");
            txt_password.Text = "";
            txt_username.Text = "";


        }
    }
}
