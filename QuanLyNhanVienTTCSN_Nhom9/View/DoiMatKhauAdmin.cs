using QuanLyNhanVienTTCSN_Nhom9.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    public partial class DoiMatKhauAdmin : Form
    {
        public DoiMatKhauAdmin()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string currentPassword = currentPasswordTextBox.Text.ToString();
            string newPassword = newPasswordTextBox.Text.ToString();
            string newPasswordRetype = enterAgainPassword.Text.ToString();
            if (currentPassword != null && newPassword != null && newPasswordRetype != null)
            {
                ChangePasswordAdminControl changePasswordControl = new ChangePasswordAdminControl();
                changePasswordControl.ChangePassword(currentPassword, newPassword, newPasswordRetype);
                this.Close();
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin.");
            }
        }
    }
}
