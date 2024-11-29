using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyLichHoc
{
    public partial class TrangDangNhap : Form
    {
        private string connectionString = "Server=localhost;Database=QL_LichHoc;Trusted_Connection=True;";

        public TrangDangNhap()
        {
            InitializeComponent();

            if (this.btnExit != null)
            {
                this.btnExit.Click += new EventHandler(this.btnExit_Click);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    bool isEmail = username.Contains("@");

                    string query;
                    string maHS = null;
                    string email = null;

                    if (isEmail)
                    {
                        query = @"
                    SELECT HOCSINH.MaHS, Users.VaiTro, Users.TenDangNhap 
                    FROM Users 
                    JOIN HocSinh ON Users.TenDangNhap = HocSinh.Email 
                    WHERE Users.TenDangNhap = @username AND Users.MK = @password";
                    }
                    else
                    {
                        query = @"
                    SELECT Users.VaiTro 
                    FROM Users 
                    WHERE Users.TenDangNhap = @username AND Users.MK = @password";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                        command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string role = reader["VaiTro"].ToString();  

                            if (isEmail)
                            {
                                maHS = reader["MaHS"].ToString();  
                                email = reader["TenDangNhap"].ToString();  
                            }

                            UserSession userSession = new UserSession(username, role, email, maHS);

                            this.Hide(); 

                            if (role == "Admin")
                            {
                                AdminForm adminForm = new AdminForm(userSession);

                                adminForm.FormClosed += (s, args) => this.Show();

                                adminForm.Show();
                            }
                            else if (role == "Teacher")
                            {
                                TrangChu homeForm = new TrangChu(userSession);
                                homeForm.FormClosed += (s, args) => this.Show();
                                homeForm.Show();
                            }
                            else
                            {
                                TrangChu homeForm = new TrangChu(userSession);
                                homeForm.FormClosed += (s, args) => this.Show();
                                homeForm.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Đăng nhập thất bại",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
           
        private void TrangDangNhap_Load(object sender, EventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
