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
    public partial class TimKiemTangCaForm : Form
    {
        private string typeAcc = "";
        private DataGridView dgv = null;
        private Label timeLab = null;
        public TimKiemTangCaForm(String typeAcc, DataGridView dgv, Label timeLab)
        {
            InitializeComponent();
            this.dgv = dgv;
            this.typeAcc = typeAcc;
            this.timeLab = timeLab;
        }

        private void TimKiemTangCaForm_Load(object sender, EventArgs e)
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
            PositionComboBox.DataSource = items;

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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TypeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DepartmentComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void PositionComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void timeOTUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            ManageForm mana = new ManageForm();
            string idOT = idOTTextBox.Text.ToString();
            string name = FullNameTextBox.Text.ToString();
            int timeOT = (int)timeOTUpDown.Value;
            string typeOT = TypeComboBox.Text.ToString();
            int month = ((DateTime)MonthYearPickTime.Value).Month;
            int year = ((DateTime)MonthYearPickTime.Value).Year;
            string position = PositionComboBox.Text.ToString();
            string department = DepartmentComboBox.Text.ToString();
            string idEmp = idEmpTextBox.Text.ToString();
            bool check = checkTimeOT.Checked;
            DataTable tbl = mana.findOT(typeAcc, idOT, idEmp, name, timeOT, typeOT, month, year, position, department, check);
            dgv.DataSource = tbl;
            timeLab.Text = month + "-" + year;
            this.Close();
        }

        private void checkTimeOT_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
