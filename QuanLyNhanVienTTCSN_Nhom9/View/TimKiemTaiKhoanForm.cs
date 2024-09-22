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
    public partial class TimKiemTaiKhoanForm : Form
    {
        private string typeAcc = "";
        private DataGridView dgv = null;
        private DataTable dt = null;
        public TimKiemTaiKhoanForm(string typeAcc, DataGridView dgv, DataTable dt)
        {
            InitializeComponent();
            this.typeAcc = typeAcc;
            this.dgv = dgv;
            this.dt = dt;
        }

        private void Comfirm_Click(object sender, EventArgs e)
        {
            ManageForm manage = new ManageForm();
            DataTable table = manage.searchAccount(dt, idEmployeeTextBox.Text.ToString(), userNameTextBox.Text.ToString(), positionComboBox.Text.ToString(),
                deparmentComboBox.Text.ToString(), FullNameTextBox.Text.ToString());
            dgv.DataSource = table;
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TimKiemTaiKhoanForm_Load(object sender, EventArgs e)
        {
            ManageForm mana = new ManageForm();
            DataTable tblPosition = mana.loadTablePosition(typeAcc);
            List<string> items = new List<string>();
            items.Add("Tất cả");
            foreach (DataRow row in tblPosition.Rows)
            {
                items.Add(row[0].ToString()); // Convert to string if it's not already
            }

            // Set the ComboBox's DataSource to the list
            positionComboBox.DataSource = items;

            DataTable tblDepartment = mana.loadTableDepartment();
            List<string> items2 = new List<string>();
            items2.Add("Tất cả");
            foreach (DataRow row in tblDepartment.Rows)
            {
                items2.Add(row[0].ToString()); // Convert to string if it's not already
            }

            // Set the ComboBox's DataSource to the list
            deparmentComboBox.DataSource = items2;

        }

        private void deparmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deparmentComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void positionComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
    }
}
