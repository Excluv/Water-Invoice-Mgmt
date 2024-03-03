using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTN___Nguyễn_Hoàng_Bách___N22___Đề_số_01
{
    public partial class Add_Customer : Form
    {
        Customer cus;
        SqlConnection conn = null;
        SqlCommand cmd = null;

        public Add_Customer(Customer cus, string SqlPath)
        {
            InitializeComponent();
            this.conn = new SqlConnection(SqlPath);
            this.cus = cus;
        }

        // Button: Thêm
        // Adds an object to the database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbName.Text == null)
                {
                    MessageBox.Show("Vui lòng nhập họ & tên khách hàng");
                }
                else
                {
                    conn.Open();

                    cmd = new SqlCommand("Add_Customer", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Cus_Name", SqlDbType.NVarChar).Value = tbName.Text;
                    cmd.Parameters.AddWithValue("@Cus_Address", SqlDbType.NVarChar).Value = tbAddress.Text;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    Clear();

                    MessageBox.Show("Thêm thông tin khách hàng thành công");
                    this.cus.Display();
                    this.Close();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err);
            }
        }

        // Clears textboxes
        public void Clear()
        {
            tbName.Text = "";
            tbAddress.Text = "";
        }

        // Button: Huỷ
        // Clear the textboxes that have been filled
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        // Button: Quay về
        // Cancels the function and closes the form
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
