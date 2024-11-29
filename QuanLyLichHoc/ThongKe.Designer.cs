using System.Windows.Forms;
namespace QuanLyLichHoc
{
    partial class ThongKeForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnHoc;
        private Button btnLamVanNop;

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
            this.btnHoc = new System.Windows.Forms.Button();
            this.btnLamVanNop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHoc
            // 
            this.btnHoc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHoc.Location = new System.Drawing.Point(198, 83);
            this.btnHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHoc.Name = "btnHoc";
            this.btnHoc.Size = new System.Drawing.Size(225, 78);
            this.btnHoc.TabIndex = 0;
            this.btnHoc.Text = "ĐIểm danh";
            this.btnHoc.UseVisualStyleBackColor = false;
            this.btnHoc.Click += new System.EventHandler(this.btnHoc_Click);
            // 
            // btnLamVanNop
            // 
            this.btnLamVanNop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLamVanNop.Location = new System.Drawing.Point(198, 226);
            this.btnLamVanNop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLamVanNop.Name = "btnLamVanNop";
            this.btnLamVanNop.Size = new System.Drawing.Size(225, 78);
            this.btnLamVanNop.TabIndex = 1;
            this.btnLamVanNop.Text = "Bài tập hoàn thành";
            this.btnLamVanNop.UseVisualStyleBackColor = false;
            this.btnLamVanNop.Click += new System.EventHandler(this.btnLamVaNop_Click);
            // 
            // ThongKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(730, 408);
            this.Controls.Add(this.btnLamVanNop);
            this.Controls.Add(this.btnHoc);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThongKeForm";
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.ThongKeForm_Load);
            this.ResumeLayout(false);

        }
    }
}
