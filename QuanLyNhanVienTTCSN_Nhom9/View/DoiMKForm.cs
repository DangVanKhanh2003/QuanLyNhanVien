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
    public partial class DoiMKForm : Form
    {
        private string idAcc;
        public DoiMKForm(string idAcc)
        {
            InitializeComponent();
            this.idAcc = idAcc;
        }
        public string IdAcc
        {
            set { idAcc = value; }
            get { return idAcc; }   
        }
        private void DoiMKForm_Load(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string currentPassword = currentPasswordTextBox.Text.ToString();
            string newPassword = newPasswordTextBox.Text.ToString();
            string newPasswordRetype = enterAgainPassword.Text.ToString();
            if(currentPassword != null && newPassword != null && newPasswordRetype != null) 
            {
                ChangePasswordControl changePasswordControl = new ChangePasswordControl();
                changePasswordControl.ChangePassword(idAcc, currentPassword, newPassword, newPasswordRetype);
                this.Close();
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin.");
            }    
        }
    }
}
