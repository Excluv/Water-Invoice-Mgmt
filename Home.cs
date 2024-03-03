using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTN___Nguyễn_Hoàng_Bách___N22___Đề_số_01
{
    public partial class Home : Form
    {
        string SqlPath = "Data Source=DESKTOP-9RM7GQ5\\MSSQLSERVER01; Initial Catalog=QLNuoc; Integrated Security=True;";

        public Home()
        {
            InitializeComponent();
        }

        // Button: Quản lý nhân viên
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenNewForm("Employee");
        }

        // Button: Quản lý khách hàng
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenNewForm("Customer");
        }

        // Button: Quản lý hoá đơn
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            OpenNewForm("Invoice");
        }

        // Utility function
        // Creates a new form instance and opens up the corresponding window
        private void OpenNewForm(string form)
        {
            try
            {
                switch (form)
                {
                    case "Employee":
                        Employee emp = new Employee(this, SqlPath);
                        emp.Show();
                        break;
                    case "Customer":
                        Customer cus = new Customer(this, SqlPath);
                        cus.Show();
                        break;
                    case "Invoice":
                        Invoice inv = new Invoice(this, SqlPath);
                        inv.Show();
                        break;
                }
                this.Visible = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        // Menu Button: Thoát
        // Exits the application
        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        
    }
}
