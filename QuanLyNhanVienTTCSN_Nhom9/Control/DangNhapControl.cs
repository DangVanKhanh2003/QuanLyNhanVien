using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace QuanLyNhanVienTTCSN_Nhom9.Control
{
    internal class DangNhapControl
    {
        private string idEmployee = null;
        private string typeAcc = null;
        private string idAcc = null;

        public string IdEmployee
        {
            get
            {
                return idEmployee; // Getter method
            }
            set
            {
                idEmployee = value; // Setter method
            }
        }

        public string TypeAcc
        {
            get
            {
                return typeAcc; // Getter method
            }
            set
            {
                typeAcc = value; // Setter method
            }
        }

        public string IdAcc
        {
            get
            {
                return idAcc; // Getter method
            }
            set
            {
                idAcc = value; // Setter method
            }
        }

        public void searchAcc(string acc, string password)
        {
            string strComandAdmin = @"Select * From TaiKhoanAdmin
                                      where tenDangNhap COLLATE Latin1_General_CS_AS = '" + acc + 
                                      "' AND matKhau COLLATE Latin1_General_CS_AS = '" + password + "'";
            string strComandManage = @"Select * From TaiKhoan
                                       where tenDangNhap COLLATE Latin1_General_CS_AS = '" + acc +
                                       "' AND matKhau COLLATE Latin1_General_CS_AS = '" + password + "'";
            WorkWithDatabase workWithDB = new WorkWithDatabase();   
            DataTable table = workWithDB.loadDataFromDB(strComandAdmin);
            if(table.Rows.Count > 0) 
            {
                idAcc = table.Rows[0][1].ToString();
                typeAcc = "Admin";
            }
            else
            {
                table.Clear();
                table = workWithDB.loadDataFromDB(strComandManage);
                if (table.Rows.Count > 0)
                {
                    idAcc = table.Rows[0][0].ToString();
                    typeAcc = table.Rows[0][4].ToString();
                    idEmployee = table.Rows[0][3].ToString();
                }
                else
                {
                    MessageBox.Show("Tài Khoản hoặc mật khẩu không đúng.");
                }
            }
        }
    }
}
