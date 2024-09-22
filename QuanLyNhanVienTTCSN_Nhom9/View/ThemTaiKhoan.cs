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
    public partial class ThemTaiKhoan : Form
    {
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThemTaiKhoan_Load(object sender, EventArgs e)
        {
            ManageForm mana = new ManageForm();
            DataTable tblDepartment = mana.loadTableDepartment();
            List<string> items2 = new List<string>();
            items2.Add("Nhân viên");
            foreach (DataRow row in tblDepartment.Rows)
            {
                items2.Add("Quản lý phòng " + row[0].ToString()); // Convert to string if it's not already
            }

            // Set the ComboBox's DataSource to the list
            typeAccComboBox.DataSource = items2;
        }

        private void Comfirm_Click(object sender, EventArgs e)
        {
            string type = typeAccComboBox.Text.ToString();
            if(type == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!");
            }    
            else if( type == "Nhân viên")
            {
                ManageForm mana = new ManageForm();
                mana.addAccount(idEmployeeTextBox.Text.ToString(), userNameTextBox.Text.ToString(), passwordTextBox.Text.ToString(), "NhanVien");

            }
            else
            {
                string nameDepartment = type.Substring(14, type.Length - 14);
                ManageForm mana = new ManageForm();
                string idDepartment = mana.getIdDepartmentByName(nameDepartment);
                string typeAcc = "QuanLy" + idDepartment;
                mana.addAccount(idEmployeeTextBox.Text.ToString(), userNameTextBox.Text.ToString(), passwordTextBox.Text.ToString(), typeAcc);
            }
            this.Close();
        }

        private void typeAccComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
    }
}
