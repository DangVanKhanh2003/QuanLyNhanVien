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
    public partial class NhanVienForm : Form
    {
        private string idAcc = null;
        private string idEmployee = null;

        public NhanVienForm(string idAcc, string idEmployee)
        {
            InitializeComponent();
            this.idAcc = idAcc;
            this.idEmployee = idEmployee;
            this.showInfor();
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

        private void NhanVienForm_Load(object sender, EventArgs e)
        {

        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            DoiMKForm changePasswordForm = new DoiMKForm(idAcc);
            changePasswordForm.ShowDialog();
        }
        private void showInfor()
        {
            ProfileControl profileControl = new ProfileControl();
            DataTable table = profileControl.LoadInfor(idEmployee);
            idEmployeeTextBox.Text = table.Rows[0][0].ToString();
            fullNameTextBox.Text = table.Rows[0][1].ToString();
            addressTextBox.Text = table.Rows[0][2].ToString();
            phoneNumberTextBox.Text = table.Rows[0][3].ToString();
            identificationCardTextBox.Text = table.Rows[0][4].ToString();
            mailTextBox.Text = table.Rows[0][5].ToString();
            dateOfBirthTextBox.Text = ((DateTime)table.Rows[0][6]).ToString("dd/MM/yyyy");
            dateJoinCompanyTextBox.Text = ((DateTime)table.Rows[0][7]).ToString("dd/MM/yyyy");
            GenderTextBox.Text = table.Rows[0][8].ToString();
            positionTextBox.Text = table.Rows[0][11].ToString();
            DepartmentTextBox.Text = table.Rows[0][14].ToString();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Hide();    
            DangNhapForm dangNhapForm = new DangNhapForm();
            dangNhapForm.ShowDialog();

        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(243, 242, 241);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(225, 223, 221);
        }

        private void NhanVienForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChiTietNhanVienForm detail = new ChiTietNhanVienForm(idEmployee);
            detail.ShowDialog();
        }
    }
}
