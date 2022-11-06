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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void eMPLOYEEMANAGMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
                F.Show();
        }
    }
}
