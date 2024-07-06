namespace CourseDataBase
{
    partial class FormReportInvoice
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
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new CourseDataBase.storeDataSet();
            this.buttonReportInvoice = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reportViewerIV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTable2TableAdapter = new CourseDataBase.storeDataSetTableAdapters.DataTable2TableAdapter();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelStartYear = new System.Windows.Forms.Label();
            this.labelEndYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.storeDataSet;
            // 
            // storeDataSet
            // 
            this.storeDataSet.DataSetName = "storeDataSet";
            this.storeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonReportInvoice
            // 
            this.buttonReportInvoice.Location = new System.Drawing.Point(654, 19);
            this.buttonReportInvoice.Name = "buttonReportInvoice";
            this.buttonReportInvoice.Size = new System.Drawing.Size(162, 36);
            this.buttonReportInvoice.TabIndex = 1;
            this.buttonReportInvoice.Text = "Звіт";
            this.buttonReportInvoice.UseVisualStyleBackColor = true;
            this.buttonReportInvoice.Click += new System.EventHandler(this.buttonReportInvoice_Click);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "yyyy";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(63, 22);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerStart.TabIndex = 4;
            this.dateTimePickerStart.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "yyyy";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(339, 22);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerEnd.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yearDataGridViewTextBoxColumn,
            this.amoutDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.dataTable2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(930, 219);
            this.dataGridView1.TabIndex = 6;
            // 
            // reportViewerIV
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.dataTable2BindingSource;
            this.reportViewerIV.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerIV.LocalReport.ReportEmbeddedResource = "CourseDataBase.ReportIV.rdlc";
            this.reportViewerIV.Location = new System.Drawing.Point(27, 311);
            this.reportViewerIV.Name = "reportViewerIV";
            this.reportViewerIV.ServerReport.BearerToken = null;
            this.reportViewerIV.Size = new System.Drawing.Size(930, 244);
            this.reportViewerIV.TabIndex = 7;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Рік";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 150;
            // 
            // amoutDataGridViewTextBoxColumn
            // 
            this.amoutDataGridViewTextBoxColumn.DataPropertyName = "amout";
            this.amoutDataGridViewTextBoxColumn.HeaderText = "Кількість товарів";
            this.amoutDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.amoutDataGridViewTextBoxColumn.Name = "amoutDataGridViewTextBoxColumn";
            this.amoutDataGridViewTextBoxColumn.ReadOnly = true;
            this.amoutDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sum_price";
            this.dataGridViewTextBoxColumn1.HeaderText = "Загальна ціна";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // labelStartYear
            // 
            this.labelStartYear.AutoSize = true;
            this.labelStartYear.Location = new System.Drawing.Point(23, 27);
            this.labelStartYear.Name = "labelStartYear";
            this.labelStartYear.Size = new System.Drawing.Size(34, 20);
            this.labelStartYear.TabIndex = 8;
            this.labelStartYear.Text = "Від";
            // 
            // labelEndYear
            // 
            this.labelEndYear.AutoSize = true;
            this.labelEndYear.Location = new System.Drawing.Point(303, 22);
            this.labelEndYear.Name = "labelEndYear";
            this.labelEndYear.Size = new System.Drawing.Size(30, 20);
            this.labelEndYear.TabIndex = 9;
            this.labelEndYear.Text = "До";
            // 
            // FormReportInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 578);
            this.Controls.Add(this.labelEndYear);
            this.Controls.Add(this.labelStartYear);
            this.Controls.Add(this.reportViewerIV);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.buttonReportInvoice);
            this.Name = "FormReportInvoice";
            this.Text = "Запит \"Загальна ціна замовлених товарів за рік\"";
            this.Load += new System.EventHandler(this.FormReportInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private System.Windows.Forms.DataGridViewTextBoxColumn sumPriceDataGridViewTextBoxColumn;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.Button buttonReportInvoice;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private storeDataSetTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerIV;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label labelStartYear;
        private System.Windows.Forms.Label labelEndYear;
    }
}