using System.Windows.Forms;

namespace QuanLyLichHoc
{
    partial class HocForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvHoc;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ComboBox cboMaMon;


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
            this.dgvHoc = new System.Windows.Forms.DataGridView();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.cboMaMon = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoc
            // 
            this.dgvHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoc.Location = new System.Drawing.Point(12, 12);
            this.dgvHoc.Name = "dgvHoc";
            this.dgvHoc.RowHeadersWidth = 82;
            this.dgvHoc.Size = new System.Drawing.Size(600, 200);
            this.dgvHoc.TabIndex = 0;
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Location = new System.Drawing.Point(12, 230);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(129, 25);
            this.lblMaHS.TabIndex = 1;
            this.lblMaHS.Text = "Mã học sinh";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(150, 233);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(200, 31);
            this.txtMaHS.TabIndex = 2;
            this.txtMaHS.TextChanged += new System.EventHandler(this.txtMaHS_TextChanged);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(12, 288);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(104, 25);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ và tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(150, 288);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(200, 31);
            this.txtHoTen.TabIndex = 4;
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Location = new System.Drawing.Point(426, 236);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(89, 25);
            this.lblMaMon.TabIndex = 5;
            this.lblMaMon.Text = "Mã môn";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(559, 230);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(200, 31);
            this.txtMaMon.TabIndex = 6;
            this.txtMaMon.TextChanged += new System.EventHandler(this.txtMaMon_TextChanged);
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Location = new System.Drawing.Point(419, 288);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(96, 25);
            this.lblTenMon.TabIndex = 7;
            this.lblTenMon.Text = "Tên môn";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(559, 282);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.ReadOnly = true;
            this.txtTenMon.Size = new System.Drawing.Size(200, 31);
            this.txtTenMon.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(50, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 43);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(217, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 43);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(395, 364);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(120, 46);
            this.btnReload.TabIndex = 11;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // cboMaMon
            // 
            this.cboMaMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaMon.FormattingEnabled = true;
            this.cboMaMon.Location = new System.Drawing.Point(150, 90);
            this.cboMaMon.Name = "cboMaMon";
            this.cboMaMon.Size = new System.Drawing.Size(200, 33);
            this.cboMaMon.TabIndex = 2;
            // 
            // HocForm
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(889, 440);
            this.Controls.Add(this.dgvHoc);
            this.Controls.Add(this.lblMaHS);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblMaMon);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.lblTenMon);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.cboMaMon);
            this.Name = "HocForm";
            this.Text = "Quản lý học";
            this.Load += new System.EventHandler(this.HocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
