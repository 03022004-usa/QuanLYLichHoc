namespace QuanLyLichHoc
{
    partial class HocSinh
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.txtNghi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNoiSinh = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblNghi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.SuspendLayout();
            


            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Location = new System.Drawing.Point(12, 12);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.RowHeadersWidth = 51;
            this.dgvHocSinh.RowTemplate.Height = 24;
            this.dgvHocSinh.Size = new System.Drawing.Size(760, 250);
            this.dgvHocSinh.TabIndex = 0;
            
            

            this.btnAdd.Location = new System.Drawing.Point(12, 430);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            


            this.btnEdit.Location = new System.Drawing.Point(130, 430);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 30);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            


            this.btnDelete.Location = new System.Drawing.Point(250, 430);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            


            this.txtMaHS.Location = new System.Drawing.Point(150, 280);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(200, 31);
            this.txtMaHS.TabIndex = 4;
            


            this.txtHoTen.Location = new System.Drawing.Point(150, 310);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 31);
            this.txtHoTen.TabIndex = 5;
            


            this.txtGioiTinh.Location = new System.Drawing.Point(150, 337);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(200, 31);
            this.txtGioiTinh.TabIndex = 6;
            

            this.txtNoiSinh.Location = new System.Drawing.Point(150, 373);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(200, 31);
            this.txtNoiSinh.TabIndex = 7;
            


            this.txtTrangThai.Location = new System.Drawing.Point(557, 277);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(200, 31);
            this.txtTrangThai.TabIndex = 8;
           
            


            this.txtNghi.Location = new System.Drawing.Point(557, 313);
            this.txtNghi.Name = "txtNghi";
            this.txtNghi.Size = new System.Drawing.Size(200, 31);
            this.txtNghi.TabIndex = 9;
            


            this.txtEmail.Location = new System.Drawing.Point(557, 343);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 31);
            this.txtEmail.TabIndex = 10;
           
           
            

            this.txtLop.Location = new System.Drawing.Point(557, 380);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(200, 31);
            this.txtLop.TabIndex = 11;
            


            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Location = new System.Drawing.Point(12, 283);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(135, 25);
            this.lblMaHS.TabIndex = 12;
            this.lblMaHS.Text = "Mã Học Sinh";
           


            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(12, 313);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(82, 25);
            this.lblHoTen.TabIndex = 13;
            this.lblHoTen.Text = "Họ Tên";
           


            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(12, 343);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(98, 25);
            this.lblGioiTinh.TabIndex = 14;
            this.lblGioiTinh.Text = "Giới Tính";
           


            this.lblNoiSinh.AutoSize = true;
            this.lblNoiSinh.Location = new System.Drawing.Point(12, 373);
            this.lblNoiSinh.Name = "lblNoiSinh";
            this.lblNoiSinh.Size = new System.Drawing.Size(93, 25);
            this.lblNoiSinh.TabIndex = 15;
            this.lblNoiSinh.Text = "Nơi Sinh";
            


            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(415, 280);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(116, 25);
            this.lblTrangThai.TabIndex = 16;
            this.lblTrangThai.Text = "Trạng Thái";
            


            this.lblNghi.AutoSize = true;
            this.lblNghi.Location = new System.Drawing.Point(428, 316);
            this.lblNghi.Name = "lblNghi";
            this.lblNghi.Size = new System.Drawing.Size(56, 25);
            this.lblNghi.TabIndex = 17;
            this.lblNghi.Text = "Nghỉ";
            


            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(424, 349);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 25);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            


            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(428, 386);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(48, 25);
            this.lblLop.TabIndex = 19;
            this.lblLop.Text = "Lớp";
            


            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(991, 500);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNghi);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblNoiSinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMaHS);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNghi);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.txtNoiSinh);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvHocSinh);
            this.Name = "HocSinh";
            this.Text = "Quản Lý Học Sinh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.TextBox txtNghi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNoiSinh;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblNghi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLop;
    }
}
