using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyLichHoc
{
    public partial class LamVaNop : Form
    {
        private string connectionString = @"Server=localhost;Database=QL_LichHoc;Trusted_Connection=True;";
        private UserSession userSession;  

        public LamVaNop(UserSession session)
        {
            InitializeComponent();
            this.userSession = session;  
            LoadLamVaNopData();
        }

        private void LamVaNop_Load(object sender, EventArgs e)
        {
 
            if (userSession.Role != "Teacher")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
        }

        private void LoadLamVaNopData()
        {
            string query = @"
    SELECT HS.HoTen, BT.TenBT
    FROM LAMVANOPBAITAP L
    JOIN HOCSINH HS ON L.MaHS = HS.MaHS
    JOIN BAITAP BT ON L.MaBaiTap = BT.MaBaiTap"; 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvLamVaNop.DataSource = dt; 
                }
               
        }



         private void btnDelete_Click(object sender, EventArgs e)
        {
            if (userSession.Role != "Teacher")
            {
                MessageBox.Show("Chỉ giáo viên mới có quyền thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvLamVaNop.SelectedRows.Count > 0)
            {
                string maHS = dgvLamVaNop.SelectedRows[0].Cells["MaHS"].Value.ToString();
                string maBaiTap = dgvLamVaNop.SelectedRows[0].Cells["MaBaiTap"].Value.ToString();

                string query = "DELETE FROM LAMVANOPBAITAP WHERE MaHS = @MaHS AND MaBaiTap = @MaBaiTap";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaHS", maHS);
                        cmd.Parameters.AddWithValue("@MaBaiTap", maBaiTap);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa bài tập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadLamVaNopData(); 
                    }
                    
            }
            else
            {
                MessageBox.Show("Hãy chọn một bài tập để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadLamVaNopData();
        }

    }
}
