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
    public partial class TimKiemChucVuForm : Form
    {
        private DataGridView dgv = null;
        public TimKiemChucVuForm(DataGridView dgv)
        {
            InitializeComponent();
            this.dgv = dgv;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string idPosition = idPositionTextBox.Text;
            string namePosition = NamePositonTextBox.Text;
            string nameDepartment = DepartmentComboBox.Text;
            ManageForm mana = new ManageForm();
            DataTable tbl = mana.findPosition(idPosition, namePosition, nameDepartment);
            dgv.DataSource = tbl;
            this.Close();
        }

        private void TimKiemChucVuForm_Load(object sender, EventArgs e)
        {
            ManageForm mana = new ManageForm();

            DataTable tblDepartment = mana.loadTableDepartment();
            List<string> items2 = new List<string>();
            items2.Add("Tất cả");
            foreach (DataRow row in tblDepartment.Rows)
            {
                items2.Add(row[0].ToString()); // Convert to string if it's not already
            }

            // Set the ComboBox's DataSource to the list
            DepartmentComboBox.DataSource = items2;
        }
    }
}
