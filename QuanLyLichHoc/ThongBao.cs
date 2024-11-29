// ThongBao.cs
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace QuanLyLichHoc
{
    public partial class ThongBao : Form
    {
        private UserSession userSession;
        public ThongBao(UserSession session)
        {
            InitializeComponent();
            this.userSession = session;  
        }

        private void ThongBao_Load(object sender, EventArgs e)
        {
 
            if (userSession.Role != "Teacher" && userSession.Role != "Admin")
            {
                MessageBox.Show("Bạn không được thông báo.");
                this.Close();
            }
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

         }

        private void lblRecipientEmail_Click(object sender, EventArgs e)
        {

         }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (userSession.Role != "Teacher" && userSession.Role != "Admin")
            {
                MessageBox.Show("Chỉ giáo viên và admin có quyền gửi thông báo.");
                return;
            }


            string recipientEmail = txtRecipientEmail.Text;
            string subject = txtSubject.Text;
            string message = txtMessage.Text;


            if (string.IsNullOrWhiteSpace(recipientEmail) || string.IsNullOrWhiteSpace(subject) || string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin (Email người nhận, Tiêu đề, và Nội dung) trước khi gửi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
          

            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string senderEmail = "vanthien03022004@gmail.com";
            string senderPassword = "b b r s g s f s f n y w c x f m"; 

           
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(recipientEmail);
                mail.Subject = subject;
                mail.Body = message;

                SmtpClient smtp = new SmtpClient(smtpServer, smtpPort)
                {
                    EnableSsl = true,
                    Credentials = new NetworkCredential(senderEmail, senderPassword)
                };

                smtp.Send(mail);
                MessageBox.Show("Gửi thành công!");
           
        }


    }
}
