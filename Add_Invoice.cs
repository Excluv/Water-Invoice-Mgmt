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
    public partial class Add_Invoice : Form
    {
        Invoice inv;
        SqlConnection conn = null;
        SqlCommand cmd = null;

        public Add_Invoice(Invoice inv, string SqlPath)
        {
            InitializeComponent();
            this.conn = new SqlConnection(SqlPath);
            this.inv = inv;
        }

        // Utility function
        // Clears textboxes
        public void Clear()
        {
            tbWaterUsage.Text = "";
            tbAddress.Text = "";
            tbCus_Name.Text = "";
            tbCus_ID.Text = "";
            tbEmp_Name.Text = "";
            tbEmp_ID.Text = "";
        }

        // Button: Thêm
        // Adds an object to the database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((tbCus_Name == null) || (tbCus_ID == null))
                {
                    MessageBox.Show("Các trường thông tin về khách hàng không được bỏ trống!");
                }
                else if ((tbEmp_Name == null) || (tbEmp_ID == null))
                {
                    MessageBox.Show("Các trường thông tin về nhân viên lập hoá đơn không được bỏ trống!");
                }
                else
                {
                    conn.Open();

                    // Checks whether the data given by users violate any constraints of the table
                    List<string> procedures = new List<string> { "Customer_Check", "Employee_Check" };
                    foreach (string procedure in procedures)
                    {
                        SqlCommand check = new SqlCommand(procedure, conn);
                        check.CommandType = CommandType.StoredProcedure;

                        if (procedure == "Customer_Check")
                        {
                            check.Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = tbCus_ID.Text;
                            check.Parameters.AddWithValue("@Cus_Name", SqlDbType.NVarChar).Value = tbCus_Name.Text;
                        }
                        else
                        {
                            check.Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = tbEmp_ID.Text;
                            check.Parameters.AddWithValue("@Emp_Name", SqlDbType.NVarChar).Value = tbEmp_Name.Text;
                        }
                        SqlDataReader rdr = check.ExecuteReader();

                        // If they do, raises alert and closes the form
                        if (!rdr.Read())
                        {
                            List<string> alerts = new List<string> { "Không tồn tại khách hàng này trong CSDL", "Không tồn tại nhân viên này trong CSDL" };
                            MessageBox.Show((procedure == "Customer_Check") ? alerts[0] : alerts[1]);
                            conn.Close();
                            this.Close();
                            break;
                        }
                        rdr.Close();
                    }

                    // Else, proceed to add the data tuple into the table
                    if (conn.State == ConnectionState.Open)
                    {
                        cmd = new SqlCommand("Add_Invoice", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Inv_Date", SqlDbType.Date).Value = dtpDate.Value.ToString("yyyy-MM-dd");
                        cmd.Parameters.AddWithValue("@Inv_Address", SqlDbType.NVarChar).Value = tbAddress.Text;
                        cmd.Parameters.AddWithValue("@Cus_Name", SqlDbType.NVarChar).Value = tbCus_Name.Text;
                        cmd.Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = tbCus_ID.Text;
                        cmd.Parameters.AddWithValue("@Inv_IssuedBy", SqlDbType.NVarChar).Value = tbEmp_Name.Text;
                        cmd.Parameters.AddWithValue("@Inv_EmpID", SqlDbType.Int).Value = tbEmp_ID.Text;
                        cmd.Parameters.AddWithValue("@Inv_WaterUsage", SqlDbType.Int).Value = tbWaterUsage.Text;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Thêm thông tin hoá đơn thành công");

                        conn.Close();
                        this.inv.Display();
                        this.Close();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: \n" + err);
            }
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
