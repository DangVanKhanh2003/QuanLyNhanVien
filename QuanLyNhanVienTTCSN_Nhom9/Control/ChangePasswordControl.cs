using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;


namespace QuanLyNhanVienTTCSN_Nhom9.Control
{
    internal class ChangePasswordControl
    {
        public void ChangePassword(string idAcc, string currentPassword, string newPassword, string newPasswordRetype)
        {
            string strCommand = @"SELECT * FROM TaiKhoan
                                 WHERE maTK = '" + idAcc + "'";
            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            DataTable table = workWithDatabase.loadDataFromDB(strCommand);
            if(table.Rows.Count > 0 ) 
            {
                if(currentPassword == table.Rows[0][2].ToString() && newPassword == newPasswordRetype)
                {
                    if(newPassword.Length < 5)
                    {
                        MessageBox.Show("Mật khẩu phải tối thiểu là 5 ký tự.");
                    }   
                    else
                    {
                        string strChangePassCommand = @"UPDATE TaiKhoan
                                                    SET matKhau = '" + newPassword + "'" +
                                                    "WHERE maTK = '" + idAcc + "'";
                        workWithDatabase.modifierDB(strChangePassCommand);
                        MessageBox.Show("Đổi mật khẩu thành công.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại.");
                }
            }
        }
    }
}
