using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            new FrmMember().ShowDialog();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            new FrmBook().ShowDialog();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            new FrmAboutUS().ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new FrmReport().ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
