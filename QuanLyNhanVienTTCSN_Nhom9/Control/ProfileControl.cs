using System;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;


namespace QuanLyNhanVienTTCSN_Nhom9.Control
{
    internal class ProfileControl
    {
        public DataTable LoadInfor(string idEmployee)
        { 
            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            string strCommand = @"SELECT * FROM NhanVien
                                  LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu
                                  LEFT JOIN PhongBan ON ChucVu.maPhongBan = PhongBan.maPhongBan
                                  WHERE maNV = '" + idEmployee + "'";
            DataTable table = workWithDatabase.loadDataFromDB(strCommand);
            if(table.Rows.Count > 0) 
            {
                return table;
            }
            else
            {
                MessageBox.Show("Không tồn tại dữ liệu.");
                return null;
            }
        }

    }
}
