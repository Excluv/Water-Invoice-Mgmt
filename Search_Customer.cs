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
    public partial class Search_Customer : Form
    {
        Customer ParentForm = null;
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adpt = null;
        DataTable dt = null;

        public Search_Customer(Customer ParentForm, string SqlPath)
        {
            InitializeComponent();
            this.conn = new SqlConnection(SqlPath);
            this.ParentForm = ParentForm;
        }

        // Button: Tìm kiếm
        // Searches the data row by Customer Name and returns 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                cmd = new SqlCommand("Search_Customer", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cus_Name", SqlDbType.NVarChar).Value = tbName.Text;

                dt = new DataTable();
                adpt = new SqlDataAdapter();
                adpt.SelectCommand = cmd;
                adpt.Fill(dt);

                this.ParentForm.CustomerList.DataSource = dt;

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
