namespace CourseDataBase
{
    partial class FormIDReport
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
            this.dataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDataSet = new CourseDataBase.storeDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoicenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable3TableAdapter = new CourseDataBase.storeDataSetTableAdapters.DataTable3TableAdapter();
            this.reportViewerID = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDownStart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEnd = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.labelStartNumber = new System.Windows.Forms.Label();
            this.labelEndNumber = new System.Windows.Forms.Label();
            this.labelNumberInvoice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable3BindingSource
            // 
            this.dataTable3BindingSource.DataMember = "DataTable3";
            this.dataTable3BindingSource.DataSource = this.storeDataSet;
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
            this.invoicenumberDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable3BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(890, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // invoicenumberDataGridViewTextBoxColumn
            // 
            this.invoicenumberDataGridViewTextBoxColumn.DataPropertyName = "invoice_number";
            this.invoicenumberDataGridViewTextBoxColumn.HeaderText = "Накладна";
            this.invoicenumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.invoicenumberDataGridViewTextBoxColumn.Name = "invoicenumberDataGridViewTextBoxColumn";
            this.invoicenumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.invoicenumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "Сума до сплати";
            this.totalpriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalpriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataTable3TableAdapter
            // 
            this.dataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // reportViewerID
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.dataTable3BindingSource;
            this.reportViewerID.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerID.LocalReport.ReportEmbeddedResource = "CourseDataBase.ReportID.rdlc";
            this.reportViewerID.Location = new System.Drawing.Point(21, 355);
            this.reportViewerID.Name = "reportViewerID";
            this.reportViewerID.ServerReport.BearerToken = null;
            this.reportViewerID.Size = new System.Drawing.Size(890, 243);
            this.reportViewerID.TabIndex = 1;
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.storeDataSet;
            // 
            // numericUpDownStart
            // 
            this.numericUpDownStart.Location = new System.Drawing.Point(75, 38);
            this.numericUpDownStart.Maximum = new decimal(new int[] {
            4500,
            0,
            0,
            0});
            this.numericUpDownStart.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownStart.Name = "numericUpDownStart";
            this.numericUpDownStart.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownStart.TabIndex = 2;
            this.numericUpDownStart.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDownEnd
            // 
            this.numericUpDownEnd.Location = new System.Drawing.Point(279, 38);
            this.numericUpDownEnd.Maximum = new decimal(new int[] {
            4500,
            0,
            0,
            0});
            this.numericUpDownEnd.Minimum = new decimal(new int[] {
            1001,
            0,
            0,
            0});
            this.numericUpDownEnd.Name = "numericUpDownEnd";
            this.numericUpDownEnd.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownEnd.TabIndex = 3;
            this.numericUpDownEnd.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Location = new System.Drawing.Point(452, 28);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(191, 44);
            this.buttonGenerateReport.TabIndex = 4;
            this.buttonGenerateReport.Text = "Згенерувати звіт";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // labelStartNumber
            // 
            this.labelStartNumber.AutoSize = true;
            this.labelStartNumber.Location = new System.Drawing.Point(26, 40);
            this.labelStartNumber.Name = "labelStartNumber";
            this.labelStartNumber.Size = new System.Drawing.Size(34, 20);
            this.labelStartNumber.TabIndex = 5;
            this.labelStartNumber.Text = "Від";
            // 
            // labelEndNumber
            // 
            this.labelEndNumber.AutoSize = true;
            this.labelEndNumber.Location = new System.Drawing.Point(243, 40);
            this.labelEndNumber.Name = "labelEndNumber";
            this.labelEndNumber.Size = new System.Drawing.Size(30, 20);
            this.labelEndNumber.TabIndex = 6;
            this.labelEndNumber.Text = "До";
            // 
            // labelNumberInvoice
            // 
            this.labelNumberInvoice.AutoSize = true;
            this.labelNumberInvoice.Location = new System.Drawing.Point(139, 9);
            this.labelNumberInvoice.Name = "labelNumberInvoice";
            this.labelNumberInvoice.Size = new System.Drawing.Size(140, 20);
            this.labelNumberInvoice.TabIndex = 7;
            this.labelNumberInvoice.Text = "Номер накладної";
            // 
            // FormIDReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 610);
            this.Controls.Add(this.labelNumberInvoice);
            this.Controls.Add(this.labelEndNumber);
            this.Controls.Add(this.labelStartNumber);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.numericUpDownEnd);
            this.Controls.Add(this.numericUpDownStart);
            this.Controls.Add(this.reportViewerID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormIDReport";
            this.Text = "Запит \"Сума до сплати за накладною\"";
            this.Load += new System.EventHandler(this.FormIDReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private storeDataSet storeDataSet;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
        private storeDataSetTableAdapters.DataTable3TableAdapter dataTable3TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerID;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown numericUpDownStart;
        private System.Windows.Forms.NumericUpDown numericUpDownEnd;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Label labelStartNumber;
        private System.Windows.Forms.Label labelEndNumber;
        private System.Windows.Forms.Label labelNumberInvoice;
    }
}