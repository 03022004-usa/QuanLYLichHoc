namespace QuanLyLichHoc
{
    partial class ThongBao
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtRecipientEmail;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.DateTimePicker dtpNotificationDate;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblRecipientEmail;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblNotificationDate;

       
        /// <param name="disposing">true nếu cần giải phóng tài nguyên; ngược lại, false.</param>
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
            this.lblRecipientEmail = new System.Windows.Forms.Label();
            this.txtRecipientEmail = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblNotificationDate = new System.Windows.Forms.Label();
            this.dtpNotificationDate = new System.Windows.Forms.DateTimePicker();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            


            this.lblRecipientEmail.AutoSize = true;
            this.lblRecipientEmail.Location = new System.Drawing.Point(24, 17);
            this.lblRecipientEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRecipientEmail.Name = "lblRecipientEmail";
            this.lblRecipientEmail.Size = new System.Drawing.Size(178, 25);
            this.lblRecipientEmail.TabIndex = 0;
            this.lblRecipientEmail.Text = "Email người nhận";
            


            this.txtRecipientEmail.Location = new System.Drawing.Point(24, 48);
            this.txtRecipientEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtRecipientEmail.Name = "txtRecipientEmail";
            this.txtRecipientEmail.Size = new System.Drawing.Size(516, 31);
            this.txtRecipientEmail.TabIndex = 1;
           


            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(24, 92);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(81, 25);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Chủ đề";
            


            this.txtSubject.Location = new System.Drawing.Point(24, 123);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(6);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(516, 31);
            this.txtSubject.TabIndex = 3;
            


            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(24, 282);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(200, 25);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Nội dung thông báo";
            


            this.txtMessage.Location = new System.Drawing.Point(29, 332);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(6);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(516, 150);
            this.txtMessage.TabIndex = 5;
            


            this.lblNotificationDate.AutoSize = true;
            this.lblNotificationDate.Location = new System.Drawing.Point(24, 175);
            this.lblNotificationDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNotificationDate.Name = "lblNotificationDate";
            this.lblNotificationDate.Size = new System.Drawing.Size(164, 25);
            this.lblNotificationDate.TabIndex = 6;
            this.lblNotificationDate.Text = "Ngày thông báo";
            
            

            this.dtpNotificationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNotificationDate.Location = new System.Drawing.Point(24, 215);
            this.dtpNotificationDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpNotificationDate.Name = "dtpNotificationDate";
            this.dtpNotificationDate.Size = new System.Drawing.Size(516, 31);
            this.dtpNotificationDate.TabIndex = 7;
            


            this.btnSend.Location = new System.Drawing.Point(24, 515);
            this.btnSend.Margin = new System.Windows.Forms.Padding(6);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(520, 44);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Gửi thông báo";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            


            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1053, 606);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.dtpNotificationDate);
            this.Controls.Add(this.lblNotificationDate);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtRecipientEmail);
            this.Controls.Add(this.lblRecipientEmail);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ThongBao";
            this.Text = "Gửi Thông Báo";
            this.Load += new System.EventHandler(this.ThongBao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
