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
    public partial class FormWarehouse : Form
    {
        public FormWarehouse()
        {
            InitializeComponent();
        }

        public void UpdateDataMessage()
        {
            MessageBox.Show("Дані успішно збережені!",
                "Оновлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormWarehouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDataSet.good' table. You can move, or remove it, as needed.
            this.goodTableAdapter.Fill(this.storeDataSet.good);
            // TODO: This line of code loads data into the 'storeDataSet.goods_in_warehouse' table. You can move, or remove it, as needed.
            this.goods_in_warehouseTableAdapter.Fill(this.storeDataSet.goods_in_warehouse);
            // TODO: This line of code loads data into the 'storeDataSet.warehouse' table. You can move, or remove it, as needed.
            this.warehouseTableAdapter.Fill(this.storeDataSet.warehouse);

        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                warehouseTableAdapter.Update(this.storeDataSet);
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
