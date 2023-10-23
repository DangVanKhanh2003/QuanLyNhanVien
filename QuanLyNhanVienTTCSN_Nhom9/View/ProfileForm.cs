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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            DoiMKForm changePasswordForm = new DoiMKForm();
            changePasswordForm.ShowDialog();
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            PhanHoiForm feedBackForm = new PhanHoiForm();
            feedBackForm.ShowDialog();
        }
    }
}
