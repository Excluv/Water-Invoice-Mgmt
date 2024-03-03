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
    public partial class Invoice : Form
    {
        string SqlPath;
        Home home;
        Add_Invoice add_inv;
        Edit_Invoice edit_inv;
        Search_Invoice_ByDate search_inv_bd;
        Search_Invoice_ByEmployee search_inv_be;
        Search_Invoice_ByCustomer search_inv_bc;

        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter adpt = null;
        DataTable dt = null;

        int SelectedID = -1;

        public Invoice(Home home, string SqlPath)
        {
            InitializeComponent();
            this.home = home;
            this.SqlPath = SqlPath;
            this.conn = new SqlConnection(SqlPath);
            this.Display();
        }

        // GridView: Display()
        // Displays all available information of Invoice Table in the database
        public void Display()
        {
            try
            {
                dt = new DataTable();

                conn.Open();
                cmd = new SqlCommand("Display_InvList", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                adpt = new SqlDataAdapter();
                adpt.SelectCommand = cmd;
                adpt.Fill(dt);

                InvoiceList.DataSource = dt;

                conn.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err);
            }
        }

        // GridView: Select a cell 
        // Selects a data cell and returns its row index
        private void InvoiceList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(InvoiceList.Rows[e.RowIndex].Cells[0].Value.ToString()))
            {
                SelectedID = int.Parse(InvoiceList.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
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

        // Menu Item: Tìm HĐ theo ngày lập
        private void itemDate_Click(object sender, EventArgs e)
        {
            search_inv_bd = new Search_Invoice_ByDate(this, this.SqlPath);
            search_inv_bd.Show();
        }

        // Menu Item: Tìm HĐ theo người lập
        private void itemEmp_Name_Click(object sender, EventArgs e)
        {
            search_inv_be = new Search_Invoice_ByEmployee(this, this.SqlPath);
            search_inv_be.Show();
        }

        // Menu Item: Tìm HĐ theo tên KH
        private void itemCus_Name_Click(object sender, EventArgs e)
        {
            search_inv_bc = new Search_Invoice_ByCustomer(this, this.SqlPath);
            search_inv_bc.Show();
        }

        // Button: Thêm hoá đơn
        private void btnAdd_Click(object sender, EventArgs e)
        {
            add_inv = new Add_Invoice(this, this.SqlPath);
            add_inv.Show();
            Display();
        }

        // Button: Sửa hoá đơn
        // Takes the Invoice ID selected from the GridView to perfrom data
        // tuple modification in the database
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectedID > -1)
            {
                edit_inv = new Edit_Invoice(this, this.SqlPath, this.SelectedID);
                edit_inv.Show();
                Display();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu để thực hiện chỉnh sửa");
            }
        }

        // Button: Xoá hoá đơn
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.SelectedID > -1)
            {
                try
                {
                    conn.Open();

                    cmd = new SqlCommand("Remove_Invoice", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Inv_ID", SqlDbType.Int).Value = this.SelectedID;
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

        // Button: In hoá đơn
        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            
        }

        // Utility function
        // Case user presses the red x button
        private void Invoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.home.Visible = true;
        }

        
    }
}
