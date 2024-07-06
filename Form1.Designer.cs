namespace CourseDataBase
{
    partial class Form1
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
            this.buttonAddress = new System.Windows.Forms.Button();
            this.groupBoxTableDB = new System.Windows.Forms.GroupBox();
            this.buttonDeliveryService = new System.Windows.Forms.Button();
            this.buttonInvoiceDetail = new System.Windows.Forms.Button();
            this.buttonInvoice = new System.Windows.Forms.Button();
            this.buttonGoodsInWarehouse = new System.Windows.Forms.Button();
            this.buttonWarehouse = new System.Windows.Forms.Button();
            this.buttonSeller = new System.Windows.Forms.Button();
            this.buttonCategory = new System.Windows.Forms.Button();
            this.buttonGood = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.groupBoxTableDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddress
            // 
            this.buttonAddress.Location = new System.Drawing.Point(20, 34);
            this.buttonAddress.Name = "buttonAddress";
            this.buttonAddress.Size = new System.Drawing.Size(190, 50);
            this.buttonAddress.TabIndex = 0;
            this.buttonAddress.Text = "Адреса";
            this.buttonAddress.UseVisualStyleBackColor = true;
            this.buttonAddress.Click += new System.EventHandler(this.buttonAddress_Click);
            // 
            // groupBoxTableDB
            // 
            this.groupBoxTableDB.Controls.Add(this.buttonDeliveryService);
            this.groupBoxTableDB.Controls.Add(this.buttonInvoiceDetail);
            this.groupBoxTableDB.Controls.Add(this.buttonInvoice);
            this.groupBoxTableDB.Controls.Add(this.buttonGoodsInWarehouse);
            this.groupBoxTableDB.Controls.Add(this.buttonWarehouse);
            this.groupBoxTableDB.Controls.Add(this.buttonSeller);
            this.groupBoxTableDB.Controls.Add(this.buttonCategory);
            this.groupBoxTableDB.Controls.Add(this.buttonGood);
            this.groupBoxTableDB.Controls.Add(this.buttonCustomer);
            this.groupBoxTableDB.Controls.Add(this.buttonAddress);
            this.groupBoxTableDB.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTableDB.Name = "groupBoxTableDB";
            this.groupBoxTableDB.Size = new System.Drawing.Size(749, 327);
            this.groupBoxTableDB.TabIndex = 1;
            this.groupBoxTableDB.TabStop = false;
            this.groupBoxTableDB.Text = "Таблиці Бази Даних";
            // 
            // buttonDeliveryService
            // 
            this.buttonDeliveryService.Location = new System.Drawing.Point(20, 259);
            this.buttonDeliveryService.Name = "buttonDeliveryService";
            this.buttonDeliveryService.Size = new System.Drawing.Size(190, 52);
            this.buttonDeliveryService.TabIndex = 9;
            this.buttonDeliveryService.Text = "Служба доставки";
            this.buttonDeliveryService.UseVisualStyleBackColor = true;
            this.buttonDeliveryService.Click += new System.EventHandler(this.buttonDeliveryService_Click);
            // 
            // buttonInvoiceDetail
            // 
            this.buttonInvoiceDetail.Location = new System.Drawing.Point(452, 181);
            this.buttonInvoiceDetail.Name = "buttonInvoiceDetail";
            this.buttonInvoiceDetail.Size = new System.Drawing.Size(190, 52);
            this.buttonInvoiceDetail.TabIndex = 8;
            this.buttonInvoiceDetail.Text = "Деталі накладної";
            this.buttonInvoiceDetail.UseVisualStyleBackColor = true;
            this.buttonInvoiceDetail.Click += new System.EventHandler(this.buttonInvoiceDetail_Click);
            // 
            // buttonInvoice
            // 
            this.buttonInvoice.Location = new System.Drawing.Point(231, 181);
            this.buttonInvoice.Name = "buttonInvoice";
            this.buttonInvoice.Size = new System.Drawing.Size(190, 52);
            this.buttonInvoice.TabIndex = 7;
            this.buttonInvoice.Text = "Накладна";
            this.buttonInvoice.UseVisualStyleBackColor = true;
            this.buttonInvoice.Click += new System.EventHandler(this.buttonInvoice_Click);
            // 
            // buttonGoodsInWarehouse
            // 
            this.buttonGoodsInWarehouse.Location = new System.Drawing.Point(20, 181);
            this.buttonGoodsInWarehouse.Name = "buttonGoodsInWarehouse";
            this.buttonGoodsInWarehouse.Size = new System.Drawing.Size(190, 52);
            this.buttonGoodsInWarehouse.TabIndex = 6;
            this.buttonGoodsInWarehouse.Text = "Товари на складі";
            this.buttonGoodsInWarehouse.UseVisualStyleBackColor = true;
            this.buttonGoodsInWarehouse.Click += new System.EventHandler(this.buttonGoodsInWarehouse_Click);
            // 
            // buttonWarehouse
            // 
            this.buttonWarehouse.Location = new System.Drawing.Point(452, 105);
            this.buttonWarehouse.Name = "buttonWarehouse";
            this.buttonWarehouse.Size = new System.Drawing.Size(190, 50);
            this.buttonWarehouse.TabIndex = 5;
            this.buttonWarehouse.Text = "Склад";
            this.buttonWarehouse.UseVisualStyleBackColor = true;
            this.buttonWarehouse.Click += new System.EventHandler(this.buttonWarehouse_Click);
            // 
            // buttonSeller
            // 
            this.buttonSeller.Location = new System.Drawing.Point(231, 105);
            this.buttonSeller.Name = "buttonSeller";
            this.buttonSeller.Size = new System.Drawing.Size(190, 50);
            this.buttonSeller.TabIndex = 4;
            this.buttonSeller.Text = "Продавець";
            this.buttonSeller.UseVisualStyleBackColor = true;
            this.buttonSeller.Click += new System.EventHandler(this.buttonSeller_Click);
            // 
            // buttonCategory
            // 
            this.buttonCategory.Location = new System.Drawing.Point(20, 105);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Size = new System.Drawing.Size(190, 50);
            this.buttonCategory.TabIndex = 3;
            this.buttonCategory.Text = "Категорія";
            this.buttonCategory.UseVisualStyleBackColor = true;
            this.buttonCategory.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonGood
            // 
            this.buttonGood.Location = new System.Drawing.Point(452, 34);
            this.buttonGood.Name = "buttonGood";
            this.buttonGood.Size = new System.Drawing.Size(190, 50);
            this.buttonGood.TabIndex = 2;
            this.buttonGood.Text = "Товар";
            this.buttonGood.UseVisualStyleBackColor = true;
            this.buttonGood.Click += new System.EventHandler(this.buttonGood_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Location = new System.Drawing.Point(231, 34);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(190, 50);
            this.buttonCustomer.TabIndex = 1;
            this.buttonCustomer.Text = "Покупець";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 344);
            this.Controls.Add(this.groupBoxTableDB);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База даних";
            this.groupBoxTableDB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddress;
        private System.Windows.Forms.GroupBox groupBoxTableDB;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Button buttonGood;
        private System.Windows.Forms.Button buttonCategory;
        private System.Windows.Forms.Button buttonSeller;
        private System.Windows.Forms.Button buttonWarehouse;
        private System.Windows.Forms.Button buttonGoodsInWarehouse;
        private System.Windows.Forms.Button buttonInvoice;
        private System.Windows.Forms.Button buttonInvoiceDetail;
        private System.Windows.Forms.Button buttonDeliveryService;
    }
}

