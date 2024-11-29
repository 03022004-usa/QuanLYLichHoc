using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyLichHoc
{
    public partial class QuanLyTaiKhoan : Form
    {
        private string connectionString = "Server=localhost;Database=QL_LichHoc;Trusted_Connection=True;";

        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TenDangNhap, MK, VaiTro FROM Users";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridViewUsers.DataSource = dataTable;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                string username = dataGridViewUsers.SelectedRows[0].Cells["TenDangNhap"].Value.ToString();
                string password = dataGridViewUsers.SelectedRows[0].Cells["MK"].Value.ToString();
                string role = dataGridViewUsers.SelectedRows[0].Cells["VaiTro"].Value.ToString();

                txtUsername.Text = username;
                txtPassword.Text = password;  
                txtRole.Text = role;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để chỉnh sửa.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string role = txtRole.Text;
            string password = txtPassword.Text; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET MK = @password, VaiTro = @role WHERE TenDangNhap = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                    command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;  
                    command.Parameters.Add("@role", SqlDbType.NVarChar).Value = role;

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thông tin tài khoản đã được cập nhật.");
                    LoadUsers(); 
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Users WHERE TenDangNhap = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Tài khoản đã được xóa.");
                    LoadUsers(); 
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = txtRole.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (TenDangNhap, MK, VaiTro) VALUES (@username, @password, @role)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                    command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
                    command.Parameters.Add("@role", SqlDbType.NVarChar).Value = role;

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Tài khoản đã được thêm.");
                    LoadUsers(); 
                }
            }
        }

       
    }
}
