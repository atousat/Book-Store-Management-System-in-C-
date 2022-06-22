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
    public partial class FrmBook : Form
    {
        BookEntities database = new BookEntities();
        public FrmBook()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String name = txtName.Text.Trim();
            String author = txtAuthor.Text.Trim();
            String topic = cmbTopic.Text.ToString();
            String shelf = numShelf.Text.ToString();
            String num = numNum.Text.ToString();
            String price = txtPrice.Text.ToString();
            database.CreatBook(@name ,@author ,@topic ,@shelf ,@num ,@price);
            MessageBox.Show("اطلاعات با موفقیت ثبت شد.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            String topic = cmbTopic.Text.ToString();


            List<ListTopic_Result> result = database.ListTopic(@topic).ToList<ListTopic_Result>();

            DgvBook.DataSource = result;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
