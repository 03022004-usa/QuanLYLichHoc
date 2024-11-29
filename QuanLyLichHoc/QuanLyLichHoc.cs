using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyLichHoc
{
    public partial class QuanLyLichHoc : Form
    {
        private string connectionString = @"Server=localhost;Database=QL_LichHoc;Trusted_Connection=True;";
        private UserSession userSession;
        private bool HoatDong = false;

        public QuanLyLichHoc(UserSession session)
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
            }
            else if (userSession.Role == "Student")
            {
                btnAdd.Visible = false;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
            else
            {
                btnAdd.Visible = false;
                btnEdit.Enabled = false;
                btnDelete.Visible = false;
            }
        }

        private void LoadData()
        {
            string query = "SELECT MaLichHoc, TuanHoc, NamHoc, ThoiGianBatDau, ThoiGianKetThuc, PhongHoc, Mon FROM LichHoc";
            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvLichHoc.DataSource = dt;
        }



      
        private void cboThuocTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProperty = cboThuocTinh.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedProperty))
            {
                 LoadValuesForProperty(selectedProperty);
            }
            else
            {
                cboGiaTri.Items.Clear();  
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLichHoc.Text) ||
        string.IsNullOrWhiteSpace(txtTuanHoc.Text) ||
        string.IsNullOrWhiteSpace(txtNamHoc.Text) ||
        string.IsNullOrWhiteSpace(txtPhongHoc.Text) ||
        string.IsNullOrWhiteSpace(txtMon.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi thêm lịch học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpThoiGianBatDau.Value >= dtpThoiGianKetThuc.Value)
            {
                MessageBox.Show("Thời gian bắt đầu phải trước thời gian kết thúc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maLichHoc = txtMaLichHoc.Text;
            string tuanHoc = txtTuanHoc.Text;
            string namHoc = txtNamHoc.Text;
            DateTime thoiGianBatDau = dtpThoiGianBatDau.Value;
            DateTime thoiGianKetThuc = dtpThoiGianKetThuc.Value;
            string phongHoc = txtPhongHoc.Text;
            string mon = txtMon.Text;

            string checkQuery = "SELECT COUNT(*) FROM LichHoc WHERE MaLichHoc = @MaLichHoc";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MaLichHoc", maLichHoc);

                conn.Open();
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Mã lịch học đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string insertQuery = "INSERT INTO LichHoc (MaLichHoc, TuanHoc, NamHoc, ThoiGianBatDau, ThoiGianKetThuc, PhongHoc, Mon) " +
                                     "VALUES (@MaLichHoc, @TuanHoc, @NamHoc, @ThoiGianBatDau, @ThoiGianKetThuc, @PhongHoc, @Mon)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@MaLichHoc", maLichHoc);
                insertCmd.Parameters.AddWithValue("@TuanHoc", tuanHoc);
                insertCmd.Parameters.AddWithValue("@NamHoc", namHoc);
                insertCmd.Parameters.AddWithValue("@ThoiGianBatDau", thoiGianBatDau);
                insertCmd.Parameters.AddWithValue("@ThoiGianKetThuc", thoiGianKetThuc);
                insertCmd.Parameters.AddWithValue("@PhongHoc", phongHoc);
                insertCmd.Parameters.AddWithValue("@Mon", mon);

                insertCmd.ExecuteNonQuery();
                MessageBox.Show("Lịch học đã được thêm thành công.");
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvLichHoc.SelectedRows.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(txtMaLichHoc.Text) ||
        string.IsNullOrWhiteSpace(txtTuanHoc.Text) ||
        string.IsNullOrWhiteSpace(txtNamHoc.Text) ||
        string.IsNullOrWhiteSpace(txtPhongHoc.Text) ||
        string.IsNullOrWhiteSpace(txtMon.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi sửa lịch học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string maLichHoc = dgvLichHoc.SelectedRows[0].Cells["MaLichHoc"].Value.ToString();

                string tuanHoc = txtTuanHoc.Text;
                string namHoc = txtNamHoc.Text;
                DateTime thoiGianBatDau = dtpThoiGianBatDau.Value;
                DateTime thoiGianKetThuc = dtpThoiGianKetThuc.Value;
                string phongHoc = txtPhongHoc.Text;
                string mon = txtMon.Text;

                string query = "UPDATE LichHoc SET TuanHoc = @TuanHoc, NamHoc = @NamHoc, ThoiGianBatDau = @ThoiGianBatDau, " +
                               "ThoiGianKetThuc = @ThoiGianKetThuc, PhongHoc = @PhongHoc, Mon = @Mon WHERE MaLichHoc = @MaLichHoc";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaLichHoc", maLichHoc);
                    cmd.Parameters.AddWithValue("@TuanHoc", tuanHoc);
                    cmd.Parameters.AddWithValue("@NamHoc", namHoc);
                    cmd.Parameters.AddWithValue("@ThoiGianBatDau", thoiGianBatDau);
                    cmd.Parameters.AddWithValue("@ThoiGianKetThuc", thoiGianKetThuc);
                    cmd.Parameters.AddWithValue("@PhongHoc", phongHoc);
                    cmd.Parameters.AddWithValue("@Mon", mon);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Lịch học đã được sửa thành công.");
                LoadData();
            }
            else
            {
                MessageBox.Show("Hãy chọn một dòng để sửa.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLichHoc.SelectedRows.Count > 0)
            {
                string maLichHoc = dgvLichHoc.SelectedRows[0].Cells["MaLichHoc"].Value.ToString();

                string query = "DELETE FROM LichHoc WHERE MaLichHoc = @MaLichHoc";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaLichHoc", maLichHoc);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Lịch học đã được xóa.");
                LoadData();
            }
            else
            {
                MessageBox.Show("Hãy chọn một dòng để xóa.");
            }
        }

        private void QuanLyLichHoc_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadProperties(); 
            cboThuocTinh.Visible = false;
            cboGiaTri.Visible = false;
        }

        private void btnShowAllSchedule_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadProperties();
        }
        private void LoadProperties()
        {
            cboThuocTinh.Items.Clear();

            cboThuocTinh.Items.Add("MaLichHoc");
            cboThuocTinh.Items.Add("NamHoc");
            cboThuocTinh.Items.Add("TuanHoc");
            cboThuocTinh.Items.Add("PhongHoc");
            cboThuocTinh.Items.Add("Mon");
        }
          private void LoadValuesForProperty(string propertyName)
        {
           
                cboGiaTri.Items.Clear(); 

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = $"SELECT DISTINCT {propertyName} FROM LICHHOC";  

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cboGiaTri.Items.Add(reader[propertyName].ToString());  
                    }

                    if (cboGiaTri.Items.Count > 0)
                    {
                        cboGiaTri.SelectedIndex = 0;  
                    }
                }
            }
            



        private void button1_Click(object sender, EventArgs e)
        {
            HoatDong = !HoatDong;

            if (HoatDong)
            {
                cboThuocTinh.Visible = true;
                cboGiaTri.Visible = true;
                label1.Visible = true;
                label9.Visible = true;
                LoadProperties();

                cboThuocTinh.SelectedIndexChanged += cboThuocTinh_SelectedIndexChanged;

                cboGiaTri.SelectedIndexChanged += (s, args) =>
                {
                    string selectedProperty = cboThuocTinh.SelectedItem?.ToString();
                    string selectedValue = cboGiaTri.SelectedItem?.ToString();

                    if (!string.IsNullOrEmpty(selectedProperty) && !string.IsNullOrEmpty(selectedValue))
                    {
                        PerformSearch(selectedProperty, selectedValue);
                    }
                };

                button1.Text = "Tắt tìm kiếm"; 
            }
            else
            {
                cboThuocTinh.Visible = false;
                cboGiaTri.Visible = false;
                label1.Visible = false;
                label9.Visible = false;

                cboThuocTinh.SelectedIndexChanged -= cboThuocTinh_SelectedIndexChanged;

                button1.Text = "Bật tìm kiếm"; 

                 LoadData();
            }
        }

        private void PerformSearch(string selectedProperty, string selectedValue)
        {

            List<string> validColumns = new List<string> { "MaLichHoc", "NamHoc", "TuanHoc", "PhongHoc", "Mon" };
            if (!validColumns.Contains(selectedProperty))
            {
                MessageBox.Show("Thuộc tính không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                
                    conn.Open();
                    string query = $"SELECT * FROM LICHHOC WHERE {selectedProperty} = @Value"; 
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Value", selectedValue);  

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgvLichHoc.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
        }

    }
}
