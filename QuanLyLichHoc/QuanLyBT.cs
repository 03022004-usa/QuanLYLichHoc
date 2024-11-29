using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace QuanLyLichHoc
{
    public partial class QuanLyBT : Form
    {
        private string connectionString = @"Server=localhost;Database=QL_LichHoc;Trusted_Connection=True;";
        private UserSession userSession;


        public QuanLyBT(UserSession session)
        {
            InitializeComponent();
            this.userSession = session; 
            PhanQuyen();
        }

        private void PhanQuyen()
        {
            if (userSession.Role == "Teacher" || userSession.Role == "Admin")
            {
                btnAdd.Visible = true;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                btnConfirmCompletion.Visible    = false;
            }
            else if (userSession.Role == "Student")
            {
                btnAdd.Visible = false;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                btnConfirmCompletion.Visible = true;  
            }
            else
            {
                btnAdd.Visible = false;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                btnConfirmCompletion.Visible = false;
            }
        }


        private void LoadData()
        {
 
            if (userSession.Role == "Student" && string.IsNullOrEmpty(userSession.MaHS))
            {
                MessageBox.Show("Mã học sinh không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

 
            string query = @"
        SELECT 
            BT.MaBaiTap, BT.TenBT, BT.MoTa, BT.NgayDuocGiao, BT.HanNop,
            CASE 
            WHEN EXISTS (
           SELECT 1 
          FROM LAMVANOPBAITAP L
          WHERE L.MaBaiTap = BT.MaBaiTap 
          AND (@MaHS IS NULL OR L.MaHS = @MaHS)
             ) THEN N'Đã hoàn thành'
              ELSE N'Chưa hoàn thành'
             END AS TrangThai
        FROM BAITAP BT";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);


                if (userSession.Role == "Student")
                {
                    cmd.Parameters.AddWithValue("@MaHS", userSession.MaHS);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@MaHS", DBNull.Value); 
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBaiTap.DataSource = dt;

                 if (userSession.Role == "Teacher" || userSession.Role == "Admin")
                {
                    dgvBaiTap.Columns["TrangThai"].Visible = false;
                }
                else
                {
                    dgvBaiTap.Columns["TrangThai"].Visible = true;
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maBaiTap = txtMaBaiTap.Text;
            string tenBT = txtTenBT.Text;
            string moTa = txtMoTa.Text;
            DateTime ngayDuocGiao = dtpNgayDuocGiao.Value;
            DateTime hanNop = dtpHanNop.Value;

            if (string.IsNullOrEmpty(maBaiTap) || string.IsNullOrEmpty(tenBT) || string.IsNullOrEmpty(moTa))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bài tập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            string trangThai = "Chưa hoàn thành";

            string checkQuery = "SELECT COUNT(*) FROM BaiTap WHERE MaBaiTap = @MaBaiTap";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MaBaiTap", maBaiTap);

                conn.Open();
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Mã bài tập đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                string insertQuery = @"
            INSERT INTO BaiTap (MaBaiTap, TenBT, MoTa, NgayDuocGiao, HanNop, TrangThai) 
            VALUES (@MaBaiTap, @TenBT, @MoTa, @NgayDuocGiao, @HanNop, @TrangThai)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@MaBaiTap", maBaiTap);
                insertCmd.Parameters.AddWithValue("@TenBT", tenBT);
                insertCmd.Parameters.AddWithValue("@MoTa", moTa);
                insertCmd.Parameters.AddWithValue("@NgayDuocGiao", ngayDuocGiao);
                insertCmd.Parameters.AddWithValue("@HanNop", hanNop);
                insertCmd.Parameters.AddWithValue("@TrangThai", trangThai);

                insertCmd.ExecuteNonQuery();
                MessageBox.Show("Bài tập đã được thêm thành công.");
                LoadData();
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBaiTap.SelectedRows.Count > 0)
            {
                string maBaiTap = dgvBaiTap.SelectedRows[0].Cells["MaBaiTap"].Value.ToString();
                string tenBT = txtTenBT.Text;
                string moTa = txtMoTa.Text;
                DateTime ngayDuocGiao = dtpNgayDuocGiao.Value;
                DateTime hanNop = dtpHanNop.Value;

                string query = @"
                    UPDATE BaiTap 
                    SET TenBT = @TenBT, MoTa = @MoTa, NgayDuocGiao = @NgayDuocGiao, HanNop = @HanNop 
                    WHERE MaBaiTap = @MaBaiTap";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaBaiTap", maBaiTap);
                    cmd.Parameters.AddWithValue("@TenBT", tenBT);
                    cmd.Parameters.AddWithValue("@MoTa", moTa);
                    cmd.Parameters.AddWithValue("@NgayDuocGiao", ngayDuocGiao);
                    cmd.Parameters.AddWithValue("@HanNop", hanNop);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Bài tập đã được sửa thành công.");
                LoadData();
            }
            else
            {
                MessageBox.Show("Hãy chọn một dòng để sửa.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBaiTap.SelectedRows.Count > 0)
            {
                string maBaiTap = dgvBaiTap.SelectedRows[0].Cells["MaBaiTap"].Value.ToString();

                
                string deleteRelationQuery = "DELETE FROM LAMVANOPBAITAP WHERE MaBaiTap = @MaBaiTap";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmdDeleteRelation = new SqlCommand(deleteRelationQuery, conn);
                    cmdDeleteRelation.Parameters.AddWithValue("@MaBaiTap", maBaiTap);
                    conn.Open();
                    cmdDeleteRelation.ExecuteNonQuery();
                }

                
                string deleteQuery = "DELETE FROM BaiTap WHERE MaBaiTap = @MaBaiTap";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmdDelete = new SqlCommand(deleteQuery, conn);
                    cmdDelete.Parameters.AddWithValue("@MaBaiTap", maBaiTap);
                    conn.Open();
                    cmdDelete.ExecuteNonQuery();
                }

                MessageBox.Show("Bài tập đã được xóa.");
                LoadData();
            }
            else
            {
                MessageBox.Show("Hãy chọn một dòng để xóa.");
            }
        }
        private string GetStudentId(string email)
        {
            string query = "SELECT MaHS FROM HOCSINH WHERE Email = @Email";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);  

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : null;
            }
        }



        private void btnConfirmCompletion_Click(object sender, EventArgs e)
        {
            if (dgvBaiTap.SelectedRows.Count > 0)
            {
                string maBaiTap = dgvBaiTap.SelectedRows[0].Cells["MaBaiTap"].Value.ToString();

 
                string queryInsert = @"
            IF NOT EXISTS (SELECT 1 FROM LAMVANOPBAITAP WHERE MaHS = @MaHS AND MaBaiTap = @MaBaiTap)
            BEGIN
                -- Nếu chưa có bản ghi, thêm mới bản ghi cho học sinh hoàn thành bài tập
                INSERT INTO LAMVANOPBAITAP (MaHS, MaBaiTap)
                VALUES (@MaHS, @MaBaiTap)
            END";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(queryInsert, conn);
                    cmd.Parameters.AddWithValue("@MaHS", userSession.MaHS);
                    cmd.Parameters.AddWithValue("@MaBaiTap", maBaiTap);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Bài tập đã được xác nhận hoàn thành.");
                LoadData();  
            }
            else
            {
                MessageBox.Show("Hãy chọn một bài tập.");
            }
        }

        private void QuanLyBT_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
