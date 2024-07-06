using CourseDataBase.storeDataSetTableAdapters;
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
    public partial class FormGood : Form
    {
        public FormGood()
        {
            InitializeComponent();
        }
        public void UpdateDataMessage()
        {
            MessageBox.Show("Дані успішно збережені!",
                "Оновлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormGood_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.storeDataSet.category);
            // TODO: This line of code loads data into the 'storeDataSet.good' table. You can move, or remove it, as needed.
            this.goodTableAdapter.Fill(this.storeDataSet.good);

        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                goodTableAdapter.Update(this.storeDataSet);
                UpdateDataMessage(); // повідомлення про успішну операцію
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Ця таблиця має зв'язки з іншою таблицею",
                "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error); // повідомлення про помилку
            }
        }

        private void buttonReportGood_Click(object sender, EventArgs e)
        {
            FormGDReport goodReport = new FormGDReport();   
            goodReport.ShowDialog();
        }
    }
}
