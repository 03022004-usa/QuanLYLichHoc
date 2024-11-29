namespace QuanLyLichHoc
{
    partial class TrangChu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnQuanLyLichHoc;
        private System.Windows.Forms.Button btnQuanLyBT;
        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.Button btnHocSinh;  
        private System.Windows.Forms.Button btnThongKe;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnQuanLyLichHoc = new System.Windows.Forms.Button();
            this.btnQuanLyBT = new System.Windows.Forms.Button();
            this.btnThongBao = new System.Windows.Forms.Button();
            this.btnHocSinh = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.SuspendLayout();
           


            this.btnQuanLyLichHoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuanLyLichHoc.FlatAppearance.BorderSize = 0;
            this.btnQuanLyLichHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyLichHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuanLyLichHoc.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyLichHoc.Location = new System.Drawing.Point(235, 113);
            this.btnQuanLyLichHoc.Name = "btnQuanLyLichHoc";
            this.btnQuanLyLichHoc.Size = new System.Drawing.Size(288, 62);
            this.btnQuanLyLichHoc.TabIndex = 0;
            this.btnQuanLyLichHoc.Text = "Quản lý lịch học";
            this.btnQuanLyLichHoc.UseVisualStyleBackColor = false;
            this.btnQuanLyLichHoc.Click += new System.EventHandler(this.btnQuanLyLichHoc_Click);
           


            this.btnQuanLyBT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuanLyBT.FlatAppearance.BorderSize = 0;
            this.btnQuanLyBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuanLyBT.ForeColor = System.Drawing.Color.White;
            this.btnQuanLyBT.Location = new System.Drawing.Point(235, 200);
            this.btnQuanLyBT.Name = "btnQuanLyBT";
            this.btnQuanLyBT.Size = new System.Drawing.Size(288, 54);
            this.btnQuanLyBT.TabIndex = 1;
            this.btnQuanLyBT.Text = "Quản lý bài tập";
            this.btnQuanLyBT.UseVisualStyleBackColor = false;
            this.btnQuanLyBT.Click += new System.EventHandler(this.btnQuanLyBT_Click);
            


            this.btnThongBao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongBao.FlatAppearance.BorderSize = 0;
            this.btnThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongBao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongBao.ForeColor = System.Drawing.Color.White;
            this.btnThongBao.Location = new System.Drawing.Point(235, 275);
            this.btnThongBao.Name = "btnSendNotification";
            this.btnThongBao.Size = new System.Drawing.Size(288, 59);
            this.btnThongBao.TabIndex = 2;
            this.btnThongBao.Text = "Gửi thông báo";
            this.btnThongBao.UseVisualStyleBackColor = false;
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
            


            this.btnHocSinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHocSinh.FlatAppearance.BorderSize = 0;
            this.btnHocSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHocSinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHocSinh.ForeColor = System.Drawing.Color.White;
            this.btnHocSinh.Location = new System.Drawing.Point(235, 340);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(288, 61);
            this.btnHocSinh.TabIndex = 3;
            this.btnHocSinh.Text = "Quản lý học sinh";
            this.btnHocSinh.UseVisualStyleBackColor = false;
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            


            this.btnThongKe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(235, 420);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(288, 55);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
             


            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(752, 530);
            this.Controls.Add(this.btnHocSinh);
            this.Controls.Add(this.btnThongBao);
            this.Controls.Add(this.btnQuanLyBT);
            this.Controls.Add(this.btnQuanLyLichHoc);
            this.Controls.Add(this.btnThongKe);
            this.Name = "TrangChu";
            this.Text = "Trang Chủ";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.ResumeLayout(false);

        }

    }
}
