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
    public partial class ThemChucVu : Form
    {
        public ThemChucVu()
        {
            InitializeComponent();
        }

        private void ThemChucVu_Load(object sender, EventArgs e)
        {

            ManageForm mana = new ManageForm();
            DataTable tblDepartment = mana.loadTableDepartment();
            List<string> items = new List<string>();
            foreach (DataRow row in tblDepartment.Rows)
            {
                items.Add(row[0].ToString()); // Convert to string if it's not already
            }

            // Set the ComboBox's DataSource to the list
            DepartmentComboBox.DataSource = items;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string namePosition = positonTextBox.Text;
            string nameDepartment = DepartmentComboBox.Text;

            if(nameDepartment == "" || namePosition == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin");
            }    
            else
            {

                ManageForm mana = new ManageForm();
                bool checkPosExist = mana.checkPosExistByName(namePosition);
                if(checkPosExist)
                {
                    MessageBox.Show("Đã tồn tại chức vụ: \"" + namePosition + "\" trong hệ thống!");
                    this.Close();
                    return;
                }
                mana.addPosition(namePosition, nameDepartment);
                this.Close();
            }    
        }

        private void DepartmentComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
    }
}
