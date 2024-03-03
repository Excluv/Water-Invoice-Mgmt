namespace BTN___Nguyễn_Hoàng_Bách___N22___Đề_số_01
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.btnExit = new System.Windows.Forms.MenuStrip();
            this.btnSearchCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.CustomerList = new System.Windows.Forms.DataGridView();
            this.btnExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSearchCustomer,
            this.btnBack,
            this.btnQuit});
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(337, 24);
            this.btnExit.TabIndex = 7;
            this.btnExit.TabStop = true;
            this.btnExit.Text = "menuStrip1";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCustomer.Image")));
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(84, 20);
            this.btnSearchCustomer.Text = "Tìm kiếm";
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
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
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Danh sách khách hàng";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(225, 37);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(101, 61);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Xoá khách hàng";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(119, 37);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 61);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Sửa thông tin khách hàng";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 61);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm thông tin khách hàng";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CustomerList
            // 
            this.CustomerList.AllowUserToOrderColumns = true;
            this.CustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CustomerList.Location = new System.Drawing.Point(0, 129);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.RowTemplate.Height = 25;
            this.CustomerList.Size = new System.Drawing.Size(337, 117);
            this.CustomerList.TabIndex = 8;
            this.CustomerList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CustomerList_CellMouseClick);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 246);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.CustomerList);
            this.Name = "Customer";
            this.Text = "Quản lý thông tin khách hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customer_FormClosed);
            this.btnExit.ResumeLayout(false);
            this.btnExit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip btnExit;
        private ToolStripMenuItem btnBack;
        private ToolStripMenuItem btnQuit;
        private Label label1;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnAdd;
        public DataGridView CustomerList;
        private ToolStripMenuItem btnSearchCustomer;
    }
}