namespace QuanLyLichHoc
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private System.Windows.Forms.Button btnQuanLyTruong;
        private System.Windows.Forms.Button btnQuanLyTaiKhoan;
        private void InitializeComponent()
        {
            this.btnQuanLyTruong = new System.Windows.Forms.Button();
            this.btnQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            


            this.btnQuanLyTruong.Location = new System.Drawing.Point(151, 156);
            this.btnQuanLyTruong.Name = "btnQuanLyTruong";
            this.btnQuanLyTruong.Size = new System.Drawing.Size(252, 40);
            this.btnQuanLyTruong.TabIndex = 0;
            this.btnQuanLyTruong.Text = "Quản lý trường học";
            this.btnQuanLyTruong.UseVisualStyleBackColor = true;
            this.btnQuanLyTruong.Click += new System.EventHandler(this.btnQuanLyTruong_Click);
           


            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(151, 248);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(252, 40);
            this.btnQuanLyTaiKhoan.TabIndex = 1;
            this.btnQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = true;
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            


            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(610, 401);
            this.Controls.Add(this.btnQuanLyTaiKhoan);
            this.Controls.Add(this.btnQuanLyTruong);
            this.Name = "AdminForm";
            this.Text = " Quản lý hệ thống";
            this.ResumeLayout(false);

        }

       
    }
}
