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
    public partial class Form1 : Form
    {
        BookEntities database = new BookEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String name = txtUser.Text.Trim();
            String pass = txtPass.Text;
            database.CreatAdmin(@name, @pass);
            MessageBox.Show("اطلاعات با موفقیت ثبت شد");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<GetAllUser_Result> result = database.GetAllUser().ToList();

            foreach (GetAllUser_Result item in result)
            {
                if (txtUser.Text.Equals(item.UserName) && txtPass.Text.Equals(item.PassWord))
                {
                    MessageBox.Show("خوش امدید!");
                    new Home().ShowDialog();
                }
                else
                    MessageBox.Show("اطلاعات وارد شده صحیح نیست!");
            }
        }
    }
}
