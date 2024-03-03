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
    public partial class Customer : Form
    {
        string SqlPath;
        Home home;
        Add_Customer add_cus;
        Edit_Customer edit_cus;
        Search_Customer search_cus;

        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adpt = null;
        DataTable dt = null;

        int SelectedID = -1;

        public Customer(Home home, string SqlPath)
        {
            InitializeComponent();
            this.home = home;
            this.SqlPath = SqlPath;
            this.conn = new SqlConnection(SqlPath);
            this.Display();
        }

        // GridView: Display()
        // Displays all available information of Customer Table in the database
        public void Display()
        {
            try
            {
                dt = new DataTable();

                conn.Open();
                cmd = new SqlCommand("Display_CusList", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                adpt = new SqlDataAdapter();
                adpt.SelectCommand = cmd;
                adpt.Fill(dt);

                CustomerList.DataSource = dt;

                conn.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err);
            }
        }

        // GridView: Select a cell 
        // Selects a data cell and returns its row index
        private void CustomerList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(CustomerList.Rows[e.RowIndex].Cells[0].Value.ToString()))
            {
                SelectedID = int.Parse(CustomerList.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        // Menu Button: Tìm kiếm
        // Pops up a search form and lets user fill in information
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            search_cus = new Search_Customer(this, this.SqlPath);
            search_cus.Show();
        }

        // Menu Button: Quay về trang chủ
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (home != null)
            {
                home.Visible = true;
            }
            else
            {
                home = new Home();
            }
            this.Close();
        }

        // Menu Button: Thoát
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Button: Thêm khách hàng
        private void btnAdd_Click(object sender, EventArgs e)
        {
            add_cus = new Add_Customer(this, this.SqlPath);
            add_cus.Show();
            Display();
        }

        // Button: Sửa khách hàng
        // Takes the Customer ID selected from the GridView to perfrom data
        // tuple modification in the database
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectedID > -1)
            {
                edit_cus = new Edit_Customer(this, this.SqlPath, this.SelectedID);
                edit_cus.Show();
                Display();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu để thực hiện chỉnh sửa");
            }
        }

        // Button: Xoá khách hàng
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.SelectedID > -1)
            {
                try
                {
                    conn.Open();

                    cmd = new SqlCommand("Remove_Customer", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = this.SelectedID;
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
        private void Customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.home.Visible = true;
        }
    }
}
