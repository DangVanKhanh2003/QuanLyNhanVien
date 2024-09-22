using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlTypes;
using System.Web.Services.Description;
using static Bunifu.UI.WinForms.BunifuSnackbar;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static Bunifu.UI.WinForms.BunifuPictureBox;
using System.Numerics;


namespace QuanLyNhanVienTTCSN_Nhom9.Control
{
    internal class ManageForm
    {

        public DataTable loadTableEmployee(string typeAcc)
        {
            string strCommandEmployee = "";
            if(typeAcc == "Admin")
            {
                strCommandEmployee = @"SELECT maNV, hoTen, diaChi, sdt, cccd, mail, ngaySinh, ngayVaoCTy, gioiTinh, tenChucVu, tenPhongBan FROM NhanVien
                                    LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu
                                    LEFT JOIN PhongBan ON ChucVu.maPhongBan = PhongBan.maPhongBan";
            }
            else
            {
                string maPhongBan = typeAcc.Substring(6, typeAcc.Length - 6);
                strCommandEmployee = @"SELECT maNV, hoTen, diaChi, sdt, cccd, mail, ngaySinh, ngayVaoCTy, gioiTinh, tenChucVu, tenPhongBan FROM NhanVien
                                    LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu
                                    LEFT JOIN PhongBan ON ChucVu.maPhongBan = PhongBan.maPhongBan
                                    WHERE PhongBan.maPhongBan COLLATE Latin1_General_CS_AS = '" + maPhongBan + "'";
            }
            

            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            DataTable tblEmployee = workWithDatabase.loadDataFromDB(strCommandEmployee);

            // Column indices might vary, adjust them accordingly
            int dateBirthColumnIndex = 6;
            int dateJoinColumnIndex = 7;

            // Create new columns to store formatted dates
            tblEmployee.Columns.Add("FormattedNgaySinh", typeof(string));
            tblEmployee.Columns.Add("FormattedNgayVaoCTy", typeof(string));

            foreach (DataRow row in tblEmployee.Rows)
            {
                if (!row.IsNull(dateBirthColumnIndex))
                {
                    DateTime dateBirth = (DateTime)row[dateBirthColumnIndex];
                    string formattedDateBirth = dateBirth.ToString("dd/MM/yyyy");
                    row["FormattedNgaySinh"] = formattedDateBirth;
                }

                if (!row.IsNull(dateJoinColumnIndex))
                {
                    DateTime dateJoin = (DateTime)row[dateJoinColumnIndex];
                    string formattedDateJoin = dateJoin.ToString("dd/MM/yyyy");
                    row["FormattedNgayVaoCTy"] = formattedDateJoin;
                }
            }

            // Remove the original date columns
            tblEmployee.Columns.Remove("ngaySinh");
            tblEmployee.Columns.Remove("ngayVaoCTy");


            // Rename the new columns to match the original column names if needed
            tblEmployee.Columns["FormattedNgaySinh"].ColumnName = "ngaySinh";
            tblEmployee.Columns["FormattedNgayVaoCTy"].ColumnName = "ngayVaoCTy";

            return tblEmployee;
        }




        public DataTable loadTableSalary(string typeAcc, int year, int month)
        {
            

            string strMonth = "";
            if (month > 9)
            {
                strMonth = month.ToString();
            }
            else
            {
                strMonth = "0" + month;
            }
            string strCommandSalary = "";
            if (typeAcc == "Admin")
            {
                strCommandSalary = @"select lUONG.maNV, hoTen, tenChucVu, tenPhongBan ,luongCung,luongThuong,luongUngTruoc,phuCap from Luong
                                        LEFT JOIN NhanVien ON NhanVien.maNV = Luong.maNV
                                        LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu
                                        LEFT JOIN PhongBan ON PhongBan.maPhongBan = ChucVu.maPhongBan
                                        WHERE thangNam = '" + year + "-" + strMonth + "'";
            }
            else
            {
                string maPhongBan = typeAcc.Substring(6, typeAcc.Length - 6);
                strCommandSalary = @"select lUONG.maNV, hoTen, tenChucVu, tenPhongBan ,luongCung,luongThuong,luongUngTruoc,phuCap from Luong
                                    LEFT JOIN NhanVien ON NhanVien.maNV = Luong.maNV
                                    LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu
                                    LEFT JOIN PhongBan ON PhongBan.maPhongBan = ChucVu.maPhongBan
                                    WHERE thangNam = '" + year + "-" + strMonth + "' AND " +
                                    "PhongBan.maPhongBan  COLLATE Latin1_General_CS_AS = '" + maPhongBan + "'";
            }

            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            DataTable tblSalary = workWithDatabase.loadDataFromDB(strCommandSalary);
            return tblSalary;
        }

        public DataTable loadTableOnLeave(string typeAcc, int year, int month)
        {
            DateTime startMonth = new DateTime(year, month, 1);
            DateTime endMonth = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            string strMonth = "";
            if (month > 9)
            {
                strMonth = month.ToString();
            }
            else
            {
                strMonth = "0" + month;
            }
            string strCommandOnLeave = "";
            if (typeAcc == "Admin")
            {
                strCommandOnLeave = @"select NghiPhep.maNV, hoTen, tenChucVu, tenPhongBan, tuNgay, denNgay from NghiPhep
                                        LEFT JOIN NhanVien ON NhanVien.maNV = NghiPhep.maNV
                                        LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu
                                        LEFT JOIN PhongBan ON PhongBan.maPhongBan = ChucVu.maPhongBan
                                        WHERE tuNgay <= '" + endMonth.ToString("yyyy-MM-dd") + "' AND denNgay >= '"
                                        + startMonth.ToString("yyyy-MM-dd") + "'";
            }
            else
            {
                string maPhongBan = typeAcc.Substring(6, typeAcc.Length - 6);
                strCommandOnLeave = @"select NghiPhep.maNV, hoTen, tenChucVu, tenPhongBan, tuNgay, denNgay from NghiPhep
                                        LEFT JOIN NhanVien ON NhanVien.maNV = NghiPhep.maNV
                                        LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu
                                        LEFT JOIN PhongBan ON PhongBan.maPhongBan = ChucVu.maPhongBan
                                        WHERE  tuNgay <= '" + endMonth.ToString("yyyy-MM-dd") + "' AND denNgay >= '" + 
                                        startMonth.ToString("yyyy-MM-dd") + "'" +
                                        " AND PhongBan.maPhongBan  COLLATE Latin1_General_CS_AS = '" + maPhongBan + "'";
            }

            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            DataTable tblOnLeave = workWithDatabase.loadDataFromDB(strCommandOnLeave);
            return tblOnLeave;
        }

        public DataTable loadTablePosition(string typeAcc)
        {
            string strCommandPosition = null;
            if (typeAcc == "Admin")
            {
                strCommandPosition = @"SELECT tenChucVu FROM ChucVu";
            }
            else
            {
                string maPhongBan = typeAcc.Substring(6, typeAcc.Length - 6);
                strCommandPosition = @"SELECT tenChucVu FROM ChucVu
                                        WHERE maPhongBan  COLLATE Latin1_General_CS_AS = '" + maPhongBan + "'";
            }

            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            DataTable tblPosition = workWithDatabase.loadDataFromDB(strCommandPosition);
            return tblPosition;
        }

        public DataTable loadTableAccount()
        {
            string strCommand = "SELECT maTK, tenDangNhap, NhanVien.maNV, hoTen, tenChucVu, tenPhongBan,loaiTK FROM TaiKhoan " +
                                " LEFT JOIN NhanVien ON NhanVien.maNV = TaiKhoan.maNV " + 
                                " LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu " +
                                " LEFT JOIN PhongBan ON PhongBan.maPhongBan = ChucVu.maPhongBan";
            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            DataTable tblAccount = workWithDatabase.loadDataFromDB(strCommand);
            tblAccount.Columns[0].ColumnName = "Mã tài khoản";
            tblAccount.Columns[1].ColumnName = "Tên đăng nhập";
            tblAccount.Columns[2].ColumnName = "mã nhân viên";
            tblAccount.Columns[3].ColumnName = "Họ tên";
            tblAccount.Columns[4].ColumnName = "Tên chức vụ";
            tblAccount.Columns[5].ColumnName = "Tên phòng ban";
            tblAccount.Columns[6].ColumnName = "Loại tài khoản";
            return tblAccount;
        }

        public DataTable loadPosition() 
        {
            string strCommand = "SELECT maChucVu, tenChucVu, tenPhongBan FROM ChucVu " +
                                "LEFT JOIN PhongBan ON ChucVu.maPhongBan = PhongBan.maPhongBan";
            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            DataTable tblPosition = workWithDatabase.loadDataFromDB(strCommand);
            tblPosition.Columns[0].ColumnName = "Mã chức vụ";
            tblPosition.Columns[1].ColumnName = "Tên chức vụ";
            tblPosition.Columns[2].ColumnName = "Tên phòng ban";
            return tblPosition;
        }

        public DataTable loadOT(string typeAcc, int month, int year)
        {
            string command = "";
            if (typeAcc == "Admin")
            {
                command = "SELECT maTangCa, TangCa.maNV, hoTen, tenChucVu, tenPhongBan, soGio, ngay, loai FROM TangCa " +
                    " LEFT JOIN NhanVien ON TangCa.maNV = NhanVien.maNV " +
                    " LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu " +
                    " LEFT JOIN PhongBan ON PhongBan.maPhongBan = ChucVu.maPhongBan " +
                    " WHERE MONTH(ngay) = " + month + " AND YEAR(ngay) = " + year;
            }    
            else
            {
                string idDep = getIdDepByTypeAcc(typeAcc);
                command = "SELECT maTangCa, TangCa.maNV, hoTen, tenChucVu, tenPhongBan, soGio, ngay, loai FROM TangCa " +
                   " LEFT JOIN NhanVien ON TangCa.maNV = NhanVien.maNV " +
                   " LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu " +
                   " LEFT JOIN PhongBan ON PhongBan.maPhongBan = ChucVu.maPhongBan " +
                   " WHERE MONTH(ngay) = " + month + " AND YEAR(ngay) = " + year + " AND PhongBan.maPhongBan = '" + idDep + "'";
            }
            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            DataTable tblOT = workWithDatabase.loadDataFromDB(command);
            tblOT.Columns[0].ColumnName = "Mã tăng ca";
            tblOT.Columns[1].ColumnName = "Mã nhân viên";
            tblOT.Columns[2].ColumnName = "Họ tên";
            tblOT.Columns[3].ColumnName = "Chức vụ";
            tblOT.Columns[4].ColumnName = "Phòng ban";
            tblOT.Columns[5].ColumnName = "Số giờ tăng ca";
            tblOT.Columns[6].ColumnName = "Ngày";
            tblOT.Columns[7].ColumnName = "Loại tăng ca";
            // Column indices might vary, adjust them accordingly
            int dateIndex = 6;

            // Create new columns to store formatted dates
            tblOT.Columns.Add("formattedDateOT", typeof(string));

            foreach (DataRow row in tblOT.Rows)
            {
                if (!row.IsNull(dateIndex))
                {
                    DateTime dateOT = (DateTime)row[dateIndex];
                    string formattedDateOT = dateOT.ToString("dd/MM/yyyy");
                    row["formattedDateOT"] = formattedDateOT;
                }

               
            }

            // Remove the original date columns
            tblOT.Columns.Remove("Ngày");


            // Rename the new columns to match the original column names if needed
            tblOT.Columns["formattedDateOT"].ColumnName = "Ngày";

            return tblOT;
        }
        public string getNameDepBytypeAcc(string typeAcc)
        {
            string idDepartment = typeAcc.Substring(6, typeAcc.Length - 6);
            string strCommand = "SELECT tenPhongBan FROM PhongBan WHERE maPhongBan = '" + idDepartment + "'";
            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            DataTable table = workWithDatabase.loadDataFromDB(strCommand);
            if(table.Rows.Count > 0)
            {
                return table.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy phòng ban có mã: " + idDepartment);
                return "";
            }

        }
        public DataTable processTableAccount()
        {
            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            DataTable tblAccount = loadTableAccount();
            for(int i = 0; i < tblAccount.Rows.Count; i++)
            {
                if (tblAccount.Rows[i][6].ToString() == "NhanVien")
                {
                    tblAccount.Rows[i][6] = "Nhân viên";
                }   
                else
                {
                    tblAccount.Rows[i][6] = "Quản lý phòng " + getNameDepBytypeAcc(tblAccount.Rows[i][6].ToString());  
                }    
            }    
            return tblAccount;

        }
        public DataTable processAndShowEmp(string typeAcc)
        {
            DataTable tableEmployee = loadTableEmployee(typeAcc);
            tableEmployee.Columns[0].ColumnName = "Mã nhân viên";
            tableEmployee.Columns[1].ColumnName = "Họ tên";
            tableEmployee.Columns[2].ColumnName = "Địa chỉ";
            tableEmployee.Columns[3].ColumnName = "Số điện thoại";
            tableEmployee.Columns[4].ColumnName = "Căn cước công dân";
            tableEmployee.Columns[5].ColumnName = "Email";
            tableEmployee.Columns[6].ColumnName = "Giới tính";
            tableEmployee.Columns[7].ColumnName = "Tên chức vụ";
            tableEmployee.Columns[8].ColumnName = "Tên phòng ban";
            tableEmployee.Columns[9].ColumnName = "Ngày sinh";
            tableEmployee.Columns[10].ColumnName = "Ngày vào Công ty";
            return tableEmployee;
        }

        public int countOnLeave(int fromMonth, int year, int toMonth, string idEmp)
        {
            string command = "select tuNgay, denNgay from nghiphep" +
                                " WHERE maNV = '" + idEmp + "' ";
            WorkWithDatabase work = new WorkWithDatabase();
            DataTable dt = work.loadDataFromDB(command);
            int total = 0;
            for(int i = fromMonth; i <= toMonth; i++)
            {
                for(int j = 0; j < dt.Rows.Count; j++)
                {
                    DateTime tuNgay = (DateTime)dt.Rows[j][0];
                    DateTime denNgay = (DateTime)dt.Rows[j][1];
                    total += countOnLeaveInMonth(i, year, tuNgay.Day, tuNgay.Month, tuNgay.Year,
                                        denNgay.Day, denNgay.Month, denNgay.Year);
                }
            }
            return total;
        }

        public int countPaidLeaveInMonth(string idEmp, int month, int year)
        {
            int countLeaveInMonth = countOnLeave(month, year, month, idEmp);
            int countLeave = countOnLeave(1, year, month - 1, idEmp);
            if(countLeave < 12)
            {
                if(countLeaveInMonth < (12 - countLeave))
                {
                    return countLeaveInMonth;
                }
                else
                {
                    return 12 - countLeave;
                }    
            }  
            else
            {
                return 0;
            }    
        }

        public BigInteger countSalOTMonth(string idEmp, int year, int month, decimal salOnHour)
        {
            string command = "SELECT * FROM TangCa WHERE maNV = '" + idEmp + "' AND MONTH(ngay) = " + month +
                " AND YEAR(ngay) = " + year ;
            WorkWithDatabase work = new WorkWithDatabase();
            DataTable dt = work.loadDataFromDB(command);
            BigInteger totalSal = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Decimal coeficient = 1;
                if (dt.Rows[i][4].ToString() == "Lễ")
                {
                    coeficient = 3;
                }    
                else
                {
                    DateTime dateOT = (DateTime)dt.Rows[i][3];
                    string dayOfWeek = dateOT.DayOfWeek.ToString();
                    if(dayOfWeek == "Sunday" || dayOfWeek == "Saturday")
                    {
                        coeficient = 2;
                    } 
                    else
                    {
                        coeficient = 1.5M;
                    }    
                }
                totalSal += (BigInteger)(salOnHour * decimal.Parse(dt.Rows[i][2].ToString()) * coeficient);
            }
            return totalSal;
        }
        
        public BigInteger countTotalSal(decimal salOnHour, BigInteger bounus, BigInteger advance, BigInteger allowance, BigInteger workDay,
            BigInteger salOT, BigInteger numPaidLeaveInMonth)
        {
            BigInteger total = (BigInteger)(salOnHour * 8 * (decimal)workDay + (decimal)bounus - (decimal)advance + (decimal)allowance + (decimal)salOT +
                salOnHour * 8 * (decimal)numPaidLeaveInMonth);
            return total;
        }
        public DataTable processtableSal(string typeAcc, int year = -1, int month = -1)
        {

            DateTime currentDate = DateTime.Now;
            int previousMonth = currentDate.Month - 1; // Get current month (1-12)
            int currentYear = currentDate.Year; // Get current year (e.g., 2023)
            if (year == -1)
            {
                year = currentYear;
            }
            if (month == -1)
            {
                month = previousMonth;
            }
            DataTable tableSalary = loadTableSalary(typeAcc, year, month);
            tableSalary.Columns[0].ColumnName = "Mã Nhân viên";
            tableSalary.Columns[1].ColumnName = "Họ tên";
            tableSalary.Columns[2].ColumnName = "Chức vụ";
            tableSalary.Columns[3].ColumnName = "Phòng ban";
            tableSalary.Columns[4].ColumnName = "Lương hợp đồng";
            tableSalary.Columns[5].ColumnName = "Lương thưởng";
            tableSalary.Columns[6].ColumnName = "Lương ứng trước";
            tableSalary.Columns[7].ColumnName = "Phụ cấp";
            tableSalary.Columns.Add("Lương tăng ca");
            tableSalary.Columns.Add("Số ngày công");
            tableSalary.Columns.Add("Số ngày nghỉ có phép");
            tableSalary.Columns.Add("Tổng lương");
            for(int i = 0; i < tableSalary.Rows.Count; i++)
            {
                BigInteger bounus = (BigInteger)((Decimal)tableSalary.Rows[i][5]);
                BigInteger advanceSal = (BigInteger)((Decimal)tableSalary.Rows[i][6]);
                BigInteger allowance = (BigInteger)((Decimal)tableSalary.Rows[i][7]);
                string idEmp = tableSalary.Rows[i][0].ToString();
                Decimal salOnHour = (Decimal)tableSalary.Rows[i][4] / (22 * 8);
                int numPaidLeaveInMonth = countPaidLeaveInMonth(idEmp, month, year);
                int countLeaveInMonth = countOnLeave(month, year, month, idEmp);
                int workDay = 22 - countLeaveInMonth;
                if(workDay < 0)
                {
                    workDay = 0;
                }
                BigInteger salOT = countSalOTMonth(idEmp, year, month, salOnHour);
                BigInteger total = countTotalSal(salOnHour, bounus, advanceSal, allowance, 
                    workDay, salOT, numPaidLeaveInMonth);
                tableSalary.Rows[i][8] = salOT.ToString() + ".0000";
                tableSalary.Rows[i][9] = workDay.ToString() + ".0000";
                tableSalary.Rows[i][10] = numPaidLeaveInMonth.ToString() ;
                tableSalary.Rows[i][11] = total.ToString() + ".0000";
            }
            return tableSalary;
        }
        
        public DataTable loadDepartment()
        {
            string command = "SELECT * FROM PhongBan";
            WorkWithDatabase work = new WorkWithDatabase();
            DataTable dt = work.loadDataFromDB(command);
            dt.Columns[0].ColumnName = "Mã phòng ban";
            dt.Columns[1].ColumnName = "Tên phòng ban";
            return dt;
        }
        public DataTable getTableOnLeave(string typeAcc, int year = -1, int month = -1)
        {
            DateTime currentDate = DateTime.Now;
            int previousMonth = currentDate.Month - 1; // Get current month (1-12)
            int currentYear = currentDate.Year; // Get current year (e.g., 2023)
            if (year == -1)
            {
                year = currentYear;
            }
            if (month == -1)
            {
                month = previousMonth;
            }
            DataTable tableOnLeave = loadTableOnLeave(typeAcc, year, month);
            tableOnLeave.Columns[0].ColumnName = "Mã nhân viên";
            tableOnLeave.Columns[1].ColumnName = "Họ tên nhân viên";
            tableOnLeave.Columns[2].ColumnName = "Chức vụ";
            tableOnLeave.Columns[3].ColumnName = "Phòng ban";
            tableOnLeave.Columns[4].ColumnName = "Nghỉ từ ngày";
            tableOnLeave.Columns[5].ColumnName = "Nghỉ đến ngày";
            return tableOnLeave;
        }
        public DataTable processTableOnLeave(string typeAcc, int year = -1, int month = -1)
        {
            DateTime currentDate = DateTime.Now;
            int previousMonth = currentDate.Month - 1; // Get current month (1-12)
            int currentYear = currentDate.Year; // Get current year (e.g., 2023)
            if (year == -1)
            {
                year = currentYear;
            }
            if (month == -1)
            {
                month = previousMonth;
            }
            DataTable tableResult = new DataTable();
            DataTable tableOnLeave = getTableOnLeave(typeAcc, year, month);
            DataTable tableEmp = processAndShowEmp(typeAcc);
            tableResult.Columns.Add("Mã nhân viên");
            tableResult.Columns.Add("Họ tên nhân viên");
            tableResult.Columns.Add("Chức vụ");
            tableResult.Columns.Add("Phòng ban");
            tableResult.Columns.Add("Tổng số ngày nghỉ");

            for (int i = 0; i < tableEmp.Rows.Count; i++)
            {
                int countTotal = 0;
                for (int j = 0; j < tableOnLeave.Rows.Count; j++)
                {
                    Function fun = new Function();
                    DateTime fromDate = (DateTime)tableOnLeave.Rows[j][4];
                    DateTime toDate = (DateTime)tableOnLeave.Rows[j][5];
                    int count = countOnLeaveInMonth(month, year, fromDate.Day, fromDate.Month, fromDate.Year,
                        toDate.Day, toDate.Month, toDate.Year);
                    string a = tableEmp.Rows[i][0].ToString();
                    string b = tableOnLeave.Rows[j][0].ToString();
                    if (tableEmp.Rows[i][0].ToString() == tableOnLeave.Rows[j][0].ToString())
                    {

                        countTotal += count;
                    }
                }
                tableResult.Rows.Add(tableEmp.Rows[i][0], tableEmp.Rows[i][1], tableEmp.Rows[i][7], tableEmp.Rows[i][8], countTotal);

            }
            return tableResult;

        }


        public int countOnLeaveInMonth(int currentMonth, int currentYear, int fromDate, int fromMonth, int fromYear,
                                       int toDate, int toMonth, int toYear)
        {
            int result = 0;
            int start = 1;
            int end = 0;
            
            if (currentYear == fromYear)
            {
                if (currentMonth == fromMonth)
                {
                    start = fromDate;
                }
                else if (currentMonth < fromMonth)
                {
                    return 0;
                }    
                else
                {
                    start = 1;
                }
            }
            else
            {
                start = 1;
            }

            if (currentYear == toYear)
            {
                if (currentMonth == toMonth)
                {
                    end = toDate;
                }
                else if(currentMonth > toMonth)
                {
                    return 0;
                }    
                else
                {
                    end = DateTime.DaysInMonth(currentYear, currentMonth);
                }
            }
            else
            {
                end = DateTime.DaysInMonth(currentYear, currentMonth);
            }
            return end - start + 1;
        }

        public DataTable findEmployee(DataTable tableEmp, string idEmp, string fullName, string address, string phoneNumber, string identityNumber,
                string mail, string birthDate, string joinDate, string gender, string position)
        {

            DataTable tableResult = new DataTable();
            tableResult.Columns.Add("Mã nhân viên");
            tableResult.Columns.Add("Họ tên");
            tableResult.Columns.Add("Địa chỉ");
            tableResult.Columns.Add("Số điện thoại");
            tableResult.Columns.Add("Căn cước công dân");
            tableResult.Columns.Add("Email");
            tableResult.Columns.Add("Giới tính");
            tableResult.Columns.Add("Tên chức vụ");
            tableResult.Columns.Add("Tên phòng ban");
            tableResult.Columns.Add("Ngày sinh");
            tableResult.Columns.Add("Ngày vào Công ty");

            for (int i = 0; i < tableEmp.Rows.Count; i++)
            {
                if (idEmp != "")
                {
                    if (!tableEmp.Rows[i][0].ToString().Contains(idEmp))
                    {
                        continue;
                    }
                }
                if (fullName != "")
                {
                    if (!tableEmp.Rows[i][1].ToString().Contains(fullName))
                    {
                        continue;
                    }
                }
                if (address != "")
                {

                    if (!tableEmp.Rows[i][2].ToString().Contains(address))
                    {
                        continue;
                    }
                }
                if (phoneNumber != "")
                {
                    if (!tableEmp.Rows[i][3].ToString().Contains(phoneNumber))
                    {
                        continue;
                    }
                }
                if (identityNumber != "")
                {
                    if (!tableEmp.Rows[i][4].ToString().Contains(identityNumber))
                    {
                        continue;
                    }
                }
                if (mail != "")
                {
                    if (!tableEmp.Rows[i][5].ToString().Contains(mail))
                    {
                        continue;
                    }
                }
                if (gender != "" && gender != "Tất cả")
                {
                    if (!(tableEmp.Rows[i][6].ToString() == gender))
                    {
                        continue;
                    }
                }
                if (position != "" && position != "Tất cả")
                {
                    if (!(tableEmp.Rows[i][7].ToString() == position))
                    {
                        continue;
                    }
                }
                if (birthDate != " ")
                {
                    Function fun = new Function();
                    string dateBirthTable = tableEmp.Rows[i][9].ToString();
                    if (dateBirthTable != birthDate)
                    {
                        continue;
                    }
                }

                if (joinDate != " ")
                {
                    Function fun = new Function();
                    string dateBirthTable = tableEmp.Rows[i][10].ToString();
                    if (dateBirthTable != joinDate)
                    {
                        continue;
                    }
                }
                // Import the current row from sourceTable into destinationTable
                DataRow newRow = tableResult.NewRow();
                newRow.ItemArray = tableEmp.Rows[i].ItemArray; // Copies the entire row data

                // Add the imported row to the destinationTable
                tableResult.Rows.Add(newRow);

            }
            return tableResult;
        }

        public DataTable findSalary(string typeAcc, string idEmp, string fullName, BigInteger salary, BigInteger bounus, BigInteger allowance,
            BigInteger advance, BigInteger totalSal, int year, int month)
        {
            DataTable dataSal = new DataTable();
            dataSal = processtableSal(typeAcc, year, month);
            DataTable tableResult = new DataTable();
            tableResult.Columns.Add("Mã Nhân viên");
            tableResult.Columns.Add("Họ tên");
            tableResult.Columns.Add("Chức vụ");
            tableResult.Columns.Add("Phòng ban");
            tableResult.Columns.Add("Lương hợp đồng");
            tableResult.Columns.Add("Lương thưởng");
            tableResult.Columns.Add("Lương ứng trước");
            tableResult.Columns.Add("Phụ cấp");
            tableResult.Columns.Add("Lương tăng ca");
            tableResult.Columns.Add("Số ngày công");
            tableResult.Columns.Add("Số ngày nghỉ có phép");
            tableResult.Columns.Add("Tổng lương");
            for (int i = 0; i < dataSal.Rows.Count; i++)
            {
                if (idEmp != "")
                {
                    if (!dataSal.Rows[i][0].ToString().Contains(idEmp))
                    {
                        continue;
                    }
                }
                if (fullName != "")
                {
                    if (!dataSal.Rows[i][1].ToString().Contains(fullName))
                    {
                        continue;
                    }
                }
                if (salary != -1)
                {
                    if ((BigInteger)decimal.Parse(dataSal.Rows[i][4].ToString()) != salary)
                    {
                        continue;
                    }
                }

                if (bounus != -1)
                {
                    if ((BigInteger)decimal.Parse(dataSal.Rows[i][5].ToString()) != bounus)
                    {
                        continue;
                    }
                }

                if (allowance != -1)
                {
                    if ((BigInteger)decimal.Parse(dataSal.Rows[i][7].ToString()) != allowance)
                    {
                        continue;
                    }
                }

                if (advance != -1)
                {
                    if ((BigInteger)decimal.Parse(dataSal.Rows[i][6].ToString()) != advance)
                    {
                        continue;
                    }
                }

                if (totalSal != -1)
                {
                    BigInteger a = (BigInteger)decimal.Parse(dataSal.Rows[i][11].ToString());
                    if (a != totalSal)
                    {
                        continue;
                    }
                }



                // Import the current row from sourceTable into destinationTable
                DataRow newRow = tableResult.NewRow();
                newRow.ItemArray = dataSal.Rows[i].ItemArray; // Copies the entire row data

                // Add the imported row to the destinationTable
                tableResult.Rows.Add(newRow);
            }
            return tableResult;
        }

        public DataTable findOnLeave(string typeAcc, string idEmp, int month, int year, string fullName, string position)
        {
            DataTable dtOnLeave = new DataTable();
            ManageForm manage = new ManageForm();
            DataTable tableResult = new DataTable();
            tableResult.Columns.Add("Mã nhân viên");
            tableResult.Columns.Add("Họ tên nhân viên");
            tableResult.Columns.Add("Chức vụ");
            tableResult.Columns.Add("Phòng ban");
            tableResult.Columns.Add("Tổng số ngày nghỉ");
            dtOnLeave = manage.processTableOnLeave(typeAcc, year, month);

            for (int i = 0; i < dtOnLeave.Rows.Count; i++)
            {

                if (idEmp != "")
                {
                    if (!dtOnLeave.Rows[i][0].ToString().Contains(idEmp))
                    {
                        continue;
                    }
                }

                if (fullName != "")
                {
                    if (!dtOnLeave.Rows[i][1].ToString().Contains(fullName))
                    {
                        continue;
                    }
                }

                if (position != "Tất cả")
                {
                    if (dtOnLeave.Rows[i][2].ToString() != position)
                    {
                        continue;
                    }
                }

                DataRow newRow = tableResult.NewRow();
                newRow.ItemArray = dtOnLeave.Rows[i].ItemArray; // Copies the entire row data

                // Add the imported row to the destinationTable
                tableResult.Rows.Add(newRow);
            }
            return tableResult;
        }

        public void addEmployee(string typeAcc, string fullName, string address, string phoneNumber, string identifyId, string mail,
            string dateBirth, string dateJoin, string gender, string position)
        {
            if (fullName == "" || address == "" || phoneNumber == "" || identifyId == "" || mail == "" || gender == "" || position == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                WorkWithDatabase workWithDatabase = new WorkWithDatabase();
                string id = createNewId(findMaxId("Nhanvien", "maNV", 2, "NV"), 2);
                string positionId = findPostionIdbyName(position, typeAcc);
                string comandAdd = @"INSERT INTO NhanVien(maNV, hoTen, diaChi, sdt, cccd, mail, ngaySinh, ngayVaoCTy, gioiTinh, maChucVu)
                                    VALUES ('" + id + "', N'" + fullName + "', N'" + address + "', '" + phoneNumber + "','" + identifyId
                                    + "','" + mail + "','" + dateBirth + "','" + dateJoin + "',N'" + gender + "','" + positionId + "')";
                workWithDatabase.modifierDB(comandAdd);

            }
        }
        public string findMaxId(string table, string column, int lengthDel, string frefix)
        {
            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            string command = @"SELECT MAX(CAST(SUBSTRING(" + column + @"," + (lengthDel + 1) + @" , LEN(" + column + @")) AS INT)) FROM " + table;
            DataTable result = workWithDatabase.loadDataFromDB(command);
            return frefix + result.Rows[0][0].ToString();
        }

        public string createNewId(string oldId, int lengthDelete)
        {
            string number = oldId.Substring(lengthDelete, oldId.Length - lengthDelete);
            int newNumber = int.Parse(number) + 1;
            if(newNumber < 10)
            {
                return oldId.Substring(0, lengthDelete) + "0" +  newNumber.ToString();

            }
            else
            {
                return oldId.Substring(0, lengthDelete) + newNumber.ToString();

            }

        }
        public string findPostionIdbyName(string name, string typeAcc)
        {
            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            string commandFindPostionId = "";
            if (typeAcc == "Admin")
            {
                commandFindPostionId = @"SELECT maChucVu FROM ChucVu
                                    WHERE tenChucVu  COLLATE Latin1_General_CS_AS = N'" + name + "'";
            }   
            else
            {
                string maPhongBan = typeAcc.Substring(6, typeAcc.Length - 6);

                commandFindPostionId = @"SELECT maChucVu FROM ChucVu
                                    WHERE tenChucVu  COLLATE Latin1_General_CS_AS = N'" + name + "' AND " +
                                "maPhongBan  COLLATE Latin1_General_CS_AS = '" + maPhongBan + "'";
            }
            
            DataTable dtPostition = workWithDatabase.loadDataFromDB(commandFindPostionId);
            string positionId = dtPostition.Rows[0][0].ToString();
            return positionId;
        }

        public void addSalary(string typeAcc, string idEmp, string salary, string bounus, string allowances, string advances, string date)
        {
            if (typeAcc != "" && idEmp != "" && salary != "" && bounus != "" && allowances != "" && advances != "" && date != "")
            {
                bool checkExist = checkEmpExist(idEmp, typeAcc);// Check employee exist in database
                if (checkExist)
                {
                    //check exist salary in this month
                    WorkWithDatabase workWithDatabase = new WorkWithDatabase();
                    string command2 = @"SELECT * FROM Luong
                                    WHERE maNV COLLATE Latin1_General_CS_AS  = '" + idEmp + "' AND thangNam = '" + date + "'";
                    DataTable dt2 = workWithDatabase.loadDataFromDB(command2);
                    if (dt2.Rows.Count == 0)
                    {
                        // check month of salary with date join company
                        int yearSal = int.Parse(date.Substring(0, 4));
                        int monthSal = int.Parse(date.Substring(5, date.Length - 5));
                        DateTime dateSal = new DateTime(yearSal, monthSal, DateTime.DaysInMonth(yearSal, monthSal));
                        bool checkSalMoreDateJoin = isDateMoreThenJoinDate(idEmp, dateSal);
                        if (!checkSalMoreDateJoin)
                        {
                            MessageBox.Show("Không thể thêm lương vào tháng " + dateSal.Month + "/" + dateSal.Year +
                                " vì lúc đó nhân viên vẫn chưa vào công ty.");
                        }
                        else
                        {
                            string id = createNewId(findMaxId("Luong", "maLuong", 2, "LU"), 2);
                            string comandAdd = @"INSERT INTO Luong(maLuong, maNV, thangNam, luongCung, luongThuong, luongUngTruoc, phuCap)" +
                                            @"VALUES ('" + id + "', '" + idEmp + "', '" + date + "', " + salary + "," + bounus
                                                + "," + advances + "," + allowances + ")";
                            workWithDatabase.modifierDB(comandAdd);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại thông tin về lương của nhân viên có mã nhân viên là " + idEmp + " trong năm tháng: " + date);
                    }

                }
                else
                {
                    MessageBox.Show("Mã nhân viên không tồn tại trong hệ thống!");
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
            }
        }

        public bool checkEmpExist(string idEmp, string typeAcc)
        {
            if (typeAcc == "Admin")
            {
                WorkWithDatabase workWithDatabase = new WorkWithDatabase();
                string command = @"SELECT * FROM NhanVien " +
                                   @"LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu " +
                                   @"LEFT JOIN PhongBan on ChucVu.maPhongBan = PhongBan.maPhongBan " +
                                  @"WHERE maNV COLLATE Latin1_General_CS_AS  = '" + idEmp + "'";
                DataTable dt = workWithDatabase.loadDataFromDB(command);
                bool check = (dt.Rows.Count > 0);
                return check;
            }
            else
            {
                string department = typeAcc.Substring(6, typeAcc.Length - 6);
                WorkWithDatabase workWithDatabase = new WorkWithDatabase();
                string command = @"SELECT * FROM NhanVien " +
                                   @"LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu " +
                                   @"LEFT JOIN PhongBan on ChucVu.maPhongBan = PhongBan.maPhongBan " +
                                  @"WHERE maNV  COLLATE Latin1_General_CS_AS = '" + idEmp +
                                  "' AND PhongBan.maPhongBan  COLLATE Latin1_General_CS_AS = '" + department + "'";
                DataTable dt = workWithDatabase.loadDataFromDB(command);
                bool check = (dt.Rows.Count != 0);
                return check;
            }

        }
        public bool isDateMoreThenJoinDate(string idEmp, DateTime date)
        {
            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            string comnandGetDateJoin = @"SELECT ngayVaoCTy FROM NhanVien " +
                                                    @"WHERE maNV  COLLATE Latin1_General_CS_AS = '" + idEmp + "'";
            DateTime dateJoin = (DateTime)(workWithDatabase.loadDataFromDB(comnandGetDateJoin).Rows[0][0]);
            bool check = date >= dateJoin;
            return check;
        }

        public void addOnLeave(string typeAcc, string idEmp, DateTime dateTo, DateTime dateFrom)
        {
            if (idEmp == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!");
            }
            else
            {
                bool checkExits = checkEmpExist(idEmp, typeAcc);//check employee  exist
                if (checkExits)
                {
                    dateTo = dateTo.AddTicks(-(dateTo.Ticks % TimeSpan.TicksPerSecond));
                    dateFrom = dateFrom.AddTicks(-(dateFrom.Ticks % TimeSpan.TicksPerSecond));
                    int resultComparet = DateTime.Compare(dateTo, dateFrom);
                    // compare date to with date from
                    if (resultComparet == 0 || resultComparet > 0)
                    {
                        // check for data conficts
                        bool checkConficts = true;
                        if (dateFrom.Month != dateTo.Month)
                        {
                            DataTable table1 = getAllOnLeaveInMonth(idEmp, dateFrom.Year, dateFrom.Month, typeAcc);
                            DataTable table2 = getAllOnLeaveInMonth(idEmp, dateTo.Year, dateTo.Month, typeAcc);
                            bool checkConficts1 = isConficstTime("", table1, dateTo, dateFrom);
                            bool checkConficts2 = isConficstTime("", table2, dateTo, dateFrom);
                            if (checkConficts1 == false && checkConficts2 == false)
                            {
                                checkConficts = false;
                            }
                        }
                        else
                        {
                            DataTable table = getAllOnLeaveInMonth(idEmp, dateFrom.Year, dateFrom.Month, typeAcc);
                            checkConficts = isConficstTime("", table, dateTo, dateFrom);
                        }
                        if (checkConficts == false)
                        {

                            // check with date join
                            bool checkWithDateJoin = isDateMoreThenJoinDate(idEmp, dateFrom);
                            if (checkWithDateJoin)
                            {
                                //create new id
                                string oldId = findMaxId("NghiPhep", "maNghiPhep", 2, "NP");
                                string newId = createNewId(oldId, 2);
                                string strCommand = " INSERT INTO NghiPhep (maNghiPhep, maNV, tuNgay, denNgay) " +
                                                    "VALUES ('" + newId + "', '" + idEmp + "' , '" + dateFrom.ToString("yyyy-MM-dd") +
                                                     "' , '" + dateTo.ToString("yyyy-MM-dd") + "')";
                                WorkWithDatabase work = new WorkWithDatabase();
                                work.modifierDB(strCommand);
                            }
                            else
                            {
                                MessageBox.Show("Thông tin không hợp lệ do xung đột với ngày nhân viên vào công ty!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ngày bắt đầu nghỉ không thể lớn hơn ngày kết thúc!");
                    }

                }
                else
                {
                    MessageBox.Show("Mã nhân viên không tồn tại!");
                }

            }
        }

        public DataTable getAllOnLeaveInMonth(string idEmp, int year, int month, string typeAcc)
        {
            

            string strMonth = "";
            if (month > 9)
            {
                strMonth = month.ToString();
            }
            else
            {
                strMonth = "0" + month;
            }
            string strCommandOnLeave = "";
            if (typeAcc == "Admin")
            {
                strCommandOnLeave = @"select maNghiPhep, NghiPhep.maNV, hoTen, tenChucVu, tenPhongBan, tuNgay, denNgay from NghiPhep " +
                                         @"LEFT JOIN NhanVien ON NhanVien.maNV = NghiPhep.maNV " +
                                         @"LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu " +
                                         @"LEFT JOIN PhongBan ON PhongBan.maPhongBan = ChucVu.maPhongBan " +
                                         @"WHERE ( (MONTH(tuNgay) = '" + month + "' AND YEAR(tuNgay) = '" + year + "') OR " +
                                       "(MONTH(denNgay) = '" + month + "' AND YEAR(denNgay) = '" + year + "')) AND NghiPhep.maNV  COLLATE Latin1_General_CS_AS = '" + idEmp + "'";
            }
            else
            {
                string maPhongBan = typeAcc.Substring(6, typeAcc.Length - 6);
                strCommandOnLeave = @"select maNghiPhep,  NghiPhep.maNV, hoTen, tenChucVu, tenPhongBan, tuNgay, denNgay from NghiPhep " +
                                         @"LEFT JOIN NhanVien ON NhanVien.maNV = NghiPhep.maNV " +
                                         @"LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu " +
                                         @"LEFT JOIN PhongBan ON PhongBan.maPhongBan = ChucVu.maPhongBan " +
                                         @"WHERE ( (MONTH(tuNgay) = '" + month + "' AND YEAR(tuNgay) = '" + year + "') OR " +
                                        "(MONTH(denNgay) = '" + month + "' AND YEAR(denNgay) = '" + year + "'))" +
                                        " AND PhongBan.maPhongBan = '" + maPhongBan + "'" + " AND NghiPhep.maNV  COLLATE Latin1_General_CS_AS = '" + idEmp + "'";
            }

            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            DataTable dataTable = workWithDatabase.loadDataFromDB(strCommandOnLeave);
            dataTable.Columns[0].ColumnName = "Mã nghỉ phép";
            dataTable.Columns[1].ColumnName = "Mã nhân viên";
            dataTable.Columns[2].ColumnName = "Họ tên nhân viên";
            dataTable.Columns[3].ColumnName = "Chức vụ";
            dataTable.Columns[4].ColumnName = "Phòng ban";
            dataTable.Columns[5].ColumnName = "Nghỉ từ ngày";
            dataTable.Columns[6].ColumnName = "Nghỉ đến ngày";
            return dataTable;

        }

        public bool isConficstTime(string idOnLeave, DataTable table, DateTime timeTo, DateTime timeFrom)
        {
            string strTimeTo = timeTo.ToString("yyyy/MM/dd");
            string strTimeFrom = timeFrom.ToString("yyyy/MM/dd");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string strFrom = ((DateTime)table.Rows[i][5]).ToString("yyyy/MM/dd");
                string strTo = ((DateTime)table.Rows[i][6]).ToString("yyyy/MM/dd");
                int compare = string.Compare(strFrom, strTimeFrom);

                if (!(string.Compare(strFrom, strTimeTo) > 0 || string.Compare(strTo, strTimeFrom) < 0))
                {
                    if(idOnLeave == table.Rows[i][0].ToString())
                    {
                        return false;
                    }
                    else
                    {
                        string dateFrom = ((DateTime)table.Rows[i][5]).ToString("dd/MM/yyyy");
                        string dateTo = ((DateTime)table.Rows[i][6]).ToString("dd/MM/yyyy");
                        MessageBox.Show("Xung đột dữ liệu với lần nghỉ phép: từ " + dateFrom + " đến: " + dateTo);
                        return true;
                    }
                    
                }
            }
            return false;
        }

        public void RepairEmployee(string typeAcc, string idEmp, string fullName, string address, string phoneNumber, string identifyId, string mail,
            string dateBirth, string dateJoin, string gender, string position)
        {
            if (fullName == "" || address == "" || phoneNumber == "" || identifyId == "" || mail == "" || gender == "" || position == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else
            {
                WorkWithDatabase workWithDatabase = new WorkWithDatabase();
                string positionId = findPostionIdbyName(position, typeAcc);

                string comandAdd = "UPDATE NhanVien " +
                                    "SET hoTen = N'" + fullName +
                                    "', diaChi = N'" + address +
                                    "', sdt = '" + phoneNumber +
                                    "', cccd = '" + identifyId +
                                    "', mail = '" + mail +
                                    "', ngaySinh = '" + dateBirth +
                                    "', ngayVaoCTy = '" + dateJoin +
                                    "', gioiTinh = N'" + gender +
                                    "', maChucVu = '" + positionId +
                                    "' WHERE maNV = '" + idEmp + "'";
                workWithDatabase.modifierDB(comandAdd);

            }
        }

        public DataTable getInforEmpById(string idEmp, string typeAcc)
        {
            DataTable dt = new DataTable();
            if (typeAcc == "Admin")
            {
                WorkWithDatabase workWithDatabase = new WorkWithDatabase();
                string command = @"SELECT * FROM NhanVien  LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu " +
                                    "WHERE maNV  COLLATE Latin1_General_CS_AS = '" + idEmp + "'";
                dt = workWithDatabase.loadDataFromDB(command);
            }
            else
            {
                string maPhongBan = typeAcc.Substring(6, typeAcc.Length - 6);
                WorkWithDatabase workWithDatabase = new WorkWithDatabase();
                string command = @"SELECT * FROM NhanVien  LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu " +
                                    " LEFT JOIN PhongBan ON PhongBan.maPhongBan = ChucVu.maPhongBan  " +
                                    "WHERE maNV COLLATE Latin1_General_CS_AS  = '" + idEmp + "'" +
                                    " AND PhongBan.maPhongBan COLLATE Latin1_General_CS_AS  = '" + maPhongBan + "'";
                dt = workWithDatabase.loadDataFromDB(command);
            }
            return dt;
        }

        public void RemoveData(string table, string column, string value)
        {
            WorkWithDatabase work = new WorkWithDatabase();
            string command = "DELETE FROM " + table + " WHERE " + " " + column + " = " + value;
            work.modifierDB(command);
        }
        public void repairSalary(string typeAcc, string idEmp, string salary, string bonus, string allowances,
            string advances, DateTime date)
        {
            WorkWithDatabase work = new WorkWithDatabase();
            string monthYear = date.Year + "-" + date.Month;
            if (date.Month < 10)
            {
                monthYear = date.Year + "-0" + date.Month;

            }
            // check exist salary
            string strCheckExistSal = " SELECT * FROM Luong " +
                                        " WHERE maNV  COLLATE Latin1_General_CS_AS = '" + idEmp + "' " +
                                        " AND thangNam = '" + monthYear + "'";
            DataTable dataTable = work.loadDataFromDB(strCheckExistSal);
            if (dataTable.Rows.Count > 0)
            {
                string strCommand = "UPDATE luong " +
                                    " SET luongCung = " + salary +
                                    " , luongthuong = " + bonus +
                                    " , luongUngTruoc = " + advances +
                                    " ,  phuCap = " + allowances +
                                    " WHERE maNV COLLATE Latin1_General_CS_AS  = '" + idEmp + "' " +
                                    " AND thangNam = '" + monthYear + "'";
                work.modifierDB(strCommand);
                MessageBox.Show("Thay đổi thông tin thành công!");

            }
            else
            {
                MessageBox.Show("Không thể thay đổi vì không tồn tại lương của nhân viên với mã nhân viên: " + idEmp +
                    " ở tháng năm: " + monthYear + "!");
            }

        }

        public void removeSalary(string typeAcc, string idEmp, DateTime date)
        {
            WorkWithDatabase work = new WorkWithDatabase();
            string monthYear = date.Year + "-" + date.Month;
            if (date.Month < 10)
            {
                monthYear = date.Year + "-0" + date.Month;

            }
            // check exist salary
            string strCheckExistSal = " SELECT * FROM Luong " +
                                        " WHERE maNV COLLATE Latin1_General_CS_AS  = '" + idEmp + "' " +
                                        " AND thangNam = '" + monthYear + "'";
            DataTable dataTable = work.loadDataFromDB(strCheckExistSal);
            if (dataTable.Rows.Count > 0)
            {
                string strCommand = "DELETE FROM luong " +
                                    " WHERE maNV  COLLATE Latin1_General_CS_AS = '" + idEmp + "' " +
                                    " AND thangNam = '" + monthYear + "'";
                work.modifierDB(strCommand);
                MessageBox.Show("Xóa thành công!");

            }
            else
            {
                MessageBox.Show("Không thể xóa vì không tồn tại lương của nhân viên với mã nhân viên: " + idEmp +
                    " ở tháng năm: " + monthYear + "!");
            }
        }

        public void removeOnLeave(string idOnLeave)
        {
            WorkWithDatabase work = new WorkWithDatabase();


            string strCommand = "DELETE nghiPhep " +
                                " WHERE maNghiPhep = '" + idOnLeave + "' ";
            work.modifierDB(strCommand);

        }

        public DataTable getOnLeaveByIdEmp(string idEmp, int year, int month)
        {
            DateTime startMonth = new DateTime(year, month, 1);
            DateTime endMonth = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            string strMonth = "";
            if (month > 9)
            {
                strMonth = month.ToString();
            }
            else
            {
                strMonth = "0" + month;
            }

            string strCommandOnLeave = @"select maNghiPhep, NghiPhep.maNV, hoTen, tenChucVu, tenPhongBan, tuNgay, denNgay from NghiPhep
                                    LEFT JOIN NhanVien ON NhanVien.maNV = NghiPhep.maNV
                                    LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu
                                    LEFT JOIN PhongBan ON PhongBan.maPhongBan = ChucVu.maPhongBan
                                    WHERE  tuNgay <= '" + endMonth + "' AND denNgay >= '" + startMonth + "'" + 
                                    " AND NghiPhep.maNV = '" +
                                    idEmp + "'";

            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            DataTable tblOnLeave = workWithDatabase.loadDataFromDB(strCommandOnLeave);
            // Create new columns to store formatted dates
            tblOnLeave.Columns.Add("FormattedDateFrom", typeof(string));
            tblOnLeave.Columns.Add("FormattedDateTo", typeof(string));

            foreach (DataRow row in tblOnLeave.Rows)
            {
                if (!row.IsNull(5))
                {
                    DateTime dateBirth = (DateTime)row[5];
                    string formattedDateBirth = dateBirth.ToString("dd/MM/yyyy");
                    row["FormattedDateFrom"] = formattedDateBirth;
                }

                if (!row.IsNull(6))
                {
                    DateTime dateJoin = (DateTime)row[6];
                    string formattedDateJoin = dateJoin.ToString("dd/MM/yyyy");
                    row["FormattedDateTo"] = formattedDateJoin;
                }
            }
            return tblOnLeave;


        }


        public void repairOnLeave(string idOnLeave, DateTime dateFrom, DateTime dateTo, string idEmp, string typeAcc)
        {
            dateTo = dateTo.AddTicks(-(dateTo.Ticks % TimeSpan.TicksPerSecond));
            dateFrom = dateFrom.AddTicks(-(dateFrom.Ticks % TimeSpan.TicksPerSecond));
            int resultComparet = DateTime.Compare(dateTo, dateFrom);
            // compare date to with date from
            if (resultComparet == 0 || resultComparet > 0)
            {
                // check for data conficts
                bool checkConficts = true;
                if (dateFrom.Month != dateTo.Month)
                {

                    DataTable table1 = getAllOnLeaveInMonth(idEmp, dateFrom.Year, dateFrom.Month, typeAcc);
                    DataTable table2 = getAllOnLeaveInMonth(idEmp, dateTo.Year, dateTo.Month, typeAcc);
                    bool checkConficts1 = isConficstTime(idOnLeave, table1, dateTo, dateFrom);
                    bool checkConficts2 = isConficstTime(idOnLeave, table2, dateTo, dateFrom);
                    if (checkConficts1 == false && checkConficts2 == false)
                    {
                        checkConficts = false;
                    }
                }
                else
                {
                    DataTable table = getAllOnLeaveInMonth(idEmp, dateFrom.Year, dateFrom.Month, typeAcc);
                    checkConficts = isConficstTime(idOnLeave, table, dateTo, dateFrom);
                }
                if (checkConficts == false)
                {

                    // check with date join
                    bool checkWithDateJoin = isDateMoreThenJoinDate(idEmp, dateFrom);
                    if (checkWithDateJoin)
                    {
                        //create new id
                        string strCommand = " UPDATE NghiPhep " +
                                            "SET tuNgay = '" + dateFrom.ToString("yyyy-MM-dd") +
                                             "' , denNgay = '" + dateTo.ToString("yyyy-MM-dd") + "' " +
                                             " WHERE maNghiPhep COLLATE Latin1_General_CS_AS  = '" + idOnLeave + "'";
                        WorkWithDatabase work = new WorkWithDatabase();
                        work.modifierDB(strCommand);
                        MessageBox.Show("Sửa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thông tin không hợp lệ do xung đột với ngày nhân viên vào công ty!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ do ngày bắt đầu nghỉ không thể lớn hơn ngày kết thúc!");
            }
        }

        public DataTable searchAccount(DataTable tablePosition, string idEmp, string nameLogin, string position, string department, string fullName)
        {
            DataTable result = new DataTable();
            result.Columns.Add("Mã tài khoản");
            result.Columns.Add("Tên đăng nhập");
            result.Columns.Add("mã nhân viên");
            result.Columns.Add("Họ tên");
            result.Columns.Add("Tên chức vụ");
            result.Columns.Add("Tên phòng ban");
            result.Columns.Add("Loại tài khoản");
            for (int i = 0; i < tablePosition.Rows.Count; i++)
            {
                if (idEmp != "")
                {
                    if (!tablePosition.Rows[i][2].ToString().Contains(idEmp))
                    {
                        continue;
                    }    
                }

                if (nameLogin != "")
                {
                    if (!tablePosition.Rows[i][1].ToString().Contains(nameLogin))
                    {
                        continue;
                    }
                }

                if (position != "" && position != "Tất cả")
                {
                    if (position != tablePosition.Rows[i][4].ToString())
                    {
                        continue;
                    }
                }

                if (department != "" && department != "Tất cả")
                {
                    if (department != tablePosition.Rows[i][5].ToString())
                    {
                        continue;
                    }
                }

                if (fullName != "")
                {
                    if (!tablePosition.Rows[i][3].ToString().Contains(fullName))
                    {
                        continue;
                    }
                }

                //Import the current row from sourceTable into destinationTable
                DataRow newRow = result.NewRow();
                newRow.ItemArray = tablePosition.Rows[i].ItemArray; // Copies the entire row data

                // Add the imported row to the destinationTable
                result.Rows.Add(newRow);
            }
            
            return result;
        }


        public DataTable loadTableDepartment()
        {
            string strCommandPosition = @"SELECT tenPhongBan FROM PhongBan";
            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            DataTable tblPosition = workWithDatabase.loadDataFromDB(strCommandPosition);
            return tblPosition;
        }

        public DataTable findAccByUserName(string userName)
        {
            string command = " SELECT * FROM TaiKhoan WHERE tenDangNhap  COLLATE Latin1_General_CS_AS = '" + userName + "'";
            WorkWithDatabase work = new WorkWithDatabase();
            return work.loadDataFromDB(command);
        }

        public DataTable findAccByIdEmp(string idEmp)
        {
            string command = " SELECT * FROM TaiKhoan WHERE maNV  COLLATE Latin1_General_CS_AS = '" + idEmp + "'";
            WorkWithDatabase work = new WorkWithDatabase();
            return work.loadDataFromDB(command);
        }

        public void addAccount(string idEmp, string userName, string password, string typeAcc)
        {
            if(idEmp == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
                return;
            }
            if (userName == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
                return;
            }
            if (password == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
                return;
            }
            if (typeAcc == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
                return;
            }
            if (!checkEmpExist(idEmp, "Admin"))
            {
                MessageBox.Show("Nhân viên không tồn tại trong hệ thống!");

                return;
            }
            if(findAccByUserName(userName).Rows.Count > 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
                return;
            }
            if(password.Length < 5)
            {
                MessageBox.Show("Mật khẩu cần nhỏ hơn 5");
            }
            if(findAccByIdEmp(idEmp).Rows.Count == 0)
            {
                string idMax = findMaxId("TaiKhoan", "maTK", 2, "TK");
                string idAcc = createNewId(idMax, 2);
                string command = " INSERT INTO TaiKhoan(maTK, tenDangNhap, matKhau, maNV, loaiTK) VALUES ('" + idAcc + "', '" + userName
                    + "', '" + password + "', '" + idEmp + "', '" + typeAcc + "'" + ");";
                WorkWithDatabase work = new WorkWithDatabase();
                work.modifierDB(command);
                MessageBox.Show("Thêm tài khoản thành công!");
            }    
            else
            {
                MessageBox.Show("Đã tồn tại tài khoản cho nhân viên này!");
            }


        }

        public string getIdDepartmentByName(string name)
        {
            string command = "SELECT maPhongBan from PhongBan WHERE tenPhongBan COLLATE Latin1_General_CS_AS  = N'" + name + "'";
            WorkWithDatabase work = new WorkWithDatabase();
            DataTable tbl = work.loadDataFromDB(command);
            return tbl.Rows[0][0].ToString();
        }

        public DataTable getInforbyIdAcc(string id)
        {
            string strCommand = "SELECT maTK, tenDangNhap, NhanVien.maNV, hoTen,matKhau, tenChucVu, tenPhongBan,loaiTK FROM TaiKhoan " +
                               " LEFT JOIN NhanVien ON NhanVien.maNV = TaiKhoan.maNV " +
                               " LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu " +
                               " LEFT JOIN PhongBan ON PhongBan.maPhongBan = ChucVu.maPhongBan " +
                               " WHERE maTK  COLLATE Latin1_General_CS_AS = '" + id + "'";
            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            DataTable result = workWithDatabase.loadDataFromDB(strCommand);
            result.Columns[0].ColumnName = "Mã tài khoản";
            result.Columns[1].ColumnName = "Tên đăng nhập";
            result.Columns[2].ColumnName = "mã nhân viên";
            result.Columns[3].ColumnName = "Họ tên";
            result.Columns[4].ColumnName = "Tên chức vụ";
            result.Columns[5].ColumnName = "Tên phòng ban";
            result.Columns[6].ColumnName = "Loại tài khoản";
            return result;
        }

        public string getNameDepbyIdDep(string id)
        {
            string command = "SELECT tenPhongBan from PhongBan WHERE maPhongBan COLLATE Latin1_General_CS_AS  = N'" + id + "'";
            WorkWithDatabase work = new WorkWithDatabase();
            DataTable tbl = work.loadDataFromDB(command);
            if(tbl.Rows.Count > 0)
            {
                return tbl.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên phòng ban có mã: " + id);
                return "";
            }
        }
         
        public void repairAcc(string idAcc, string typeAcc)
        {
            string command = "UPDATE TaiKhoan " +
                              " SET loaiTK = '" + typeAcc + "' " +
                              " WHERE maTK   COLLATE Latin1_General_CS_AS = '" + idAcc + "'";
            WorkWithDatabase work = new WorkWithDatabase();
            work.modifierDB(command);
            MessageBox.Show("Thay đổi tài khoản thành công!");
        }

        public bool checkIdAccExit(string idAcc) 
        {
            string command = "SELECT * FROM TaiKhoan WHERE maTK  COLLATE Latin1_General_CS_AS  = '" + idAcc + "'";
            WorkWithDatabase work = new WorkWithDatabase();
            DataTable tb = work.loadDataFromDB(command);
            if(tb.Rows.Count > 0)
            {
                return true;
            }    
            else
            {
                return false;
            }
        }

        public void removeAccByIdAcc(string idAcc) 
        {
            string command = "DELETE FROM TaiKhoan WHERE maTK  COLLATE Latin1_General_CS_AS = '" + idAcc + "'";
            WorkWithDatabase work = new WorkWithDatabase();
            work.modifierDB(command);
            MessageBox.Show("Xoá tài khoản thành công!");
        }

        public bool checkNameDepExit(string name)
        {
            DataTable dtDepartment = loadDepartment();
            for (int i = 0; i < dtDepartment.Rows.Count; i++)
            {
                if (name == dtDepartment.Rows[i][1].ToString())
                {
                    MessageBox.Show("Tên phòng ban đã tồn tại. Vui lòng nhập tên khác!");
                    return true;
                }
            }
            return false;
        }
        public void addDepartment(string name)
        {
            if(!checkNameDepExit(name))
            {
                string idMax = findMaxId("PhongBan", "maPhongBan", 2, "PB");
                string idDep = createNewId(idMax, 2);
                string command = "INSERT INTO PhongBan(maPhongBan, tenPhongBan) VALUES('" + idDep + "', N'" + name + "');";
                WorkWithDatabase work = new WorkWithDatabase();
                work.modifierDB(command);
                MessageBox.Show("Thêm phòng ban thành công!");
            }
           
        }
        
        public DataTable findDepByIdDep(string idDep) 
        {
            string command = "SELECT * FROM PhongBan WHERE maPhongBan  COLLATE Latin1_General_CS_AS = '" + idDep + "'";
            WorkWithDatabase work = new WorkWithDatabase();
            return work.loadDataFromDB(command);

        }
        public void removeDepartment(string id)
        {
            
            DataTable tbl = findDepByIdDep(id);
            if(tbl.Rows.Count > 0)
            {
                bool check = checkDeparExistEmp(id);
                if (check)
                {
                    MessageBox.Show("Không thể xóa phòng ban. Hãy đảm bảo không có nhân viên nào ở trong phòng ban này trước khi xóa.");
                    return;
                }
                else
                {

                    DialogResult result = MessageBox.Show("Nếu xóa thì tất cả thông tin về chức vụ trong phòng ban này đều sẽ bị xóa?",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Check the user's choice
                    if (result == DialogResult.Yes)
                    {
                        string command = "DELETE FROM PhongBan WHERE maPhongBan  COLLATE Latin1_General_CS_AS = '" + id + "'";
                        string command1 = "DELETE FROM ChucVu WHERE maPhongBan  COLLATE Latin1_General_CS_AS = '" + id + "'";
                        WorkWithDatabase work = new WorkWithDatabase();
                        work.modifierDB(command1);
                        work.modifierDB(command);
                        MessageBox.Show("Xóa phòng ban thành công!");
                    }    
                }
                
            }
            else
            {
                MessageBox.Show("Không tìm thấy phòng ban nào có mã phòng ban là: " + id);
            }
        }

        public void repairDepartment(string id, string newName) 
        {
            DataTable tbl = findDepByIdDep(id);
            if (tbl.Rows.Count > 0)
            {
                if (!checkNameDepExit(newName))
                {
                    string command = "UPDATE PhongBan " +
                                "SET tenPhongBan = N'" + newName + "' " +
                                " WHERE maPhongBan  COLLATE Latin1_General_CS_AS = '" + id + "'";
                    WorkWithDatabase work = new WorkWithDatabase();
                    work.modifierDB(command);
                    MessageBox.Show("Sửa phòng ban thành công!");
                }
                
            }
            else
            {
                MessageBox.Show("Không tìm thấy phòng ban nào có mã phòng ban là: " + id);
            }
        }

        public void addPosition(string namePosition, string nameDepartment)
        {
            string idDepartment =  getIdDepartmentByName(nameDepartment);
            string idMax = findMaxId("Chucvu", "maChucVu", 2, "CV");
            string newId = createNewId(idMax, 2);
            string command = "INSERT INTO ChucVu (maChucVu, tenChucVu, maPhongBan)" + 
                               "VALUES ('" + newId + "', N'" + namePosition + "', '" + idDepartment + "')";
            WorkWithDatabase work = new WorkWithDatabase();
            work.modifierDB(command);
            MessageBox.Show("Thêm chức vụ thành công!");
        }
        
        public bool checkPositionExist(string id)
        {
            DataTable tblPosition = loadPosition();
            for (int i = 0; i < tblPosition.Rows.Count; i++)
            {
                if (id == tblPosition.Rows[i][0].ToString())
                {
                    return true;
                }
            }
            return false;
        }

        public bool checkPositionExistEmp(string idPos)
        {
            string command = "SELECT * FROM NhanVien LEFT JOIN ChucVu ON ChucVu.maChucVu = NhanVien.maChucVu " +
                                " WHERE ChucVu.maChucVu = '" + idPos + "'";
            WorkWithDatabase work = new WorkWithDatabase();
            DataTable dt =  work.loadDataFromDB(command);
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }    
        }

        public bool checkDeparExistEmp(string id)
        {
            string command = "SELECT maChucVu FROM PhongBan " +
                " LEFT JOIN ChucVu ON ChucVu.maPhongBan = PhongBan.maPhongBan" +
                " WHERE PhongBan.maPhongBan = '" + id + "'";
            WorkWithDatabase work = new WorkWithDatabase();
            DataTable dt = work.loadDataFromDB(command);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (checkPositionExistEmp(dt.Rows[i][0].ToString()))
                {
                    return true;
                }
            }
            return false;
        }
        public void removePosition(string id) 
        {
            if(checkPositionExistEmp(id))
            {
                MessageBox.Show("Không thể xóa chức vụ vì có nhân viên đang có thông tin về chức vụ hiện tại. " +
                    "Hãy đảm bảo chức vụ bạn muốn xóa không có nhân viên nào đang nắm giữ.");
                return;
            }
            if (checkPositionExist(id))
            {
                string command = " DELETE FROM ChucVu WHERE maChucVu = '" + id + "'";
                WorkWithDatabase work = new WorkWithDatabase();
                work.modifierDB(command);
                MessageBox.Show("Xóa chức vụ thành công!");
            }
        }

        public void repairPosition(string id, string namePosition, string idDepartment)
        {
            if(checkPositionExist(id)) 
            {
                string command = " UPDATE ChucVu " +
                                    " SET tenChucvu = N'" + namePosition + "', " +
                                    " maPhongBan = '" + idDepartment + "' " +
                                    " WHERE maChucVu = '" + id + "'";
                WorkWithDatabase work = new WorkWithDatabase();
                work.modifierDB(command);
                MessageBox.Show("Sửa chức vụ thành công!");
            }

        }

        public DataTable getInforPositionbyIdPos(string id)
        {
            string strCommand = "SELECT maChucVu, tenChucVu, tenPhongBan FROM ChucVu " +
                                " LEFT JOIN PhongBan ON ChucVu.maPhongBan = PhongBan.maPhongBan " +
                                " WHERE maChucVu = '" + id + "'";
            WorkWithDatabase work = new WorkWithDatabase();
            return work.loadDataFromDB(strCommand);
        }

        public DataTable findPosition( string idPosition, string namePosition, string nameDepartment) 
        {
            DataTable tblPosition = loadPosition();
            DataTable result = new DataTable();
            result.Columns.Add("Mã chức vụ");
            result.Columns.Add("Tên chức vụ");
            result.Columns.Add("Tên phòng ban");
            for(int i = 0; i < tblPosition.Rows.Count; i++) 
            {
                if(idPosition != "")
                {
                    if (!tblPosition.Rows[i][0].ToString().Contains(idPosition))
                    {
                        continue;
                    }
                }

                if (namePosition != "")
                {
                    if (!tblPosition.Rows[i][1].ToString().Contains(namePosition))
                    {
                        continue;
                    }
                }

                if (nameDepartment != "" && nameDepartment != "Tất cả")
                {
                    if (tblPosition.Rows[i][2].ToString() != nameDepartment)
                    {
                        continue;
                    }
                }

                // Import the current row from sourceTable into destinationTable
                DataRow newRow = result.NewRow();
                newRow.ItemArray = tblPosition.Rows[i].ItemArray; // Copies the entire row data

                // Add the imported row to the destinationTable
                result.Rows.Add(newRow);
            }
            return result;
        }

        public DataTable findOT(string typeAcc,string idOT,string idEmp, string name,int timeOT, string typeOT,int month,int year,
            string position, string department, bool checkTimeOT)
        {
            DataTable result = new DataTable();
            result.Columns.Add("Mã tăng ca");
            result.Columns.Add("Mã nhân viên");
            result.Columns.Add("Tên nhân viên");
            result.Columns.Add("Chức vụ");
            result.Columns.Add("Phòng ban");
            result.Columns.Add("Số giờ tăng ca");
            result.Columns.Add("Loại tăng ca");
            result.Columns.Add("ngày");
            DataTable tbl = loadOT(typeAcc, month, year);
            for(int i = 0; i < tbl.Rows.Count; i++) 
            {
                if(idOT != "")
                {
                    if (!tbl.Rows[i][0].ToString().Contains(idOT))
                    {
                        continue;
                    }
                }
                if (idEmp != "")
                {
                    if (!tbl.Rows[i][1].ToString().Contains(idEmp))
                    {
                        continue;
                    }
                }
                if (name != "")
                {
                    if (!tbl.Rows[i][2].ToString().Contains(name))
                    {
                        continue;
                    }
                }
                if(tbl.Rows[i][3].ToString() != position && position != "Tất cả")
                {
                    continue;
                }
                if (tbl.Rows[i][4].ToString() != department && department != "Tất cả")
                {
                    continue;
                }
                if ((int)tbl.Rows[i][5] != timeOT && checkTimeOT == true)
                {
                    continue;
                }
                if (tbl.Rows[i][6].ToString() != typeOT && typeOT != "Tất cả")
                {
                    continue;
                }

                // Import the current row from sourceTable into destinationTable
                DataRow newRow = result.NewRow();
                newRow.ItemArray = tbl.Rows[i].ItemArray; // Copies the entire row data

                // Add the imported row to the destinationTable
                result.Rows.Add(newRow);
            }
            return result;
        }

        public bool checkOnLeaveExit(DateTime dateOnLeave, string idEmp)
        {
            string command = "select * from NghiPHep "  +
                                " WHERE tuNgay <= '" + dateOnLeave.ToString("yyyy-MM-dd") + 
                                "' AND denNgay >= '" + dateOnLeave.ToString("yyyy-MM-dd") +
                                "' AND maNV = '" + idEmp + "'";
            WorkWithDatabase work = new WorkWithDatabase();
            DataTable dt = work.loadDataFromDB(command);
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            else 
            {
                return false; 
            }
        }
        public void addOT(string typeAcc,string idEmp,int timeOT,DateTime dateOT,string typeOT)
        {
            if(idEmp == "")
            {
                MessageBox.Show("Không được để trống mã nhân viên!");
                return;
            }
            else
            {
                bool check = checkEmpExist(idEmp, typeAcc);
                if (!check) 
                {
                    MessageBox.Show("Không tồn tại nhân viên có mã nhân viên: " + idEmp + " trong hệ thống!");
                    return;
                }
            }
            if (dateOT.DayOfWeek.ToString() != "Sunday" && dateOT.DayOfWeek.ToString() != "Saturday" && typeOT != "Lễ" &&
                timeOT >4)
            {
                MessageBox.Show("Ngày làm việc bình thường không thể tăng ca quá 4h");
                return;
            }    
            bool checkConfixOnLeave = checkOnLeaveExit(dateOT, idEmp);
            if(checkConfixOnLeave)
            {
                MessageBox.Show("Không thể thêm tăng ca vào ngày nhân viên nghỉ phép");
                return;
            }
                //check exist OT in this date
                WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            string command = @"SELECT * FROM TangCa
                                WHERE maNV COLLATE Latin1_General_CS_AS  = '" + idEmp +
                                    "' AND ngay = '" + dateOT.ToString("yyyy/MM/dd") + "'";
            DataTable dt = workWithDatabase.loadDataFromDB(command);

            // check timeOT more range of month
            string command1 = @"SELECT * FROM TangCa
                                WHERE maNV COLLATE Latin1_General_CS_AS  = '" + idEmp + "' AND MONTH(ngay) = '" +
                                    dateOT.Month + "' AND YEAR(ngay) = '" + dateOT.Year + "' AND ngay != '" + dateOT.ToString("yyyy/MM/dd") + "'";
            DataTable dt1 = workWithDatabase.loadDataFromDB(command1);
            int totalTime = 0;
            for (int i = 0; i < dt1.Rows.Count; i++)
            {

                totalTime += int.Parse(dt1.Rows[i]["soGio"].ToString());
            }
            // check timeOT more range of year
            string commandY = @"SELECT * FROM TangCa
                                WHERE maNV COLLATE Latin1_General_CS_AS  = '" + idEmp +
                                "' AND YEAR(ngay) = '" + dateOT.Year + "' AND ngay != '" + dateOT.ToString("yyyy/MM/dd") + "'";
            DataTable dtY = workWithDatabase.loadDataFromDB(commandY);
            int totalTimeY = 0;
            for (int i = 0; i < dtY.Rows.Count; i++)
            {

                totalTimeY += int.Parse(dtY.Rows[i]["soGio"].ToString());
            }
            if (totalTime + timeOT > 40)
            {
                MessageBox.Show("Thời gian tăng ca trong một tháng không được quá 40 giờ. Thời gian tăng ca của nhân viên này trong tháng: " +
                    dateOT.Month + "-" + dateOT.Year + " là: " + totalTime.ToString() + " giờ");
                return;
            }
            if (totalTimeY + timeOT > 200)
            {
                MessageBox.Show("Thời gian tăng ca trong một năm không được quá 200 giờ. Thời gian tăng ca của nhân viên này trong năm: " +
                    +dateOT.Year + " là: " + totalTimeY.ToString() + " giờ");
                return;
            }
            if (dt.Rows.Count == 0)
            {
                // check month of OT with date join company
                bool checkSalMoreDateJoin = isDateMoreThenJoinDate(idEmp, dateOT);
                if (checkSalMoreDateJoin)
                {
                    WorkWithDatabase work = new WorkWithDatabase();
                   
                    //CRATE NEW ID 
                    string idMax = findMaxId("TangCa", "maTangCa", 2, "TC");
                    string newId = createNewId(idMax, 2);
                    //add
                    string command2 = "INSERT INTO TangCa(maTangCa, maNV, soGio, ngay, loai) " +
                                        "VALUES ('" + newId + "', '" + idEmp + "', " + timeOT +
                                        ", '" + dateOT.ToString("yyyy/MM/dd") + "', N'" + typeOT + "')";
                    work.modifierDB(command2);
                    MessageBox.Show("Thêm tăng ca thành công!");
                    
                }
                else
                {
                    MessageBox.Show("Ngày tăng ca xung đột với ngày vào công ty.");
                }
            }
            else
            {
                MessageBox.Show("Nhân viên với mã: " + idEmp + " đã tồn tại thông tin tăng ca của ngày:" + dateOT.ToString("dd/MM/yyyy"));
            }
 
            
        }
        public void repairOT(string typeAcc,string idOT, string idEmp, int timeOT, DateTime dateOT, 
            string typeOT, DateTime oldDate)
        {
            if (idEmp == "")
            {
                MessageBox.Show("Không được để trống mã nhân viên!");
                return;
            }
            else
            {
                bool check = checkEmpExist(idEmp, typeAcc);
                if (!check)
                {
                    MessageBox.Show("Không tồn tại nhân viên có mã nhân viên: " + idEmp + " trong hệ thống!");
                    return;
                }
            }
            if (dateOT.DayOfWeek.ToString() != "Sunday" && dateOT.DayOfWeek.ToString() != "Saturday" && typeOT != "Lễ" &&
                timeOT > 4)
            {
                MessageBox.Show("Ngày làm việc bình thường không thể tăng ca quá 4h");
                return;
            }
            bool checkConfixOnLeave = checkOnLeaveExit(dateOT, idEmp);
            if (checkConfixOnLeave)
            {
                MessageBox.Show("Không thể thêm tăng ca vào ngày nhân viên nghỉ phép");
                return;
            }

            //check exist OT in this date
            WorkWithDatabase workWithDatabase = new WorkWithDatabase();
            string command = @"SELECT * FROM TangCa
                                WHERE maNV COLLATE Latin1_General_CS_AS  = '" + idEmp +
                                    "' AND ngay = '" + dateOT.ToString("yyyy/MM/dd") + "'";
            DataTable dt = workWithDatabase.loadDataFromDB(command);

            // check timeOT more range of month
            string command1 = @"SELECT * FROM TangCa
                                WHERE maNV COLLATE Latin1_General_CS_AS  = '" + idEmp + "' AND MONTH(ngay) = '" +
                                    dateOT.Month + "' AND YEAR(ngay) = '" + dateOT.Year + "' AND ngay != '" + dateOT.ToString("yyyy/MM/dd") + "'";
            DataTable dt1 = workWithDatabase.loadDataFromDB(command1);
            int totalTime = 0;
            for (int i = 0; i < dt1.Rows.Count; i++)
            {

                totalTime += int.Parse(dt1.Rows[i]["soGio"].ToString());
            }
            // check timeOT more range of year
            string commandY = @"SELECT * FROM TangCa
                                WHERE maNV COLLATE Latin1_General_CS_AS  = '" + idEmp +
                                "' AND YEAR(ngay) = '" + dateOT.Year + "' AND ngay != '" + dateOT.ToString("yyyy/MM/dd") + "'";
            DataTable dtY = workWithDatabase.loadDataFromDB(commandY);
            int totalTimeY = 0;
            for (int i = 0; i < dtY.Rows.Count; i++)
            {

                totalTimeY += int.Parse(dtY.Rows[i]["soGio"].ToString());
            }
            if (totalTime + timeOT > 40 )
            {
                MessageBox.Show("Thời gian tăng ca trong một tháng không được quá 40 giờ. Thời gian tăng ca của nhân viên này trong tháng: " +
                    dateOT.Month + "-" + dateOT.Year + " là: " + totalTime.ToString() + " giờ");
                return;
            }
            if (totalTimeY + timeOT > 200)
            {
                MessageBox.Show("Thời gian tăng ca trong một năm không được quá 200 giờ. Thời gian tăng ca của nhân viên này trong năm: " +
                    + dateOT.Year + " là: " + totalTimeY.ToString() + " giờ");
                return;
            }
            if (dt.Rows.Count == 0 || oldDate == dateOT)
            {
                // check month of OT with date join company
                bool checkSalMoreDateJoin = isDateMoreThenJoinDate(idEmp, dateOT);
                if (checkSalMoreDateJoin)
                {
                    WorkWithDatabase work = new WorkWithDatabase();
                    //repair
                    string command2 = "UPDATE TangCa " +
                                        " SET maNV = '" + idEmp + "', " +
                                        " soGio = " + timeOT + ", " +
                                        " ngay = '" + dateOT.ToString("yyyy/MM/dd") + "', " +
                                        " loai = N'" + typeOT + "'" +
                                        "WHERE maTangCa = '" + idOT + "' ";
                    work.modifierDB(command2);
                    MessageBox.Show("Sửa tăng ca thành công!");

                }
                else
                {
                    MessageBox.Show("Ngày tăng ca xung đột với ngày vào công ty.");
                }
            }
            else
            {
                MessageBox.Show("Nhân viên với mã: " + idEmp + " đã tồn tại thông tin tăng ca của ngày:" +
                    dateOT.ToString("dd/MM/yyyy"));
            }
        }

        public DataTable loadOTById(string id)
        {
            DataTable dt = new DataTable();
            string command = "SELECT * FROM TangCa WHERE maTangCa ='" + id + "'";
            WorkWithDatabase work = new WorkWithDatabase();
            dt = work.loadDataFromDB(command);
            return dt;
        }

        public bool checkOTExistById(string id)
        {
            DataTable dt = new DataTable();
            string command = "SELECT * FROM TangCa WHERE maTangCa ='" + id + "'";
            WorkWithDatabase work = new WorkWithDatabase();
            dt = work.loadDataFromDB(command);
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }
        public string getIdDepByTypeAcc(string typeAcc)
        {
            return  typeAcc.Substring(6, typeAcc.Length - 6);
        }
        public string getIdDepByIdEmp(string idEmp) 
        {
            string command = "SELECT PhongBan.maPhongBan FROM NhanVien " +
                             " LEFT JOIN ChucVu ON NhanVien.maChucVu = ChucVu.maChucVu " +
                             " LEFT JOIN PhongBan ON ChucVu.maPhongBan = PhongBan.maPhongBan " +
                             " WHERE maNV COLLATE Latin1_General_CS_AS = '" + idEmp + "'";
            WorkWithDatabase work = new WorkWithDatabase();
            DataTable dt = work.loadDataFromDB(command);
            return dt.Rows[0][0].ToString();
        }
        public void deleteOTById(string id, string typeAcc) 
        {
            bool check = checkOTExistById(id);
            if(!check) 
            {
                MessageBox.Show("Không tìm thấy dữ liệu tăng ca nào có id:" + id);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn chắc chắn xóa?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                WorkWithDatabase work = new WorkWithDatabase();
                if (typeAcc == "Admin")
                {
                    string command = "DELETE FROM TangCa WHERE maTangCa = '" + id + "'";
                    work.loadDataFromDB(command);
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    string command = "SELECT * FROM TangCa WHERE maTangCa = '" + id + "'";
                    DataTable dt = work.loadDataFromDB(command);
                    string dep1 = getIdDepByIdEmp(dt.Rows[0][1].ToString());
                    string dep2 = getIdDepByTypeAcc(typeAcc);
                    if(dep1 == dep2) 
                    { 
                        string command2 = "DELETE FROM TangCa WHERE maTangCa = '" + id + "'";
                        work.loadDataFromDB(command2);
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại nhân viên bạn muốn xóa trong hệ thống!");
                    }

                }
               
            }     
        }

        public bool checkPosExistByName(string name)
        {
            string strCommand = "SELECT  tenChucVu FROM ChucVu WHERE tenChucVu = N'" + name + "'";
            WorkWithDatabase work = new WorkWithDatabase();
            DataTable dt =  work.loadDataFromDB(strCommand);
            if(dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool checkDepExistByName(string name)
        {
            string strCommand = "SELECT  tenPhongBan FROM PhongBan WHERE tenPhongBan = N'" + name + "'";
            WorkWithDatabase work = new WorkWithDatabase();
            DataTable dt = work.loadDataFromDB(strCommand);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
