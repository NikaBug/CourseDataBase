using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseDataBase
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        public void UpdateDataMessage()
        {
            MessageBox.Show("Дані успішно збережені!",
                "Оновлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.address' table. You can move, or remove it, as needed.
            this.addressTableAdapter.Fill(this.storeDataSet.address);
            // TODO: This line of code loads data into the 'storeDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.storeDataSet.customer);

        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                customerTableAdapter.Update(this.storeDataSet);
                UpdateDataMessage(); // повідомлення про успішну операцію
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Ця таблиця має зв'язки з іншою таблицею",
                "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error); // повідомлення про помилку
            }
        }
    }
}
