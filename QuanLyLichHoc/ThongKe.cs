using System;
using System.Windows.Forms;

namespace QuanLyLichHoc
{
    public partial class ThongKeForm : Form
    {
        private UserSession userSession;

        public ThongKeForm(UserSession session)
        {
            InitializeComponent();
            this.userSession = session;  
        }

        private void ThongKeForm_Load(object sender, EventArgs e)
        {
             if (userSession.Role != "Teacher")
            {
                MessageBox.Show("Chỉ giáo viên mới có quyền truy cập chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();  
            }
        }

        private void btnHoc_Click(object sender, EventArgs e)
        {
             HocForm hocForm = new HocForm(userSession);
            hocForm.Show();
        }

        private void btnLamVaNop_Click(object sender, EventArgs e)
        {
             LamVaNop lamVaNopForm = new LamVaNop(userSession);
            lamVaNopForm.Show();
        }
    }
}
