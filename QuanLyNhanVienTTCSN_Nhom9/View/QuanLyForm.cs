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
    public partial class QuanLyForm : Form
    {
        private string idAcc = null;
        private string idEmployee = null;
        private string typeAcc = null;
        private DataTable dataTableEmp = new DataTable();
        private DataTable dataTableSalary = new DataTable();
        private DataTable dataTableOnleave = new DataTable();
        private DataTable dataTableOT = new DataTable();
        public QuanLyForm(string idAcc, string idEmployee, string typeAcc)
        {
            InitializeComponent();
            this.idAcc = idAcc;
            this.idEmployee = idEmployee;
            this.typeAcc = typeAcc;
        }

        public string IdAcc
        {
            set
            {
                idAcc = value;
            }
            get
            {
                return idAcc;
            }
        }

        public string Employee
        {
            get
            {
                return idEmployee;
            }
            set
            {
                idEmployee = value;
            }
        }

        public string TypeAcc
        {
            get
            {
                return typeAcc;
            }
            set
            {
                typeAcc = value;
            }
        }
        private void panel2_MouseHover(object sender, EventArgs e)
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

        private void deleteBtn_Paint(object sender, PaintEventArgs e)
        {

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
            reloadOnLeaveBtnAdmin.BackColor = Color.FromArgb(243, 242, 241);
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
            reloadOnLeaveBtnAdmin.BackColor = Color.FromArgb(225, 223, 221);
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

        private void ChangeEmpBtn_Click(object sender, EventArgs e)
        {
            NhapMaNV formEnterIdEmployee = new NhapMaNV(typeAcc, "repair");
            formEnterIdEmployee.ShowDialog();
            loadEmployee(typeAcc);

        }

        private void deleteEmpBtn_Click(object sender, EventArgs e)
        {
            NhapMaNV formEnterIdEmployee = new NhapMaNV(typeAcc, "remove");
            formEnterIdEmployee.ShowDialog();
            loadEmployee(typeAcc);

        }

        private void changeSalaryBtn_Click(object sender, EventArgs e)
        {
            NhapMaLuong formEnterSalary = new NhapMaLuong(typeAcc, "repair");
            formEnterSalary.ShowDialog();

            loadSalary(typeAcc);

        }

        private void deleteSalaryBtn_Click(object sender, EventArgs e)
        {
            NhapMaLuong formEnterSalary = new NhapMaLuong(typeAcc, "remove");
            formEnterSalary.ShowDialog();
            loadSalary(typeAcc);

        }

        private void changeOnLeaveBtn_Click(object sender, EventArgs e)
        {
            NhapMaNghiPhep nhap = new NhapMaNghiPhep(typeAcc, "repair");
            nhap.ShowDialog();
            loadOnLeave(typeAcc);

        }

        private void deleteOnLeaveBtn_Click(object sender, EventArgs e)
        {
            NhapMaNghiPhep xoa = new NhapMaNghiPhep(typeAcc, "remove");
            xoa.ShowDialog();
            loadOnLeave(typeAcc);

        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            ThemNhanVien formAddEmp = new ThemNhanVien(typeAcc);
            formAddEmp.ShowDialog();
            loadEmployee(typeAcc);


        }

        private void addSalaryBtn_Click(object sender, EventArgs e)
        {
            ThemLuong formSalary = new ThemLuong( typeAcc,tableSalary);
            formSalary.ShowDialog();
            loadSalary(typeAcc);

        }


        private void addOnLeaveBtn_Click(object sender, EventArgs e)
        {
            ThemNghiPhep them = new ThemNghiPhep(typeAcc, tableOnLeave);
            them.ShowDialog();
            loadOnLeave(typeAcc);

        }

        private void sortEmpBtn_Click(object sender, EventArgs e)
        {
            SapXepNVForm sortEmpForm = new SapXepNVForm();
            sortEmpForm.ShowDialog();
        }

        private void sortOnLeaveBtn_Click(object sender, EventArgs e)
        {
            SapXepNghiPhepForm sortOnLeave = new SapXepNghiPhepForm();
            sortOnLeave.ShowDialog();
        }

        private void sortSalaryBtn_Click(object sender, EventArgs e)
        {
            SapXepLuongForm sortSalary = new SapXepLuongForm();
            sortSalary.ShowDialog();
        }

        private void QuanLyForm_Load(object sender, EventArgs e)
        {

            DateTime currentDate = DateTime.Now;
            int previousMonth = currentDate.Month - 1; // Get current month (1-12)
            int currentYear = currentDate.Year; // Get current year (e.g., 2023)
            loadEmployee(typeAcc);
            loadSalary(typeAcc, currentYear, previousMonth);
            loadOnLeave(typeAcc, currentYear, previousMonth);
            loadOT();


            // Calculate the new size for the DataGridView based on the form size
            int newWidth = this.ClientSize.Width;
            int newHeight = this.ClientSize.Height;

            // Set the new size for the DataGridView
            panel5.Size = new Size(newWidth, newHeight);
            tableEmployee.Size = new Size(newWidth, newHeight - 135);
            tableOnLeave.Size = new Size(newWidth, newHeight - 135);
            tableSalary.Size = new Size(newWidth, newHeight - 135);
            dgvOT.Size = new Size(newWidth, newHeight - 135);
            tableEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableOnLeave.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableSalary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public void loadOT()
        {
            DateTime currentDate = DateTime.Now;
            int month = currentDate.Month - 1; // Get current month (1-12)
            int year = currentDate.Year; // Get current year (e.g., 2023)
            if (timeOT.Text.ToString() != "")
            {
                string[] list = timeOT.Text.ToString().Split('-');
                month = int.Parse(list[0]);
                year = int.Parse(list[1]);

            }
            timeOT.Text = month + "-" + year;
            ManageForm mana = new ManageForm();
            dataTableOT = mana.loadOT(typeAcc, month, year);
            dgvOT.DataSource = dataTableOT;
            loadSalary(typeAcc);
        }
        private void loadEmployee(string typeAcc)
        {
            ManageForm manageForm = new ManageForm();
            dataTableEmp = manageForm.processAndShowEmp(typeAcc);
            tableEmployee.DataSource = dataTableEmp;
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
            tableSalary.DataSource = dataTableSalary;
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
            if (monthOnLeave.Text.ToString() != "")
            {
                string[] list = monthOnLeave.Text.ToString().Split('-');
                month = int.Parse(list[0]);
                year = int.Parse(list[1]);

            }
            monthOnLeave.Text = month + "-" + year;
            ManageForm manageForm = new ManageForm();
            dataTableOnleave = manageForm.processTableOnLeave(typeAcc, year, month);
            tableOnLeave.DataSource = dataTableOnleave;
            loadSalary(typeAcc);
        }



        private void profileEmpBtn_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(idAcc, idEmployee);
            profile.ShowDialog();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(idAcc, idEmployee);
            profile.ShowDialog();
        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void panel9_MouseMove(object sender, MouseEventArgs e)
        {
            panel9.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(idAcc, idEmployee);
            profile.ShowDialog();
        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            panel10.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void panel10_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel10_MouseMove(object sender, MouseEventArgs e)
        {
            panel10.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(idAcc, idEmployee);
            profile.ShowDialog();
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            panel8.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLyForm_SizeChanged(object sender, EventArgs e)
        {

            // Calculate the new size for the DataGridView based on the form size
            int newWidth = this.ClientSize.Width;
            int newHeight = this.ClientSize.Height;

            // Set the new size for the DataGridView
            panel5.Size = new Size(newWidth, newHeight);
            tableEmployee.Size = new Size(newWidth, newHeight - 135);
            tableOnLeave.Size = new Size(newWidth, newHeight - 135);
            tableSalary.Size = new Size(newWidth, newHeight - 135);
            dgvOT.Size = new Size(newWidth, newHeight - 135);
            tableEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableOnLeave.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableSalary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void panel5_SizeChanged(object sender, EventArgs e)
        {

        }

        private void tableEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuanLyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tableSalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sortEmpBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableOnLeave_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void tableSalary_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void tableEmployee_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void timeSalary_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reloadEmpBtn_Click(object sender, EventArgs e)
        {
            loadEmployee(typeAcc);
        }

        private void reloadSalaryBtn_Click(object sender, EventArgs e)
        {
            loadSalary(typeAcc);
        }

        private void reloadOnLeaveBtn_Click(object sender, EventArgs e)
        {

            loadOnLeave(TypeAcc);
        }

        private void searchEmpBtn_Click(object sender, EventArgs e)
        {
            TimKiemNhanVienForm timKiem = new TimKiemNhanVienForm(dataTableEmp, tableEmployee, typeAcc);
            timKiem.ShowDialog();
        }

        private void searchSalaryBtn_Click(object sender, EventArgs e)
        {
            TimKiemLuongForm timKiem = new TimKiemLuongForm(tableSalary, typeAcc, timeSalary);
            timKiem.ShowDialog();
        }

        private void searchOnLeaveBtn_Click(object sender, EventArgs e)
        {
            TimKiemNghiPhepForm timKiem = new TimKiemNghiPhepForm(typeAcc, tableOnLeave, monthOnLeave);
            timKiem.ShowDialog();
        }

        private void reloadEmpBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addEmpBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deleteSalaryBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
            detailOnLeaveBtn.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void detailOnLeaveBtn_MouseHover(object sender, EventArgs e)
        {
            detailOnLeaveBtn.BackColor = Color.FromArgb(225, 223, 221);

        }

        private void detailOnLeaveBtn_Click(object sender, EventArgs e)
        {
            NhapMaNghiPhep fromDetail = new NhapMaNghiPhep(typeAcc, "detailOnLeave");
            fromDetail.ShowDialog();
        }

        private void reloadOT_Click(object sender, EventArgs e)
        {
            loadOT();

        }

        private void addOT_Click(object sender, EventArgs e)
        {
            ThemTangCaForm them = new ThemTangCaForm(typeAcc);
            them.ShowDialog();
            loadOT();
        }

        private void repairOT_Click(object sender, EventArgs e)
        {
            NhapTangCaForm nhapTangCa = new NhapTangCaForm(typeAcc, "repair");
            nhapTangCa.ShowDialog();
            loadOT();
        }

        private void removeOT_Click(object sender, EventArgs e)
        {
            NhapTangCaForm nhapTangCa = new NhapTangCaForm(typeAcc, "remove");
            nhapTangCa.ShowDialog();
            loadOT();
        }

        private void findOT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void findOT_Click(object sender, EventArgs e)
        {
            TimKiemTangCaForm timKiem = new TimKiemTangCaForm(typeAcc, dgvOT, timeOT);
            timKiem.ShowDialog();
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void detailOnLeaveBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(idAcc, idEmployee);
            profile.ShowDialog();
        }

        private void panel11_MouseLeave_1(object sender, EventArgs e)
        {
            panel11.BackColor = Color.FromArgb(243, 242, 241);

        }

        private void panel11_MouseMove(object sender, MouseEventArgs e)
        {
            panel11.BackColor = Color.FromArgb(225, 223, 221);

        }
    }
}
