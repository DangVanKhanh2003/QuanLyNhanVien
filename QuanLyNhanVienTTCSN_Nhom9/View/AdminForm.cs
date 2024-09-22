using QuanLyNhanVienTTCSN_Nhom9.Control;
using QuanLyNhanVienTTCSN_Nhom9.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVienTTCSN_Nhom9
{
    public partial class AdminForm : Form
    {
        private string idAcc = null;
        private string typeAcc = "Admin";
        private DataTable dataTableEmp = new DataTable();
        private DataTable dataTableSalary = new DataTable();
        private DataTable dataTableOnleave = new DataTable();
        private DataTable dataTableAccount = new DataTable();
        private DataTable dataTableDepartment = new DataTable();
        private DataTable dataTablePosition = new DataTable();
        private DataTable dataTableOT = new DataTable();
        public AdminForm(string idAcc)
        {
            InitializeComponent();
            this.idAcc = idAcc;

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
        private void addEmpBtn_MouseHover(object sender, EventArgs e)
        {
            addEmpBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            addEmpBtn.BackColor = Color.FromArgb(243, 242, 241);
        }


        private void ChangeBtn_MouseHover(object sender, EventArgs e)
        {
            ChangeEmpBtn.BackColor = Color.FromArgb(225, 223, 221);
        }


        private void deleteBtn_MouseHover(object sender, EventArgs e)
        {
            deleteEmpBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void searchBtn_MouseHover(object sender, EventArgs e)
        {
            searchEmpBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void reloadBtn_MouseHover(object sender, EventArgs e)
        {
            reloadEmpBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void reloadBtn_MouseLeave(object sender, EventArgs e)
        {
            reloadEmpBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void ChangeBtn_MouseLeave(object sender, EventArgs e)
        {
            ChangeEmpBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void deleteBtn_MouseLeave(object sender, EventArgs e)
        {
            deleteEmpBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void searchBtn_MouseLeave(object sender, EventArgs e)
        {
            searchEmpBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void reloadSalaryBtn_MouseHover(object sender, EventArgs e)
        {
            reloadSalaryBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void addSalaryBtn_MouseHover(object sender, EventArgs e)
        {
            addSalaryBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void changeSalaryBtn_MouseHover(object sender, EventArgs e)
        {
            changeSalaryBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void deleteSalaryBtn_MouseHover(object sender, EventArgs e)
        {
            deleteSalaryBtn.BackColor = Color.FromArgb(225, 223, 221);
        }


        private void searchSalaryBtn_MouseHover(object sender, EventArgs e)
        {
            searchSalaryBtn.BackColor = Color.FromArgb(225, 223, 221);
        }



        private void reloadSalaryBtn_MouseLeave(object sender, EventArgs e)
        {
            reloadSalaryBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void addSalaryBtn_MouseLeave(object sender, EventArgs e)
        {
            addSalaryBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void changeSalaryBtn_MouseLeave(object sender, EventArgs e)
        {
            changeSalaryBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void deleteSalaryBtn_MouseLeave(object sender, EventArgs e)
        {
            deleteSalaryBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void searchSalaryBtn_MouseLeave(object sender, EventArgs e)
        {
            searchSalaryBtn.BackColor = Color.FromArgb(243, 242, 241);
        }


        private void reloadOnLeaveBtn_MouseLeave(object sender, EventArgs e)
        {
            reloadOnLeaveBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void addOnLeaveBtn_MouseLeave(object sender, EventArgs e)
        {
            addOnLeaveBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void changeOnLeaveBtn_MouseHover(object sender, EventArgs e)
        {
            changeOnLeaveBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void deleteOnLeaveBtn_MouseLeave(object sender, EventArgs e)
        {
            deleteOnLeaveBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void searchOnLeaveBtn_MouseHover(object sender, EventArgs e)
        {
            searchOnLeaveBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void searchOnLeaveBtn_MouseLeave(object sender, EventArgs e)
        {
            searchOnLeaveBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void reloadOnLeaveBtn_MouseHover(object sender, EventArgs e)
        {
            reloadOnLeaveBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void addOnLeaveBtn_MouseHover(object sender, EventArgs e)
        {
            addOnLeaveBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void deleteOnLeaveBtn_MouseHover(object sender, EventArgs e)
        {
            deleteOnLeaveBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void changeOnLeaveBtn_MouseLeave(object sender, EventArgs e)
        {
            changeOnLeaveBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void reloadPositonBtn_MouseLeave(object sender, EventArgs e)
        {
            reloadPositonBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void addPositonBtn_MouseLeave(object sender, EventArgs e)
        {
            addPositonBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void changePositionBtn_MouseLeave(object sender, EventArgs e)
        {
            changePositionBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void deletePositionBtn_MouseLeave(object sender, EventArgs e)
        {
            deletePositionBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void reloadPositonBtn_MouseHover(object sender, EventArgs e)
        {
            reloadPositonBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void addPositonBtn_MouseHover(object sender, EventArgs e)
        {
            addPositonBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void changePositionBtn_MouseHover(object sender, EventArgs e)
        {
            changePositionBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void deletePositionBtn_MouseHover(object sender, EventArgs e)
        {
            deletePositionBtn.BackColor = Color.FromArgb(225, 223, 221);
        }


        private void reloadDepartmentBtn_MouseHover(object sender, EventArgs e)
        {
            reloadDepartmentBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void addDepartmentBtn_MouseHover(object sender, EventArgs e)
        {
            addDepartmentBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void changeDepartmentBtn_MouseHover(object sender, EventArgs e)
        {
            changeDepartmentBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void deleteDepartmentBtn_MouseHover(object sender, EventArgs e)
        {
            deleteDepartmentBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void reloadDepartmentBtn_MouseLeave(object sender, EventArgs e)
        {
            reloadDepartmentBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void addDepartmentBtn_MouseLeave(object sender, EventArgs e)
        {
            addDepartmentBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void changeDepartmentBtn_MouseLeave(object sender, EventArgs e)
        {
            changeDepartmentBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void deleteDepartmentBtn_MouseLeave(object sender, EventArgs e)
        {
            deleteDepartmentBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void reloadAccountBtn_MouseLeave(object sender, EventArgs e)
        {
            reloadAccountBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void addAccountBtn_MouseLeave(object sender, EventArgs e)
        {
            addAccountBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void changeAccountBtn_MouseLeave(object sender, EventArgs e)
        {
            changeAccountBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void deleteAccountBtn_MouseLeave(object sender, EventArgs e)
        {
            deleteAccountBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void searchAccountBtn_MouseLeave(object sender, EventArgs e)
        {
            searchAccountBtn.BackColor = Color.FromArgb(243, 242, 241);
        }


        private void reloadAccountBtn_MouseHover(object sender, EventArgs e)
        {
            reloadAccountBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void addAccountBtn_MouseHover(object sender, EventArgs e)
        {
            addAccountBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void changeAccountBtn_MouseHover(object sender, EventArgs e)
        {
            changeAccountBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void deleteAccountBtn_MouseHover(object sender, EventArgs e)
        {
            deleteAccountBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void searchAccountBtn_MouseHover(object sender, EventArgs e)
        {
            searchAccountBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void ChangeEmpBtn_Click(object sender, EventArgs e)
        {
            NhapMaNV formEnterIdEmployee = new NhapMaNV("Admin", "repair");
            formEnterIdEmployee.ShowDialog();
            loadEmployee("Admin");


        }

        private void deleteEmpBtn_Click(object sender, EventArgs e)
        {
            NhapMaNV formEnterIdEmployee = new NhapMaNV("Admin", "remove");
            formEnterIdEmployee.ShowDialog();
            loadEmployee("Admin");
            loadSalary(typeAcc);
            loadOnLeave(typeAcc);
            loadAccount();
            loadOT();


        }

        private void changeSalaryBtn_Click(object sender, EventArgs e)
        {
            NhapMaLuong formEnterIdSalary = new NhapMaLuong("Admin", "repair");
            formEnterIdSalary.ShowDialog();
            loadSalary(typeAcc);

        }

        private void deleteSalaryBtn_Click(object sender, EventArgs e)
        {
            NhapMaLuong formEnterIdSalary = new NhapMaLuong("Admin", "remove");
            formEnterIdSalary.ShowDialog();
            loadSalary(typeAcc);


        }

        private void changeOnLeaveBtn_Click(object sender, EventArgs e)
        {
            NhapMaNghiPhep formEnterIdOnLeave = new NhapMaNghiPhep("Admin", "repair");
            formEnterIdOnLeave.ShowDialog();

            loadOnLeave(typeAcc);
        }

        private void deleteOnLeaveBtn_Click(object sender, EventArgs e)
        {
            NhapMaNghiPhep formEnterIdOnLeave = new NhapMaNghiPhep("Admin", "remove");
            formEnterIdOnLeave.ShowDialog();
            loadOnLeave(typeAcc);
        }

        private void changePositionBtn_Click(object sender, EventArgs e)
        {
            NhapMaChucVu formEnterIdPosition = new NhapMaChucVu("repair");
            formEnterIdPosition.ShowDialog();
            loadPosition();


        }

        private void deletePositionBtn_Click(object sender, EventArgs e)
        {
            NhapMaChucVu formEnterIdPosition = new NhapMaChucVu("remove");
            formEnterIdPosition.ShowDialog();
            loadPosition();

        }

        private void changeDepartmentBtn_Click(object sender, EventArgs e)
        {
            NhapMaPhongBan formEnterIdDepartment = new NhapMaPhongBan("repair");
            formEnterIdDepartment.ShowDialog();
            loadDepartment();


        }

        private void deleteDepartmentBtn_Click(object sender, EventArgs e)
        {
            NhapMaPhongBan formEnterIdDepartment = new NhapMaPhongBan("remove");
            formEnterIdDepartment.ShowDialog();
            loadDepartment();
            loadPosition();

        }

        private void changeAccountBtn_Click(object sender, EventArgs e)
        {
            NhapMaTK formEnterIdAccount = new NhapMaTK("repair");
            formEnterIdAccount.ShowDialog();
            loadAccount();

        }

        private void deleteAccountBtn_Click(object sender, EventArgs e)
        {
            NhapMaTK formEnterIdAccount = new NhapMaTK("remove");
            formEnterIdAccount.ShowDialog();
            loadAccount();


        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            ThemNhanVien formAddemp = new ThemNhanVien("Admin");
            formAddemp.ShowDialog();
            loadEmployee("Admin");

        }

        private void addSalaryBtn_Click(object sender, EventArgs e)
        {
            ThemLuong formAddSalary = new ThemLuong("Admin", tableEmployeeAdmin); 
            formAddSalary.ShowDialog();
            loadSalary(typeAcc);

        }

        private void addOnLeaveBtn_Click(object sender, EventArgs e)
        {
            ThemNghiPhep formAddOnLeave = new ThemNghiPhep("Admin", tableEmployeeAdmin);   
            formAddOnLeave.ShowDialog();
            DateTime currentDate = DateTime.Now;
            int previousMonth = currentDate.Month - 1; // Get current month (1-12)
            int currentYear = currentDate.Year; // Get current year (e.g., 2023)
            monthOnLeaveAdmin.Text = previousMonth.ToString() + "-" + currentYear.ToString();
            loadOnLeave(typeAcc);

        }

        private void addPositonBtn_Click(object sender, EventArgs e)
        {
            ThemChucVu formAddPosition = new ThemChucVu();
            formAddPosition.ShowDialog();
            loadPosition();

        }

        private void addDepartmentBtn_Click(object sender, EventArgs e)
        {
            ThemPhongBan formDepartment = new ThemPhongBan();   
            formDepartment.ShowDialog();
            loadDepartment();

        }

        private void addAccountBtn_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan formAddAcc = new ThemTaiKhoan();
            formAddAcc.ShowDialog();
            loadAccount();

        }

        private void sortOnLeaveBtn_Click(object sender, EventArgs e)
        {
            SapXepNghiPhepForm sortOnLeave = new SapXepNghiPhepForm();
            sortOnLeave.ShowDialog();
        }

        private void sortEmpBtn_Click(object sender, EventArgs e)
        {
            SapXepNVForm sortEmpForm = new SapXepNVForm();
            sortEmpForm.ShowDialog();
        }

        private void sortSalaryBtn_Click(object sender, EventArgs e)
        {
            SapXepLuongForm sortSalary = new SapXepLuongForm();
            sortSalary.ShowDialog();
        }

        private void sortAccountBtn_Click(object sender, EventArgs e)
        {
            SapXepTKForm sortAcc = new SapXepTKForm();
            sortAcc.ShowDialog();
        }

        private void searchEmpBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchEmpBtn_Click(object sender, EventArgs e)
        {
            TimKiemNhanVienForm timKiemNVForm = new TimKiemNhanVienForm(dataTableEmp, tableEmployeeAdmin, typeAcc);
            timKiemNVForm.ShowDialog();
        }

        private void searchSalaryBtn_Click(object sender, EventArgs e)
        {
            TimKiemLuongForm timKiemLuongForm = new TimKiemLuongForm(tableSalaryAdmin, "Admin", timeSalary);
            timKiemLuongForm.ShowDialog();
        }

        private void searchOnLeaveBtn_Click(object sender, EventArgs e)
        {
            TimKiemNghiPhepForm timKiemNghiPhepForm = new TimKiemNghiPhepForm("Admin", tableOnLeaveAdmin, monthOnLeaveAdmin);
            timKiemNghiPhepForm.ShowDialog();
        }

        private void searchPositionBtn_Click(object sender, EventArgs e)
        {
            TimKiemChucVuForm timKiemChucVuForm = new TimKiemChucVuForm(PositionDGV);
            timKiemChucVuForm.ShowDialog();
        }

        private void searchAccountBtn_Click(object sender, EventArgs e)
        {
            TimKiemTaiKhoanForm timKiemTaiKhoanForm = new TimKiemTaiKhoanForm(typeAcc, AccountDGV, dataTableAccount);
            timKiemTaiKhoanForm.ShowDialog();
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOutBtn_MouseLeave(object sender, EventArgs e)
        {
            logOutBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void logOutBtn_MouseMove(object sender, MouseEventArgs e)
        {
            logOutBtn.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            int previousMonth = currentDate.Month - 1; // Get current month (1-12)
            int currentYear = currentDate.Year; // Get current year (e.g., 2023)
            loadEmployee(typeAcc);
            loadSalary(typeAcc, currentYear, previousMonth);
            loadOnLeave(typeAcc, currentYear, previousMonth);
            loadAccount();
            loadDepartment();
            loadPosition();
            loadOT();

            // Calculate the new size for the DataGridView based on the form size
            int newWidth = this.ClientSize.Width;
            int newHeight = this.ClientSize.Height;

            // Set the new size for the DataGridView
            panel5.Size = new Size(newWidth, newHeight);
            tableEmployeeAdmin.Size = new Size(newWidth, newHeight - 135);
            tableSalaryAdmin.Size = new Size(newWidth, newHeight - 135);
            tableOnLeaveAdmin.Size = new Size(newWidth, newHeight - 135);
            AccountDGV.Size = new Size(newWidth, newHeight - 135);
            DepartmentDGV.Size = new Size(newWidth, newHeight - 135);
            PositionDGV.Size = new Size(newWidth, newHeight - 135);
            dgvOT.Size = new Size(newWidth, newHeight - 135);

            tableEmployeeAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableSalaryAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableOnLeaveAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AccountDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DepartmentDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PositionDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        public void loadOT() 
        {

            DateTime currentDate = DateTime.Now;
            int month = currentDate.Month - 1; // Get current month (1-12)
            int year = currentDate.Year; // Get current year (e.g., 2023)
            if(timeOT.Text.ToString() != "")
            {
                string[] list = timeOT.Text.ToString().Split('-');
                month = int.Parse(list[0]);
                year = int.Parse(list[1]);

            }    
            timeOT.Text = month + "-" + year;
            ManageForm mana = new ManageForm();
            dataTableOT = mana.loadOT("Admin", month, year);
            dgvOT.DataSource = dataTableOT;
            loadSalary(typeAcc);
        }
        
        private void loadPosition()
        {
            ManageForm manageForm = new ManageForm();
            dataTablePosition = manageForm.loadPosition();
            PositionDGV.DataSource = dataTablePosition;
        }
        private void loadDepartment()
        {
            ManageForm manageForm = new ManageForm();
            dataTableDepartment = manageForm.loadDepartment();
            DepartmentDGV.DataSource = dataTableDepartment;

        }

        private void loadEmployee(string typeAcc)
        {
            ManageForm manageForm = new ManageForm();
            dataTableEmp = manageForm.processAndShowEmp(typeAcc);
            tableEmployeeAdmin.DataSource = dataTableEmp;
        }

        private void loadSalary(string typeAcc, int year = -1, int month = -1)
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
            if (timeSalary.Text.ToString() != "")
            {
                string[] list = timeSalary.Text.ToString().Split('-');
                month = int.Parse(list[0]);
                year = int.Parse(list[1]);

            }
            timeSalary.Text = month + "-" + year;
            ManageForm manageForm = new ManageForm();
            dataTableSalary = manageForm.processtableSal(typeAcc, year, month);
            tableSalaryAdmin.DataSource = dataTableSalary;
        }

        private void loadOnLeave(string typeAcc, int year = -1, int month = -1)
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
            if (monthOnLeaveAdmin.Text.ToString() != "")
            {
                string[] list = monthOnLeaveAdmin.Text.ToString().Split('-');
                month = int.Parse(list[0]);
                year = int.Parse(list[1]);

            }
            monthOnLeaveAdmin.Text = month + "-" + year;
            ManageForm manageForm = new ManageForm();
            dataTableOnleave = manageForm.processTableOnLeave(typeAcc, year, month);
            tableOnLeaveAdmin.DataSource = dataTableOnleave;
            loadSalary(typeAcc);

        }
        private void loadAccount()
        {
            ManageForm manage = new ManageForm();
            dataTableAccount = manage.processTableAccount();
            AccountDGV.DataSource = dataTableAccount;

        }
        private void loadPosition(string typeAcc)
        {
            ManageForm manageForm = new ManageForm();
            //dataTableOnleave = manageForm.;
            //tableOnLeaveAdmin.DataSource = dataTableOnleave;

        }
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dtviewEmployeeAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminForm_SizeChanged(object sender, EventArgs e)
        {

            // Calculate the new size for the DataGridView based on the form size
            int newWidth = this.ClientSize.Width;
            int newHeight = this.ClientSize.Height;

            // Set the new size for the DataGridView
            panel5.Size = new Size(newWidth, newHeight);
            tableEmployeeAdmin.Size = new Size(newWidth, newHeight - 135);
            tableSalaryAdmin.Size = new Size(newWidth, newHeight - 135);
            tableOnLeaveAdmin.Size = new Size(newWidth, newHeight - 135);
            AccountDGV.Size = new Size(newWidth, newHeight - 135);
            DepartmentDGV.Size = new Size(newWidth, newHeight - 135);
            PositionDGV.Size = new Size(newWidth, newHeight - 135);
            dgvOT.Size = new Size(newWidth, newHeight - 135);
            tableEmployeeAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableSalaryAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableOnLeaveAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AccountDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DepartmentDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PositionDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }

        private void reloadEmpBtn_Click(object sender, EventArgs e)
        {
            loadAccount();
        }

        private void reloadEmpBtn_Paint(object sender, PaintEventArgs e)
        {
            loadEmployee(typeAcc);

        }

        private void reloadSalaryBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reloadOnLeaveBtn_Paint(object sender, PaintEventArgs e)
        {
        }



        private void tableEmployeeAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableEmployeeAdmin_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView != null)
            {
                // Get the rectangle area to draw the row number
                Rectangle rowNumberRect = new Rectangle(
                    new Point(0, e.RowBounds.Top), // Adjust the X position if needed
                    new Size(dataGridView.RowHeadersWidth, e.RowBounds.Height));

                // Draw the row number in the first cell of each row
                e.Graphics.DrawString((e.RowIndex + 1).ToString(),
                    dataGridView.DefaultCellStyle.Font,
                    Brushes.Black,
                    rowNumberRect,
                    new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
        }

        private void addEmpBtn_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tableEmployee_Resize(object sender, EventArgs e)
        {
        }

        private void AdminForm_Resize(object sender, EventArgs e)
        {
            //tableEmployee.Size = new Size(this.ClientSize.Width , this.ClientSize.Height - 200);

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            List<Form> formsToClose = new List<Form>();

            // Find forms to close without closing the specified form (e.g., DangNhapForm)
            foreach (Form form in Application.OpenForms)
            {
                if (form != this && form.Name != "DangNhapForm") // Replace 'this' with the form you want to keep open
                {
                    formsToClose.Add(form);
                }
            }
            this.Hide();
            // Close the forms outside the iteration loop
            for (int i = formsToClose.Count - 1; i > -1; i--)
            {
                formsToClose[i].Hide();
            }


            DangNhapForm dangNhapForm = new DangNhapForm();
            dangNhapForm.ShowDialog();
        }

        private void reloadOnLeaveBtn_Click(object sender, EventArgs e)
        {
            loadOnLeave(typeAcc);
        }

        private void tableSalaryAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reloadSalaryBtn_Click(object sender, EventArgs e)
        {
            loadSalary(typeAcc);

        }

        private void detailOnLeaveAdminBtn_Click(object sender, EventArgs e)
        {
            NhapMaNghiPhep fromDetail = new NhapMaNghiPhep(typeAcc, "detailOnLeave");
            fromDetail.ShowDialog();
        }

        private void detailOnLeaveAdminBtn_MouseMove(object sender, MouseEventArgs e)
        {
            detailOnLeaveAdminBtn.BackColor = Color.FromArgb(225, 223, 221);

        }

        private void detailOnLeaveAdminBtn_MouseLeave(object sender, EventArgs e)
        {
            detailOnLeaveAdminBtn.BackColor = Color.FromArgb(225, 223, 221);

        }

        private void PositionDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchPosition_Click(object sender, EventArgs e)
        {
            TimKiemChucVuForm positonSearch = new TimKiemChucVuForm(PositionDGV);
            positonSearch.ShowDialog();
        }

        private void reloadAccountBtn_Click(object sender, EventArgs e)
        {
            loadAccount();
        }

        private void searchAccountBtn_Click_1(object sender, EventArgs e)
        {
            TimKiemTaiKhoanForm search = new TimKiemTaiKhoanForm(typeAcc, AccountDGV, dataTableAccount);
            search.ShowDialog();
        }

        private void reloadDepartmentBtn_Click(object sender, EventArgs e)
        {
            loadDepartment();
        }

        private void changeDepartmentBtn_Click_1(object sender, EventArgs e)
        {
            NhapMaPhongBan nhapMaForm = new NhapMaPhongBan("repair");
            nhapMaForm.ShowDialog();
            loadDepartment();

        }

        private void reloadPositonBtn_Click(object sender, EventArgs e)
        {
            loadPosition();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AccountDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reloadOT_Click(object sender, EventArgs e)
        {
            loadOT();
        }

        private void findOT_Click(object sender, EventArgs e)
        {
            TimKiemTangCaForm timKiem = new TimKiemTangCaForm("Admin", dgvOT, timeOT);
            timKiem.ShowDialog();
        }

        private void panel16_MouseMove(object sender, MouseEventArgs e)
        {
            changePassword.BackColor = Color.FromArgb(225, 223, 221);

        }

        private void panel16_MouseLeave(object sender, EventArgs e)
        {
            changePassword.BackColor = Color.FromArgb(243, 242, 241);

        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            DoiMatKhauAdmin doiMK = new DoiMatKhauAdmin();
            doiMK.ShowDialog();
        }

        private void addOT_Click(object sender, EventArgs e)
        {
            ThemTangCaForm them = new ThemTangCaForm("Admin");
            them.ShowDialog();
            loadOT();
        }

        private void repairOT_Click(object sender, EventArgs e)
        {
            NhapTangCaForm nhapTangCa = new NhapTangCaForm("Admin", "repair");
            nhapTangCa.ShowDialog();
            loadOT();
        }

        private void removeOT_Click(object sender, EventArgs e)
        {
            NhapTangCaForm nhapTangCa = new NhapTangCaForm("Admin", "remove");
            nhapTangCa.ShowDialog();
            loadOT();
        }

        private void tableEmployeeAdmin_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView != null)
            {
                // Get the rectangle area to draw the row number
                Rectangle rowNumberRect = new Rectangle(
                    new Point(0, e.RowBounds.Top), // Adjust the X position if needed
                    new Size(dataGridView.RowHeadersWidth, e.RowBounds.Height));

                // Draw the row number in the first cell of each row
                e.Graphics.DrawString((e.RowIndex + 1).ToString(),
                    dataGridView.DefaultCellStyle.Font,
                    Brushes.Black,
                    rowNumberRect,
                    new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
        }

        private void tableSalaryAdmin_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView != null)
            {
                // Get the rectangle area to draw the row number
                Rectangle rowNumberRect = new Rectangle(
                    new Point(0, e.RowBounds.Top), // Adjust the X position if needed
                    new Size(dataGridView.RowHeadersWidth, e.RowBounds.Height));

                // Draw the row number in the first cell of each row
                e.Graphics.DrawString((e.RowIndex + 1).ToString(),
                    dataGridView.DefaultCellStyle.Font,
                    Brushes.Black,
                    rowNumberRect,
                    new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
        }

        private void tableOnLeaveAdmin_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView != null)
            {
                // Get the rectangle area to draw the row number
                Rectangle rowNumberRect = new Rectangle(
                    new Point(0, e.RowBounds.Top), // Adjust the X position if needed
                    new Size(dataGridView.RowHeadersWidth, e.RowBounds.Height));

                // Draw the row number in the first cell of each row
                e.Graphics.DrawString((e.RowIndex + 1).ToString(),
                    dataGridView.DefaultCellStyle.Font,
                    Brushes.Black,
                    rowNumberRect,
                    new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
        }

        private void PositionDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView != null)
            {
                // Get the rectangle area to draw the row number
                Rectangle rowNumberRect = new Rectangle(
                    new Point(0, e.RowBounds.Top), // Adjust the X position if needed
                    new Size(dataGridView.RowHeadersWidth, e.RowBounds.Height));

                // Draw the row number in the first cell of each row
                e.Graphics.DrawString((e.RowIndex + 1).ToString(),
                    dataGridView.DefaultCellStyle.Font,
                    Brushes.Black,
                    rowNumberRect,
                    new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
        }

        private void DepartmentDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView != null)
            {
                // Get the rectangle area to draw the row number
                Rectangle rowNumberRect = new Rectangle(
                    new Point(0, e.RowBounds.Top), // Adjust the X position if needed
                    new Size(dataGridView.RowHeadersWidth, e.RowBounds.Height));

                // Draw the row number in the first cell of each row
                e.Graphics.DrawString((e.RowIndex + 1).ToString(),
                    dataGridView.DefaultCellStyle.Font,
                    Brushes.Black,
                    rowNumberRect,
                    new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
        }

        private void AccountDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView != null)
            {
                // Get the rectangle area to draw the row number
                Rectangle rowNumberRect = new Rectangle(
                    new Point(0, e.RowBounds.Top), // Adjust the X position if needed
                    new Size(dataGridView.RowHeadersWidth, e.RowBounds.Height));

                // Draw the row number in the first cell of each row
                e.Graphics.DrawString((e.RowIndex + 1).ToString(),
                    dataGridView.DefaultCellStyle.Font,
                    Brushes.Black,
                    rowNumberRect,
                    new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
        }

        private void dgvOT_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView != null)
            {
                // Get the rectangle area to draw the row number
                Rectangle rowNumberRect = new Rectangle(
                    new Point(0, e.RowBounds.Top), // Adjust the X position if needed
                    new Size(dataGridView.RowHeadersWidth, e.RowBounds.Height));

                // Draw the row number in the first cell of each row
                e.Graphics.DrawString((e.RowIndex + 1).ToString(),
                    dataGridView.DefaultCellStyle.Font,
                    Brushes.Black,
                    rowNumberRect,
                    new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            }
        }

        private void addDepartmentBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reloadOT_MouseMove(object sender, MouseEventArgs e)
        {
            reloadOT.BackColor = Color.FromArgb(225, 223, 221);

        }

        private void addOT_MouseMove(object sender, MouseEventArgs e)
        {
            addOT.BackColor = Color.FromArgb(225, 223, 221);

        }

        private void repairOT_MouseMove(object sender, MouseEventArgs e)
        {
            repairOT.BackColor = Color.FromArgb(225, 223, 221);

        }

        private void removeOT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void removeOT_MouseMove(object sender, MouseEventArgs e)
        {
            removeOT.BackColor = Color.FromArgb(225, 223, 221);

        }

        private void findOT_MouseMove(object sender, MouseEventArgs e)
        {
            findOT.BackColor = Color.FromArgb(225, 223, 221);

        }

        private void reloadOT_MouseLeave(object sender, EventArgs e)
        {
            reloadOT.BackColor = Color.FromArgb(243, 242, 241);

        }

        private void addOT_MouseLeave(object sender, EventArgs e)
        {
            addOT.BackColor = Color.FromArgb(243, 242, 241);

        }

        private void repairOT_MouseLeave(object sender, EventArgs e)
        {
            repairOT.BackColor = Color.FromArgb(243, 242, 241);

        }

        private void removeOT_MouseLeave(object sender, EventArgs e)
        {
            removeOT.BackColor = Color.FromArgb(243, 242, 241);

        }

        private void findOT_MouseLeave(object sender, EventArgs e)
        {
            findOT.BackColor = Color.FromArgb(243, 242, 241);

        }
    }
}
