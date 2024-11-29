namespace QuanLyLichHoc
{
    partial class LamVaNop
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
            this.dgvLamVaNop = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLamVaNop)).BeginInit();
            this.SuspendLayout();
            


            this.dgvLamVaNop.AllowUserToAddRows = false;
            this.dgvLamVaNop.AllowUserToDeleteRows = false;
            this.dgvLamVaNop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLamVaNop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLamVaNop.Location = new System.Drawing.Point(21, 20);
            this.dgvLamVaNop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvLamVaNop.MultiSelect = false;
            this.dgvLamVaNop.Name = "dgvLamVaNop";
            this.dgvLamVaNop.ReadOnly = true;
            this.dgvLamVaNop.RowHeadersWidth = 82;
            this.dgvLamVaNop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLamVaNop.Size = new System.Drawing.Size(960, 500);
            this.dgvLamVaNop.TabIndex = 0;
            


            this.btnReload.Location = new System.Drawing.Point(21, 550);
            this.btnReload.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(171, 50);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            


            this.btnDelete.Location = new System.Drawing.Point(809, 550);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            



            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1001, 635);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgvLamVaNop);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "LamVaNop";
            this.Text = "LamVaNop";
            this.Load += new System.EventHandler(this.LamVaNop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLamVaNop)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvLamVaNop;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDelete;
    }
}
