namespace CourseDataBase
{
    partial class FormGDReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTable5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new CourseDataBase.storeDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable5TableAdapter = new CourseDataBase.storeDataSetTableAdapters.DataTable5TableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.good1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonGenReport = new System.Windows.Forms.Button();
            this.good1TableAdapter = new CourseDataBase.storeDataSetTableAdapters.good1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.good1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable5BindingSource
            // 
            this.dataTable5BindingSource.DataMember = "DataTable5";
            this.dataTable5BindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryDataGridViewTextBoxColumn,
            this.goodDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable5BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(996, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Категорія";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // goodDataGridViewTextBoxColumn
            // 
            this.goodDataGridViewTextBoxColumn.DataPropertyName = "good";
            this.goodDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.goodDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.goodDataGridViewTextBoxColumn.Name = "goodDataGridViewTextBoxColumn";
            this.goodDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataTable5TableAdapter
            // 
            this.dataTable5TableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet6";
            reportDataSource1.Value = this.dataTable5BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CourseDataBase.ReportGD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 342);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(996, 204);
            this.reportViewer1.TabIndex = 1;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.good1BindingSource, "producing country", true));
            this.comboBoxCountry.DataSource = this.good1BindingSource;
            this.comboBoxCountry.DisplayMember = "producing country";
            this.comboBoxCountry.Location = new System.Drawing.Point(40, 19);
            this.comboBoxCountry.MaxDropDownItems = 20;
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(209, 28);
            this.comboBoxCountry.TabIndex = 2;
            this.comboBoxCountry.ValueMember = "producing country";
            // 
            // good1BindingSource
            // 
            this.good1BindingSource.DataMember = "good1";
            this.good1BindingSource.DataSource = this.storeDataSet;
            // 
            // buttonGenReport
            // 
            this.buttonGenReport.Location = new System.Drawing.Point(293, 12);
            this.buttonGenReport.Name = "buttonGenReport";
            this.buttonGenReport.Size = new System.Drawing.Size(230, 41);
            this.buttonGenReport.TabIndex = 3;
            this.buttonGenReport.Text = "Генерувати звіт";
            this.buttonGenReport.UseVisualStyleBackColor = true;
            this.buttonGenReport.Click += new System.EventHandler(this.buttonGenReport_Click);
            // 
            // good1TableAdapter
            // 
            this.good1TableAdapter.ClearBeforeFill = true;
            // 
            // FormGDReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 570);
            this.Controls.Add(this.buttonGenReport);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormGDReport";
            this.Text = "Запит \"Товари заданої країни-виробника\"";
            this.Load += new System.EventHandler(this.FormGDReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.good1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataTable5BindingSource;
        private storeDataSet storeDataSet;
        private storeDataSetTableAdapters.DataTable5TableAdapter dataTable5TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Button buttonGenReport;
        private System.Windows.Forms.BindingSource good1BindingSource;
        private storeDataSetTableAdapters.good1TableAdapter good1TableAdapter;
    }
}