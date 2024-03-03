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
    public partial class Edit_Invoice : Form
    {
        Invoice inv = null;

        int SelectedID = -1;
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adpt = null;

        public Edit_Invoice(Invoice inv, string SqlPath, int SelectedID)
        {
            InitializeComponent();
            this.conn = new SqlConnection(SqlPath);
            this.SelectedID = SelectedID;
            this.inv = inv;
        }

        // Utility function
        // Fills textboxes with selected data tuple on load
        private void Edit_Invoice_Load(object sender, EventArgs e)
        {
            if (this.SelectedID > -1)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("Display_OneInv", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Inv_ID", SqlDbType.Int).Value = this.SelectedID;

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    tbID.Text = this.SelectedID.ToString();
                    dtpDate.Value = Convert.ToDateTime(dt.Rows[0][0].ToString());
                    tbAddress.Text = dt.Rows[0][1].ToString();
                    tbCus_Name.Text = dt.Rows[0][2].ToString();
                    tbCus_ID.Text = dt.Rows[0][3].ToString();
                    tbWaterUsage.Text = dt.Rows[0][4].ToString();
                    tbEmp_Name.Text = dt.Rows[0][6].ToString();
                    tbEmp_ID.Text = dt.Rows[0][7].ToString();

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
            tbWaterUsage.Text = "";
        }

        // Button: Cập nhật
        // Updates the specified data tuple with new values (except for Invoice Name and ID)
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();

            cmd = new SqlCommand("Edit_Invoice", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Inv_ID", SqlDbType.Int).Value = this.SelectedID;
            cmd.Parameters.AddWithValue("@Inv_Date", SqlDbType.Date).Value = dtpDate.Value.ToString("yyyy-MM-dd");
            cmd.Parameters.AddWithValue("@Inv_Address", SqlDbType.NVarChar).Value = tbAddress.Text;
            cmd.Parameters.AddWithValue("@Inv_WaterUsage", SqlDbType.Int).Value = tbWaterUsage.Text;
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Cập nhật thông tin hoá đơn thành công");

            this.inv.Display();
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
