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
    public partial class DangNhapForm : Form
    {

        public DangNhapForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void logInBtn_Click(object sender, EventArgs e)
        {

            string acc = accountTextBox.Text;
            string password = PasswordTextBox.Text;
            if (acc.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin.");
            }
            else
            {
                string idEmployee = null;
                string typeAcc = null;
                string idAcc = null;
                DangNhapControl control = new DangNhapControl();
                control.searchAcc(acc, password);
                idEmployee = control.IdEmployee;
                typeAcc = control.TypeAcc;
                idAcc = control.IdAcc;
                if(idAcc != null ) 
                {
                    if (typeAcc == "Admin")
                    {
                        this.Hide();
                        AdminForm adminForm = new AdminForm(idAcc);
                        adminForm.ShowDialog();

                    }
                    else if (typeAcc == "NhanVien")
                    {
                        this.Hide();
                        NhanVienForm nhanVienForm = new NhanVienForm(idAcc, idEmployee);
                        nhanVienForm.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        QuanLyForm managerForm = new QuanLyForm(idAcc, idEmployee, typeAcc);
                         managerForm.ShowDialog();
                    }
                }
                
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
