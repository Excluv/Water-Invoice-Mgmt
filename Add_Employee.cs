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
    public partial class Add_Employee : Form
    {
        Employee emp;
        SqlConnection conn = null;
        SqlCommand cmd = null;

        public Add_Employee(Employee emp, string SqlPath)
        {
            InitializeComponent();
            this.conn = new SqlConnection(SqlPath);
            this.emp = emp;
        }

        // Button: Thêm
        // Adds an object to the database
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbName.Text == null)
                {
                    MessageBox.Show("Vui lòng nhập họ & tên nhân viên");
                }
                else 
                {
                    conn.Open();

                    cmd = new SqlCommand("Add_Employee", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Emp_Name", SqlDbType.NVarChar).Value = tbName.Text;
                    cmd.Parameters.AddWithValue("@Emp_DOB", SqlDbType.Date).Value = dtpDOB.Value.ToString("yyyy-MM-dd");
                    cmd.Parameters.AddWithValue("@Emp_Address", SqlDbType.NVarChar).Value = tbAddress.Text;
                    cmd.Parameters.AddWithValue("@Emp_PhoneNumber", SqlDbType.Int).Value = tbNumber.Text;
                    string gender = "";
                    if (rbMale.Checked)
                    {
                        gender = "Nam";
                    }
                    else if (rbFemale.Checked)
                    {
                        gender = "Nu";
                    }
                    cmd.Parameters.AddWithValue("@Emp_Gender", SqlDbType.NVarChar).Value = gender;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    Clear();

                    MessageBox.Show("Thêm thông tin nhân viên thành công");
                    this.emp.Display();
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
            tbNumber.Text = "";
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
