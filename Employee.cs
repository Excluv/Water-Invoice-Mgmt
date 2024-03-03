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
    public partial class Employee : Form
    {
        Home home;
        Add_Employee add_emp;
        Edit_Employee edit_emp;
        Search_Employee search_emp;

        string SqlPath;
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adpt = null;
        DataTable dt = null;

        int SelectedID = -1;

        public Employee(Home home, string SqlPath)
        {
            InitializeComponent();
            this.home = home;
            this.SqlPath = SqlPath;
            this.conn = new SqlConnection(SqlPath);
            this.Display();
        }

        // GridView: Display()
        // Displays all available information of Employee Table in the database
        public void Display()
        {
            try
            {
                dt = new DataTable();

                conn.Open();
                cmd = new SqlCommand("Display_EmpList", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                adpt = new SqlDataAdapter();
                adpt.SelectCommand = cmd;
                adpt.Fill(dt);

                EmployeeList.DataSource = dt;

                conn.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err);
            }
        }

        // GridView: Select a cell 
        // Selects a data cell and returns its row index
        private void EmployeeList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(EmployeeList.Rows[e.RowIndex].Cells[0].Value.ToString()))
            {
                SelectedID = int.Parse(EmployeeList.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        // Menu Button: Tìm kiếm
        // Pops up a search form and lets user fill in information, the information
        // is later extracted from the form instance stored in GridView
        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
            search_emp = new Search_Employee(this, this.SqlPath);
            search_emp.Show();
        }

        // Menu Button: Quay về trang chủ
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (home != null)
            {
                home.Visible = true;
            }
            else {
                home = new Home();
            }
            this.Close();
        }

        // Menu Button: Thoát
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Button: Thêm nhân viên
        private void btnAdd_Click(object sender, EventArgs e)
        {
            add_emp = new Add_Employee(this, this.SqlPath);
            add_emp.Show();
        }

        // Button: Sửa nhân viên
        // Modifies the data tuple by Employee ID selected from the GridView 
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectedID > -1)
            {
                edit_emp = new Edit_Employee(this, this.SqlPath, this.SelectedID);
                edit_emp.Show();
                Display();
            }
            else 
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu để thực hiện chỉnh sửa");
            }
        }

        // Button: Xoá nhân viên
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.SelectedID > -1)
            {
                try
                {
                    conn.Open();

                    cmd = new SqlCommand("Remove_Employee", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = this.SelectedID;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    Display();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu để xoá");
            }
        }

        // Utility function
        // Case user presses the red x button
        private void Employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.home.Visible = true;
        }
    }
}
