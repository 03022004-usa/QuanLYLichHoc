namespace QuanLyLichHoc
{
    partial class QuanLyBT
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

        private void InitializeComponent()
        {
            this.dgvBaiTap = new System.Windows.Forms.DataGridView();
            this.txtMaBaiTap = new System.Windows.Forms.TextBox();
            this.txtTenBT = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.dtpNgayDuocGiao = new System.Windows.Forms.DateTimePicker();
            this.dtpHanNop = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnConfirmCompletion = new System.Windows.Forms.Button();
            this.lblMaBaiTap = new System.Windows.Forms.Label();
            this.lblTenBT = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblNgayDuocGiao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaiTap)).BeginInit();
            this.SuspendLayout();
           


            this.dgvBaiTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaiTap.Location = new System.Drawing.Point(18, 19);
            this.dgvBaiTap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBaiTap.Name = "dgvBaiTap";
            this.dgvBaiTap.RowHeadersWidth = 82;
            this.dgvBaiTap.Size = new System.Drawing.Size(840, 391);
            this.dgvBaiTap.TabIndex = 0;
           


            this.txtMaBaiTap.Location = new System.Drawing.Point(163, 438);
            this.txtMaBaiTap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaBaiTap.Name = "txtMaBaiTap";
            this.txtMaBaiTap.Size = new System.Drawing.Size(298, 31);
            this.txtMaBaiTap.TabIndex = 1;
           


            this.txtTenBT.Location = new System.Drawing.Point(163, 488);
            this.txtTenBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenBT.Name = "txtTenBT";
            this.txtTenBT.Size = new System.Drawing.Size(298, 31);
            this.txtTenBT.TabIndex = 2;
            


            this.txtMoTa.Location = new System.Drawing.Point(163, 535);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(298, 92);
            this.txtMoTa.TabIndex = 3;
            


            this.dtpNgayDuocGiao.Location = new System.Drawing.Point(746, 439);
            this.dtpNgayDuocGiao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayDuocGiao.Name = "dtpNgayDuocGiao";
            this.dtpNgayDuocGiao.Size = new System.Drawing.Size(298, 31);
            this.dtpNgayDuocGiao.TabIndex = 4;
            


            this.dtpHanNop.Location = new System.Drawing.Point(736, 500);
            this.dtpHanNop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpHanNop.Name = "dtpHanNop";
            this.dtpHanNop.Size = new System.Drawing.Size(298, 31);
            this.dtpHanNop.TabIndex = 5;
           


            this.btnAdd.Location = new System.Drawing.Point(962, 40);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(300, 47);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            


            this.btnEdit.Location = new System.Drawing.Point(962, 116);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(300, 47);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            


            this.btnDelete.Location = new System.Drawing.Point(962, 187);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(300, 47);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            


            this.btnShowAll.Location = new System.Drawing.Point(962, 268);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(300, 47);
            this.btnShowAll.TabIndex = 9;
            this.btnShowAll.Text = "Hiển thị tất cả";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            


            this.btnConfirmCompletion.Location = new System.Drawing.Point(962, 339);
            this.btnConfirmCompletion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmCompletion.Name = "btnConfirmCompletion";
            this.btnConfirmCompletion.Size = new System.Drawing.Size(300, 47);
            this.btnConfirmCompletion.TabIndex = 10;
            this.btnConfirmCompletion.Text = "Xác nhận hoàn thành";
            this.btnConfirmCompletion.UseVisualStyleBackColor = true;
            this.btnConfirmCompletion.Click += new System.EventHandler(this.btnConfirmCompletion_Click);
           


            this.lblMaBaiTap.AutoSize = true;
            this.lblMaBaiTap.Location = new System.Drawing.Point(13, 438);
            this.lblMaBaiTap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaBaiTap.Name = "lblMaBaiTap";
            this.lblMaBaiTap.Size = new System.Drawing.Size(119, 25);
            this.lblMaBaiTap.TabIndex = 11;
            this.lblMaBaiTap.Text = "Mã bài tập:";
           


            this.lblTenBT.AutoSize = true;
            this.lblTenBT.Location = new System.Drawing.Point(13, 488);
            this.lblTenBT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenBT.Name = "lblTenBT";
            this.lblTenBT.Size = new System.Drawing.Size(88, 25);
            this.lblTenBT.TabIndex = 12;
            this.lblTenBT.Text = "Tên BT:";
           


            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(13, 538);
            this.lblMoTa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(72, 25);
            this.lblMoTa.TabIndex = 13;
            this.lblMoTa.Text = "Mô tả:";
           


            this.lblNgayDuocGiao.AutoSize = true;
            this.lblNgayDuocGiao.Location = new System.Drawing.Point(608, 444);
            this.lblNgayDuocGiao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayDuocGiao.Name = "lblNgayDuocGiao";
            this.lblNgayDuocGiao.Size = new System.Drawing.Size(115, 25);
            this.lblNgayDuocGiao.TabIndex = 14;
            this.lblNgayDuocGiao.Text = "Ngày giao:";
           


            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Hạn nộp:";
            


            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1275, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNgayDuocGiao);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblTenBT);
            this.Controls.Add(this.lblMaBaiTap);
            this.Controls.Add(this.btnConfirmCompletion);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpHanNop);
            this.Controls.Add(this.dtpNgayDuocGiao);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTenBT);
            this.Controls.Add(this.txtMaBaiTap);
            this.Controls.Add(this.dgvBaiTap);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuanLyBT";
            this.Text = "Quản Lý Bài Tập";
            this.Load += new System.EventHandler(this.QuanLyBT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaiTap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvBaiTap;
        private System.Windows.Forms.TextBox txtMaBaiTap;
        private System.Windows.Forms.TextBox txtTenBT;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.DateTimePicker dtpNgayDuocGiao;
        private System.Windows.Forms.DateTimePicker dtpHanNop;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnConfirmCompletion;
        private System.Windows.Forms.Label lblMaBaiTap;
        private System.Windows.Forms.Label lblTenBT;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblNgayDuocGiao;
        private System.Windows.Forms.Label label1;
    }
}
