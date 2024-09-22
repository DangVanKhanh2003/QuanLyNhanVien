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
    public partial class SuaChucVuForm : Form
    {
        private string id;
        private string oldPosition = "";
        public SuaChucVuForm(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void SuaChucVuForm_Load(object sender, EventArgs e)
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

            DataTable tbl = mana.getInforPositionbyIdPos(id);
            IdPositionTextBox.Text = tbl.Rows[0][0].ToString();
            NamePositonTextBox.Text = tbl.Rows[0][1].ToString();
            DepartmentComboBox.Text = tbl.Rows[0][2].ToString();
            oldPosition = tbl.Rows[0][1].ToString();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            ManageForm mana = new ManageForm();
            string namePosition = NamePositonTextBox.Text;
            string nameDepartment = DepartmentComboBox.Text;
            string idDepartment = mana.getIdDepartmentByName(nameDepartment);
            if (nameDepartment == "" || namePosition == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
            }
            else
            {
                bool checkPosExist = mana.checkPosExistByName(namePosition);
                if (checkPosExist && oldPosition != namePosition)
                {
                    MessageBox.Show("Đã tồn tại chức vụ: \"" + namePosition + "\" trong hệ thống!");
                    this.Close();
                    return;
                }
                mana.repairPosition(id, namePosition, idDepartment);
                this.Close();
            }
        }
    }
}
