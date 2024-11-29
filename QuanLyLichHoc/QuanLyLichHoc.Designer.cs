namespace QuanLyLichHoc
{
    partial class QuanLyLichHoc
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvLichHoc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowAllSchedule;
        private System.Windows.Forms.TextBox txtMaLichHoc;
        private System.Windows.Forms.TextBox txtTuanHoc;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.DateTimePicker dtpThoiGianBatDau;
        private System.Windows.Forms.DateTimePicker dtpThoiGianKetThuc;
        private System.Windows.Forms.TextBox txtPhongHoc;
        private System.Windows.Forms.TextBox txtMon;
        private System.Windows.Forms.ComboBox cboThuocTinh;
        private System.Windows.Forms.ComboBox cboGiaTri;
        private System.Windows.Forms.Button button1;


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
            this.dgvLichHoc = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowAllSchedule = new System.Windows.Forms.Button();
            this.txtMaLichHoc = new System.Windows.Forms.TextBox();
            this.txtTuanHoc = new System.Windows.Forms.TextBox();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.dtpThoiGianBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpThoiGianKetThuc = new System.Windows.Forms.DateTimePicker();
            this.txtPhongHoc = new System.Windows.Forms.TextBox();
            this.txtMon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboThuocTinh = new System.Windows.Forms.ComboBox();
            this.cboGiaTri = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).BeginInit();
            this.SuspendLayout();
           


            this.dgvLichHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichHoc.Location = new System.Drawing.Point(12, 12);
            this.dgvLichHoc.Name = "dgvLichHoc";
            this.dgvLichHoc.RowHeadersWidth = 82;
            this.dgvLichHoc.Size = new System.Drawing.Size(776, 300);
            this.dgvLichHoc.TabIndex = 0;
          


            this.btnAdd.Location = new System.Drawing.Point(977, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            


            this.btnEdit.Location = new System.Drawing.Point(977, 129);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(179, 36);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            


            this.btnDelete.Location = new System.Drawing.Point(977, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
           


            this.btnShowAllSchedule.Location = new System.Drawing.Point(977, 12);
            this.btnShowAllSchedule.Name = "btnShowAllSchedule";
            this.btnShowAllSchedule.Size = new System.Drawing.Size(179, 38);
            this.btnShowAllSchedule.TabIndex = 4;
            this.btnShowAllSchedule.Text = "Hiện Lịch Học";
            this.btnShowAllSchedule.UseVisualStyleBackColor = true;
            this.btnShowAllSchedule.Click += new System.EventHandler(this.btnShowAllSchedule_Click);
           
            

            this.txtMaLichHoc.Location = new System.Drawing.Point(224, 359);
            this.txtMaLichHoc.Name = "txtMaLichHoc";
            this.txtMaLichHoc.Size = new System.Drawing.Size(158, 31);
            this.txtMaLichHoc.TabIndex = 11;
           
            

            this.txtTuanHoc.Location = new System.Drawing.Point(224, 472);
            this.txtTuanHoc.Name = "txtTuanHoc";
            this.txtTuanHoc.Size = new System.Drawing.Size(158, 31);
            this.txtTuanHoc.TabIndex = 10;
           


            this.txtNamHoc.Location = new System.Drawing.Point(224, 416);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(158, 31);
            this.txtNamHoc.TabIndex = 9;
            


            this.dtpThoiGianBatDau.Location = new System.Drawing.Point(725, 525);
            this.dtpThoiGianBatDau.Name = "dtpThoiGianBatDau";
            this.dtpThoiGianBatDau.Size = new System.Drawing.Size(393, 31);
            this.dtpThoiGianBatDau.TabIndex = 8;
            


            this.dtpThoiGianKetThuc.Location = new System.Drawing.Point(725, 590);
            this.dtpThoiGianKetThuc.Name = "dtpThoiGianKetThuc";
            this.dtpThoiGianKetThuc.Size = new System.Drawing.Size(393, 31);
            this.dtpThoiGianKetThuc.TabIndex = 7;
            
            

            this.txtPhongHoc.Location = new System.Drawing.Point(224, 527);
            this.txtPhongHoc.Name = "txtPhongHoc";
            this.txtPhongHoc.Size = new System.Drawing.Size(158, 31);
            this.txtPhongHoc.TabIndex = 6;
           


            this.txtMon.Location = new System.Drawing.Point(224, 584);
            this.txtMon.Name = "txtMon";
            this.txtMon.Size = new System.Drawing.Size(158, 31);
            this.txtMon.TabIndex = 5;
            


            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 596);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Thời gian kết thúc: ";
            


            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã lịch học:";
           


            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Năm học:";
           


            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tuần học:";
            


            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Phòng học:";
           


            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 590);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Môn:";
            


            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(513, 533);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Thời gian bắt đầu:";
            


            this.cboThuocTinh.Location = new System.Drawing.Point(782, 370);
            this.cboThuocTinh.Name = "cboThuocTinh";
            this.cboThuocTinh.Size = new System.Drawing.Size(158, 33);
            this.cboThuocTinh.TabIndex = 0;
           
            

            this.cboGiaTri.Location = new System.Drawing.Point(1100, 365);
            this.cboGiaTri.Name = "cboGiaTri";
            this.cboGiaTri.Size = new System.Drawing.Size(158, 33);
            this.cboGiaTri.TabIndex = 0;
            


            this.button1.Location = new System.Drawing.Point(977, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
           
            

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thuộc tính:";
            this.label1.Visible = false;
            
            

            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(991, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Giá trị:";
            this.label9.Visible = false;
           


            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1298, 717);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowAllSchedule);
            this.Controls.Add(this.txtMon);
            this.Controls.Add(this.txtPhongHoc);
            this.Controls.Add(this.dtpThoiGianKetThuc);
            this.Controls.Add(this.dtpThoiGianBatDau);
            this.Controls.Add(this.txtNamHoc);
            this.Controls.Add(this.txtTuanHoc);
            this.Controls.Add(this.txtMaLichHoc);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvLichHoc);
            this.Controls.Add(this.cboThuocTinh);
            this.Controls.Add(this.cboGiaTri);
            this.Name = "QuanLyLichHoc";
            this.Text = "Quản Lý Lịch Học";
            this.Load += new System.EventHandler(this.QuanLyLichHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
    }
}
