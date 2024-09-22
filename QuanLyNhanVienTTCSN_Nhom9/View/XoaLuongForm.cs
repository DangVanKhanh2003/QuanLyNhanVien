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
    public partial class XoaLuongForm : Form
    {
        private string typeAcc = "";
        private string idEmp = "";
        public XoaLuongForm(string idEmp, string typeAcc, string fullName, int salary,
            int bonus, int allowances, int advances, DateTime date)
        {
            InitializeComponent();
            this.idEmp = idEmp;
            this.typeAcc = typeAcc;
            string strSalary = "";
            string strBonus = "";
            string strAllowances = "";
            string strAvances = "";
            if (salary != -1)
            {
                strSalary = salary.ToString();
            }
            if (bonus != -1)
            {
                strBonus = bonus.ToString();
            }
            if (allowances != -1)
            {
                strAllowances = allowances.ToString();
            }
            if (advances != -1)
            {
                strAvances = advances.ToString();
            }
            idEmployeeTextBox.Text = idEmp;
            fullNameTextBox.Text = fullName;
            stiffSalaryTextBox.Text = strSalary;
            bonusTextBox.Text = strBonus;
            allowancesTextBox.Text = strAllowances;
            salaryAdvancesTextBox.Text = strAvances;
            dateTimePicker1.Value = date;

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            DateTime date = (DateTime)dateTimePicker1.Value;
            ManageForm manage = new ManageForm();
            // REMOVE
            manage.removeSalary(typeAcc, idEmployeeTextBox.Text.ToString(), date);
            this.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = (DateTime)dateTimePicker1.Value;
            ManageForm mana = new ManageForm();
            DataTable table = mana.findSalary(typeAcc, idEmp, "", -1, -1, -1, -1, -1, date.Year, date.Month);

            if (table.Rows.Count > 0)
            {
                idEmployeeTextBox.Text = idEmp;
                fullNameTextBox.Text = table.Rows[0][1].ToString();
                stiffSalaryTextBox.Text = ((int)decimal.Parse(table.Rows[0][4].ToString())).ToString();
                bonusTextBox.Text = ((int)decimal.Parse(table.Rows[0][5].ToString())).ToString();
                allowancesTextBox.Text = ((int)decimal.Parse(table.Rows[0][7].ToString())).ToString();
                salaryAdvancesTextBox.Text = ((int)decimal.Parse(table.Rows[0][6].ToString())).ToString();
                dateTimePicker1.Value = date;
            }
            else
            {
                DialogResult result = MessageBox.Show("Không tồn tại lương trong tháng vừa chọn. Bạn có muốn tiếp tục", 
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    stiffSalaryTextBox.Text = "";
                    bonusTextBox.Text = "";
                    allowancesTextBox.Text = "";
                    salaryAdvancesTextBox.Text = "";
                    dateTimePicker1.Value = date;
                }
                else
                {
                    this.Close();
                }

            }
        }
    }
}
