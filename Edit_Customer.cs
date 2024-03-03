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
    public partial class Edit_Customer : Form
    {
        Customer cus = null;

        int SelectedID = -1;
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adpt = null;

        public Edit_Customer(Customer cus, string SqlPath, int SelectedID)
        {
            InitializeComponent();
            this.conn = new SqlConnection(SqlPath);
            this.SelectedID = SelectedID;
            this.cus = cus;
        }

        // Utility function
        // Fills textboxes with selected data tuple on load
        private void Edit_Customer_Load(object sender, EventArgs e)
        {
            if (this.SelectedID > -1)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("Display_OneCus", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = this.SelectedID;

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    tbID.Text = this.SelectedID.ToString();
                    tbName.Text = dt.Rows[0][0].ToString();
                    tbAddress.Text = dt.Rows[0][1].ToString();

                    conn.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu để sửa");
            }
        }

        // Utility function
        // Clears textboxes
        public void Clear()
        {
            tbAddress.Text = "";
        }

        // Button: Cập nhật
        // Updates the specified data tuple with new values (except for Customer Name and ID)
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();

            cmd = new SqlCommand("Edit_Customer", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = this.SelectedID;
            cmd.Parameters.AddWithValue("@Cus_Address", SqlDbType.NVarChar).Value = tbAddress.Text;
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Cập nhật thông tin khách hàng thành công");

            this.cus.Display();
            this.Close();
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
