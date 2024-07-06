namespace CourseDataBase
{
    partial class FormReportInvoice2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTable4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new CourseDataBase.storeDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordermounthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcustsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable4TableAdapter = new CourseDataBase.storeDataSetTableAdapters.DataTable4TableAdapter();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonGenReport = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.labelStartD = new System.Windows.Forms.Label();
            this.labelEndY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable4BindingSource
            // 
            this.dataTable4BindingSource.DataMember = "DataTable4";
            this.dataTable4BindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderyearDataGridViewTextBoxColumn,
            this.ordermounthDataGridViewTextBoxColumn,
            this.numcustsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable4BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(913, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderyearDataGridViewTextBoxColumn
            // 
            this.orderyearDataGridViewTextBoxColumn.DataPropertyName = "orderyear";
            this.orderyearDataGridViewTextBoxColumn.HeaderText = "Рік";
            this.orderyearDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderyearDataGridViewTextBoxColumn.Name = "orderyearDataGridViewTextBoxColumn";
            this.orderyearDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderyearDataGridViewTextBoxColumn.Width = 150;
            // 
            // ordermounthDataGridViewTextBoxColumn
            // 
            this.ordermounthDataGridViewTextBoxColumn.DataPropertyName = "ordermounth";
            this.ordermounthDataGridViewTextBoxColumn.HeaderText = "Місяць";
            this.ordermounthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ordermounthDataGridViewTextBoxColumn.Name = "ordermounthDataGridViewTextBoxColumn";
            this.ordermounthDataGridViewTextBoxColumn.ReadOnly = true;
            this.ordermounthDataGridViewTextBoxColumn.Width = 150;
            // 
            // numcustsDataGridViewTextBoxColumn
            // 
            this.numcustsDataGridViewTextBoxColumn.DataPropertyName = "numcusts";
            this.numcustsDataGridViewTextBoxColumn.HeaderText = "Кількість покупців";
            this.numcustsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numcustsDataGridViewTextBoxColumn.Name = "numcustsDataGridViewTextBoxColumn";
            this.numcustsDataGridViewTextBoxColumn.ReadOnly = true;
            this.numcustsDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataTable4TableAdapter
            // 
            this.dataTable4TableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "yyyy-MM";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(53, 33);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerStart.TabIndex = 1;
            this.dateTimePickerStart.Value = new System.DateTime(2021, 1, 24, 10, 31, 0, 0);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "yyyy-MM";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(330, 34);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerEnd.TabIndex = 2;
            // 
            // buttonGenReport
            // 
            this.buttonGenReport.Location = new System.Drawing.Point(596, 28);
            this.buttonGenReport.Name = "buttonGenReport";
            this.buttonGenReport.Size = new System.Drawing.Size(199, 32);
            this.buttonGenReport.TabIndex = 3;
            this.buttonGenReport.Text = "Згенерувати звіт";
            this.buttonGenReport.UseVisualStyleBackColor = true;
            this.buttonGenReport.Click += new System.EventHandler(this.buttonGenReport_Click);
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet5";
            reportDataSource3.Value = this.dataTable4BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CourseDataBase.ReportIV2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 377);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(919, 243);
            this.reportViewer1.TabIndex = 4;
            // 
            // labelStartD
            // 
            this.labelStartD.AutoSize = true;
            this.labelStartD.Location = new System.Drawing.Point(13, 38);
            this.labelStartD.Name = "labelStartD";
            this.labelStartD.Size = new System.Drawing.Size(34, 20);
            this.labelStartD.TabIndex = 5;
            this.labelStartD.Text = "Від";
            // 
            // labelEndY
            // 
            this.labelEndY.AutoSize = true;
            this.labelEndY.Location = new System.Drawing.Point(294, 39);
            this.labelEndY.Name = "labelEndY";
            this.labelEndY.Size = new System.Drawing.Size(30, 20);
            this.labelEndY.TabIndex = 6;
            this.labelEndY.Text = "До";
            // 
            // FormReportInvoice2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 650);
            this.Controls.Add(this.labelEndY);
            this.Controls.Add(this.labelStartD);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.buttonGenReport);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormReportInvoice2";
            this.Text = "Запит \"Кількість покупців на місць по роках\"";
            this.Load += new System.EventHandler(this.FormReportInvoice2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataTable4BindingSource;
        private storeDataSet storeDataSet;
        private storeDataSetTableAdapters.DataTable4TableAdapter dataTable4TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordermounthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcustsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button buttonGenReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label labelStartD;
        private System.Windows.Forms.Label labelEndY;
    }
}