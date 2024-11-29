using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyLichHoc
{
    public partial class HocForm : Form
    {
        private string connectionString = @"Server=localhost;Database=QL_LichHoc;Trusted_Connection=True;";
        private UserSession userSession;

        public HocForm(UserSession session)
        {
            InitializeComponent();
            this.userSession = session;
            LoadHocData();
            LoadLichHocList();
        }

        private void HocForm_Load(object sender, EventArgs e)
        {
            if (userSession.Role != "Admin" && userSession.Role != "Teacher")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void LoadHocData()
        {
           
                string query = @"
            SELECT HOCSINH.MaHS, HOCSINH.HoTen, LICHHOC.Mon
            FROM HOC
            JOIN HOCSINH ON HOC.MaHS = HOCSINH.MaHS
            JOIN LICHHOC ON HOC.MaLichHoc = LICHHOC.MaLichHoc";


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvHoc.DataSource = dt;
                }
            }
           


        private void LoadLichHocList()
        {
            
                string query = "SELECT MaLichHoc, Mon FROM LICHHOC";  
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboMaMon.DataSource = dt;
                    cboMaMon.DisplayMember = "Mon";  
                    cboMaMon.ValueMember = "MaLichHoc";  
                }
            }
           



        private void btnAdd_Click(object sender, EventArgs e)
        {
            

           
                string maHS = txtMaHS.Text.Trim();
                string maLichHoc = cboMaMon.SelectedValue.ToString(); 

                string query = "INSERT INTO HOC (MaHS, MaLichHoc) VALUES (@MaHS, @MaLichHoc)";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHS", maHS);
                    cmd.Parameters.AddWithValue("@MaLichHoc", maLichHoc);  

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công.");
                    LoadHocData();
                }
            }
           

        private void txtMaHS_TextChanged(object sender, EventArgs e)
        {
            
                string maHS = txtMaHS.Text.Trim();
                if (!string.IsNullOrEmpty(maHS))
                {
                    string query = "SELECT HoTen FROM HOCSINH WHERE MaHS = @MaHS";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaHS", maHS);

                        conn.Open();
                        var result = cmd.ExecuteScalar();
                        txtHoTen.Text = result != null ? result.ToString() : "Không tìm thấy";
                    }
                }
                else
                {
                    txtHoTen.Clear();
                }
            }
           

        private void txtMaMon_TextChanged(object sender, EventArgs e)
        {
            
                string maLichHoc = txtMaMon.Text.Trim();
                if (!string.IsNullOrEmpty(maLichHoc))
                {
                    string query = "SELECT Mon FROM LICHHOC WHERE MaLichHoc = @MaLichHoc";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaLichHoc", maLichHoc);

                        conn.Open();
                        var result = cmd.ExecuteScalar();
                        txtTenMon.Text = result != null ? result.ToString() : "Không tìm thấy";
                    }
                }
                else
                {
                    txtTenMon.Clear();
                }
            }
            

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvHoc.SelectedRows.Count > 0)
            {
               
                    string maHS = dgvHoc.SelectedRows[0].Cells["MaHS"].Value.ToString();
                    string maLichHoc = dgvHoc.SelectedRows[0].Cells["MaLichHoc"].Value.ToString(); 


                    DialogResult dialogResult = MessageBox.Show(
                        $"Bạn có chắc muốn xóa dữ liệu của học sinh có mã {maHS} và mã lịch học {maLichHoc}?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (dialogResult == DialogResult.Yes)
                    {
                        string query = "DELETE FROM HOC WHERE MaHS = @MaHS AND MaLichHoc = @MaLichHoc";
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@MaHS", maHS);
                            cmd.Parameters.AddWithValue("@MaLichHoc", maLichHoc); 

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadHocData(); 
                        }
                    }
                }
                
            else
            {
                MessageBox.Show("Hãy chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            
                LoadHocData(); 
            }
    }
}
