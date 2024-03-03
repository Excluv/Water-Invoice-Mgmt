namespace BTN___Nguyễn_Hoàng_Bách___N22___Đề_số_01
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnExit = new System.Windows.Forms.MenuStrip();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.btnExit.Location = new System.Drawing.Point(0, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(464, 24);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = true;
            this.btnExit.Text = "menuStrip1";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(49, 20);
            this.Exit.Text = "Thoát";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee.Location = new System.Drawing.Point(12, 36);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(132, 87);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Quản lý nhân viên";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomer.Location = new System.Drawing.Point(167, 36);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(132, 87);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Quản lý khách hàng";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.ForeColor = System.Drawing.Color.Black;
            this.btnInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoice.Image")));
            this.btnInvoice.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInvoice.Location = new System.Drawing.Point(320, 36);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(132, 87);
            this.btnInvoice.TabIndex = 3;
            this.btnInvoice.Text = "Quản lý hoá đơn";
            this.btnInvoice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 133);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.btnExit;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Phần mềm quản lý chỉ số nước";
            this.btnExit.ResumeLayout(false);
            this.btnExit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip btnExit;
        private Button btnEmployee;
        private Button btnCustomer;
        private Button btnInvoice;
        private ToolStripMenuItem Exit;
    }
}