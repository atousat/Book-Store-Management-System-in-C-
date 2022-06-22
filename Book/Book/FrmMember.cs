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
    public partial class FrmMember : Form
    {
        BookEntities databse = new BookEntities();
        public FrmMember()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String name = txtName.Text.Trim();
            String lastname = txtLastName.Text.Trim();
            String phone = mskPhone.Text.ToString();
            String nationalcode = mskNationalCode.Text.ToString();
            String bookname = txtBook.Text.Trim();
            databse.CreatMember(@name ,@lastname ,@phone ,@nationalcode ,@bookname);
            MessageBox.Show("اطلاعات با موفقیت ثبت شد.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String lastname = txtLastName.Text.Trim();
            String nationalcode = mskNationalCode.Text.ToString();

            List<ListMember_Result> result = databse.ListMember(@lastname, @nationalcode).ToList<ListMember_Result>();

            DgvMember.DataSource = result;

            foreach (ListMember_Result item in result)
            {
                if (txtLastName.Text.Equals(item.LastName) && mskNationalCode.Text.Equals(item.NationalCode))

                    MessageBox.Show("جست و جو با موفقیت انجام شد.");
                else
                    MessageBox.Show("جست و جوی مورد نظر یافت نشد،دوباره امتحان کنید.");
            }
        }
    }
}
