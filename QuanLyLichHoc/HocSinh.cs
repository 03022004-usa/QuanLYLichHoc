using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyLichHoc
{
    public partial class HocSinh : Form
    {
        private string connectionString = @"Server=localhost;Database=QL_LichHoc;Trusted_Connection=True;";
        private UserSession userSession;

        public HocSinh(UserSession session)
        {
            InitializeComponent();
            this.userSession = session; 


             btnAdd.Enabled = userSession.Role == "Teacher" ;
            btnEdit.Enabled = userSession.Role == "Teacher" ;
            btnDelete.Enabled = userSession.Role == "Teacher";

            LoadData();
        }

         private void LoadData()
        {
            string query = "SELECT * FROM HOCSINH";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHocSinh.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
                 if (string.IsNullOrWhiteSpace(txtMaHS.Text) ||
                    string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                    string.IsNullOrWhiteSpace(txtGioiTinh.Text) ||
                    string.IsNullOrWhiteSpace(txtNoiSinh.Text) ||
                    string.IsNullOrWhiteSpace(txtTrangThai.Text) ||
                    string.IsNullOrWhiteSpace(txtNghi.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtLop.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin vào tất cả các ô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;  
                }

                 if (!int.TryParse(txtMaHS.Text, out _))
                {
                    MessageBox.Show("Mã học sinh phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                 if (!int.TryParse(txtLop.Text, out _))
                {
                    MessageBox.Show("Lớp học phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                 if (!int.TryParse(txtNghi.Text, out _))
                {
                    MessageBox.Show("Thông tin nghỉ lớp phải là số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                 string lop = txtLop.Text;
                string email = txtEmail.Text;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                     string checkClassQuery = "SELECT COUNT(*) FROM LOPHOC WHERE MaLop = @MaLop";
                    using (SqlCommand checkClassCmd = new SqlCommand(checkClassQuery, conn))
                    {
                        checkClassCmd.Parameters.AddWithValue("@MaLop", lop);
                        int classExists = (int)checkClassCmd.ExecuteScalar();

                        if (classExists == 0)
                        {
                             string insertClassQuery = @"
                    INSERT INTO LOPHOC (MaLop, TenLop, PhongHoc) 
                    VALUES (@MaLop, @TenLop, @PhongHoc)";
                            using (SqlCommand insertClassCmd = new SqlCommand(insertClassQuery, conn))
                            {
                                insertClassCmd.Parameters.AddWithValue("@MaLop", lop);
                                insertClassCmd.Parameters.AddWithValue("@TenLop", lop);
                                insertClassCmd.Parameters.AddWithValue("@PhongHoc", lop);
                                insertClassCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    string checkEmailQuery = "SELECT COUNT(*) FROM USERS WHERE TenDangNhap = @TenDangNhap";
                    using (SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, conn))
                    {
                        checkEmailCmd.Parameters.AddWithValue("@TenDangNhap", email);
                        int emailExists = (int)checkEmailCmd.ExecuteScalar();

                        if (emailExists > 0)
                        {
                            MessageBox.Show("Email này đã được đăng ký. Vui lòng sử dụng email khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;  
                        }
                    }

                     string insertStudentQuery = @"
            INSERT INTO HOCSINH (MaHS, HoTen, GioiTinh, NoiSinh, TrangThai, Nghi, Email, Lop) 
            VALUES (@MaHS, @HoTen, @GioiTinh, @NoiSinh, @TrangThai, @Nghi, @Email, @Lop)";
                    using (SqlCommand insertStudentCmd = new SqlCommand(insertStudentQuery, conn))
                    {
                        insertStudentCmd.Parameters.AddWithValue("@MaHS", txtMaHS.Text);
                        insertStudentCmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                        insertStudentCmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                        insertStudentCmd.Parameters.AddWithValue("@NoiSinh", txtNoiSinh.Text);
                        insertStudentCmd.Parameters.AddWithValue("@TrangThai", txtTrangThai.Text);
                        insertStudentCmd.Parameters.AddWithValue("@Nghi", txtNghi.Text);
                        insertStudentCmd.Parameters.AddWithValue("@Email", email);
                        insertStudentCmd.Parameters.AddWithValue("@Lop", lop);
                        insertStudentCmd.ExecuteNonQuery();
                    }

                     string insertUserQuery = @"INSERT INTO USERS (TenDangNhap, MK, VaiTro)  VALUES (@TenDangNhap, @MK, @VaiTro)";
                    using (SqlCommand insertUserCmd = new SqlCommand(insertUserQuery, conn))
                    {
                        insertUserCmd.Parameters.AddWithValue("@TenDangNhap", email);
                        insertUserCmd.Parameters.AddWithValue("@MK", "123");  
                        insertUserCmd.Parameters.AddWithValue("@VaiTro", "Student"); 
                        insertUserCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm học sinh và tài khoản thành công!");
                LoadData();
            }
            




        private void btnEdit_Click(object sender, EventArgs e)
{
    if (dgvHocSinh.SelectedRows.Count > 0)
    {
        string maHS = dgvHocSinh.SelectedRows[0].Cells["MaHS"].Value.ToString();


        if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
            string.IsNullOrWhiteSpace(txtGioiTinh.Text) ||
            string.IsNullOrWhiteSpace(txtNoiSinh.Text) ||
            string.IsNullOrWhiteSpace(txtTrangThai.Text) ||
            string.IsNullOrWhiteSpace(txtNghi.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text) ||
            string.IsNullOrWhiteSpace(txtLop.Text))
        {
            MessageBox.Show("Vui lòng điền đầy đủ thông tin vào tất cả các ô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;  
        }

        
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();


                string checkClassQuery = "SELECT COUNT(*) FROM LOPHOC WHERE MaLop = @MaLop";
                using (SqlCommand checkClassCmd = new SqlCommand(checkClassQuery, conn))
                {
                    checkClassCmd.Parameters.AddWithValue("@MaLop", txtLop.Text);
                    int classExists = (int)checkClassCmd.ExecuteScalar();

                    if (classExists == 0)
                    {

                        string insertClassQuery = @"
                        INSERT INTO LOPHOC (MaLop, TenLop, PhongHoc) 
                        VALUES (@MaLop, @TenLop, @PhongHoc)";
                        using (SqlCommand insertClassCmd = new SqlCommand(insertClassQuery, conn))
                        {
                            insertClassCmd.Parameters.AddWithValue("@MaLop", txtLop.Text);
                            insertClassCmd.Parameters.AddWithValue("@TenLop", txtLop.Text);
                            insertClassCmd.Parameters.AddWithValue("@PhongHoc", txtLop.Text);
                            insertClassCmd.ExecuteNonQuery();
                        }
                    }
                }


                string updateQuery = @"UPDATE HOCSINH  
                                       SET HoTen = @HoTen, GioiTinh = @GioiTinh, NoiSinh = @NoiSinh,  TrangThai = @TrangThai, Nghi = @Nghi, Email = @Email, Lop = @Lop 
                                       WHERE MaHS = @MaHS";

                using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                {
                    updateCmd.Parameters.AddWithValue("@MaHS", maHS);
                    updateCmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                    updateCmd.Parameters.AddWithValue("@GioiTinh", txtGioiTinh.Text);
                    updateCmd.Parameters.AddWithValue("@NoiSinh", txtNoiSinh.Text);
                    updateCmd.Parameters.AddWithValue("@TrangThai", txtTrangThai.Text);
                    updateCmd.Parameters.AddWithValue("@Nghi", txtNghi.Text);
                    updateCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    updateCmd.Parameters.AddWithValue("@Lop", txtLop.Text);

                    updateCmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cập nhật thông tin học sinh thành công!");
            LoadData();
        }
        
    else
    {
        MessageBox.Show("Hãy chọn một học sinh để sửa!");
    }
}



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvHocSinh.SelectedRows.Count > 0)
            {

                string maHS = dgvHocSinh.SelectedRows[0].Cells["MaHS"].Value.ToString();
                string email = dgvHocSinh.SelectedRows[0].Cells["Email"].Value.ToString();  

               
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();


                        string deleteGradesQuery = "DELETE FROM HOC WHERE MaHS = @MaHS";
                        using (SqlCommand deleteGradesCmd = new SqlCommand(deleteGradesQuery, conn))
                        {
                            deleteGradesCmd.Parameters.AddWithValue("@MaHS", maHS);
                            deleteGradesCmd.ExecuteNonQuery();
                        }

                        string deleteAssignmentsQuery = "DELETE FROM LAMVANOPBAITAP WHERE MaHS = @MaHS";
                        using (SqlCommand deleteAssignmentsCmd = new SqlCommand(deleteAssignmentsQuery, conn))
                        {
                            deleteAssignmentsCmd.Parameters.AddWithValue("@MaHS", maHS);
                            deleteAssignmentsCmd.ExecuteNonQuery();
                        }


                        string deleteStudentQuery = "DELETE FROM HOCSINH WHERE MaHS = @MaHS";
                        SqlCommand deleteStudentCmd = new SqlCommand(deleteStudentQuery, conn);
                        deleteStudentCmd.Parameters.AddWithValue("@MaHS", maHS);
                        deleteStudentCmd.ExecuteNonQuery();


                        string deleteUserQuery = "DELETE FROM USERS WHERE TenDangNhap = @TenDangNhap";
                        using (SqlCommand deleteUserCmd = new SqlCommand(deleteUserQuery, conn))
                        {
                            deleteUserCmd.Parameters.AddWithValue("@TenDangNhap", email);
                            deleteUserCmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Xóa học sinh và tài khoản thành công!");
                    LoadData();
                }
                
            else
            {
                MessageBox.Show("Hãy chọn một học sinh để xóa!");
            }
        }

        private void btnQuanLyBaiTap_Click(object sender, EventArgs e)
        {

            string maHS = txtMaHS.Text;  

            if (string.IsNullOrEmpty(maHS))
            {
                MessageBox.Show("Mã học sinh không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QuanLyBT quanLyBTForm = new QuanLyBT(userSession);
            quanLyBTForm.Show();
        }
    }
}
