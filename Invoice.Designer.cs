namespace BTN___Nguyễn_Hoàng_Bách___N22___Đề_số_01
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.btnExit = new System.Windows.Forms.MenuStrip();
            this.btnSearchInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDate = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEmp_Name = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCus_Name = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.InvoiceList = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSearchInvoice,
            this.btnBack,
            this.btnQuit});
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(444, 24);
            this.btnExit.TabIndex = 7;
            this.btnExit.TabStop = true;
            this.btnExit.Text = "menuStrip1";
            // 
            // btnSearchInvoice
            // 
            this.btnSearchInvoice.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemDate,
            this.itemEmp_Name,
            this.itemCus_Name});
            this.btnSearchInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchInvoice.Image")));
            this.btnSearchInvoice.Name = "btnSearchInvoice";
            this.btnSearchInvoice.Size = new System.Drawing.Size(84, 20);
            this.btnSearchInvoice.Text = "Tìm kiếm";
            // 
            // itemDate
            // 
            this.itemDate.Name = "itemDate";
            this.itemDate.Size = new System.Drawing.Size(194, 22);
            this.itemDate.Text = "Tìm HĐ theo ngày lập";
            this.itemDate.Click += new System.EventHandler(this.itemDate_Click);
            // 
            // itemEmp_Name
            // 
            this.itemEmp_Name.Name = "itemEmp_Name";
            this.itemEmp_Name.Size = new System.Drawing.Size(194, 22);
            this.itemEmp_Name.Text = "Tìm HĐ theo người lập";
            this.itemEmp_Name.Click += new System.EventHandler(this.itemEmp_Name_Click);
            // 
            // itemCus_Name
            // 
            this.itemCus_Name.Name = "itemCus_Name";
            this.itemCus_Name.Size = new System.Drawing.Size(194, 22);
            this.itemCus_Name.Text = "Tìm HĐ theo tên KH";
            this.itemCus_Name.Click += new System.EventHandler(this.itemCus_Name_Click);
            // 
            // btnBack
            // 
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 20);
            this.btnBack.Text = "Quay về trang chủ";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(49, 20);
            this.btnQuit.Text = "Thoát";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Danh sách hoá đơn";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(225, 37);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(101, 61);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Xoá hoá đơn";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(119, 37);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 61);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Sửa thông tin hoá đơn";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 61);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm thông tin hoá đơn";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // InvoiceList
            // 
            this.InvoiceList.AllowUserToOrderColumns = true;
            this.InvoiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InvoiceList.Location = new System.Drawing.Point(0, 131);
            this.InvoiceList.Name = "InvoiceList";
            this.InvoiceList.RowTemplate.Height = 25;
            this.InvoiceList.Size = new System.Drawing.Size(444, 117);
            this.InvoiceList.TabIndex = 8;
            this.InvoiceList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.InvoiceList_CellMouseClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(332, 37);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(101, 61);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "In hoá đơn";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 248);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.InvoiceList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Invoice";
            this.Text = "Quản lý hoá đơn nước";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Invoice_FormClosed);
            this.btnExit.ResumeLayout(false);
            this.btnExit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip btnExit;
        private ToolStripMenuItem btnSearchInvoice;
        private ToolStripMenuItem btnBack;
        private ToolStripMenuItem btnQuit;
        private Label label1;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnAdd;
        public DataGridView InvoiceList;
        private Button btnPrint;
        private ToolStripMenuItem itemDate;
        private ToolStripMenuItem itemEmp_Name;
        private ToolStripMenuItem itemCus_Name;
    }
}