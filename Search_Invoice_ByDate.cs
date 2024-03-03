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
    public partial class Search_Invoice_ByDate : Form
    {
        Invoice ParentForm = null;
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adpt = null;
        DataTable dt = null;

        public Search_Invoice_ByDate(Invoice ParentForm, string SqlPath)
        {
            InitializeComponent();
            this.conn = new SqlConnection(SqlPath);
            this.ParentForm = ParentForm;
        }

        // Button: Tìm kiếm
        // Searches the data tuple by Invoice Date and returns data to the GridView
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand("Search_Invoice_ByDate", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Inv_Date", SqlDbType.NVarChar).Value = dtpDate.Value.ToString("yyyy-MM-dd");

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

        // Closes the form
        public void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
