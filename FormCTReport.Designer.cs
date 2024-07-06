namespace CourseDataBase
{
    partial class FormCTReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.storeDataSet = new CourseDataBase.storeDataSet();
            this.category1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.category1TableAdapter = new CourseDataBase.storeDataSetTableAdapters.category1TableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.category1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.goodcountDataGridViewTextBoxColumn,
            this.maxpriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.category1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(919, 275);
            this.dataGridView1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet4";
            reportDataSource2.Value = this.category1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CourseDataBase.ReportCT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(22, 314);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(919, 280);
            this.reportViewer1.TabIndex = 1;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // category1BindingSource
            // 
            this.category1BindingSource.DataMember = "category1";
            this.category1BindingSource.DataSource = this.storeDataSet;
            // 
            // category1TableAdapter
            // 
            this.category1TableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Категорія";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // goodcountDataGridViewTextBoxColumn
            // 
            this.goodcountDataGridViewTextBoxColumn.DataPropertyName = "good_count";
            this.goodcountDataGridViewTextBoxColumn.HeaderText = "Кількість товарів";
            this.goodcountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.goodcountDataGridViewTextBoxColumn.Name = "goodcountDataGridViewTextBoxColumn";
            this.goodcountDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodcountDataGridViewTextBoxColumn.Width = 150;
            // 
            // maxpriceDataGridViewTextBoxColumn
            // 
            this.maxpriceDataGridViewTextBoxColumn.DataPropertyName = "max_price";
            this.maxpriceDataGridViewTextBoxColumn.HeaderText = "Ціна найдорожчого товару";
            this.maxpriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.maxpriceDataGridViewTextBoxColumn.Name = "maxpriceDataGridViewTextBoxColumn";
            this.maxpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.maxpriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // FormCTReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 606);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCTReport";
            this.Text = "Запит \"Кількість товарів у категоріях та ціна найдорожчого товару\"";
            this.Load += new System.EventHandler(this.FormCTReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.category1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private storeDataSet storeDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource category1BindingSource;
        private storeDataSetTableAdapters.category1TableAdapter category1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxpriceDataGridViewTextBoxColumn;
    }
}