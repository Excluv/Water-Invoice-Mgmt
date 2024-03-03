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
    public partial class Search_Invoice_ByEmployee : Form
    {
        Invoice ParentForm = null;
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adpt = null;
        DataTable dt = null;

        public Search_Invoice_ByEmployee(Invoice ParentForm, string SqlPath)
        {
            InitializeComponent();
            this.conn = new SqlConnection(SqlPath);
            this.ParentForm = ParentForm;
        }

        // Button: Tìm kiếm
        // Searches the data by Customer Name
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand("Search_Invoice_ByEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Inv_IssuedBy", SqlDbType.NVarChar).Value = tbName.Text;

                dt = new DataTable();
                adpt = new SqlDataAdapter();
                adpt.SelectCommand = cmd;
                adpt.Fill(dt);

                this.ParentForm.InvoiceList.DataSource = dt;

                conn.Close();
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err);
            }
        }

        // Button: Huỷ
        // Cancels searching and closes the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbName.Text = "";
        }

        // Clears text box after searching
        public void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
