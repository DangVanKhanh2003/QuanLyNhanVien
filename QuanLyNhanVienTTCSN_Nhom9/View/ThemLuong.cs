using QuanLyNhanVienTTCSN_Nhom9.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    public partial class ThemLuong : Form
    {
        string typeAcc = null;
        DataGridView dgv = null;
        public ThemLuong(string typeAcc, DataGridView dgv)
        {
            InitializeComponent();
            this.typeAcc = typeAcc;
            this.dgv = dgv;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ThemLuong_Load(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            DateTime date = (DateTime)dateTimePicker1.Value;
            if (BigInteger.TryParse(stiffSalaryTextBox.Text.ToString(), out BigInteger intValue) &&
                BigInteger.TryParse(bonusTextBox.Text.ToString(), out BigInteger intValue2)&& 
                BigInteger.TryParse(allowancesTextBox.Text.ToString(), out BigInteger intValue3) &&
                BigInteger.TryParse(salaryAdvancesTextBox.Text.ToString(), out BigInteger intValue4))
            {
                ManageForm manage = new ManageForm();
                manage.addSalary(typeAcc, idEmployeeTextBox.Text.ToString(), stiffSalaryTextBox.Text.ToString(), bonusTextBox.Text.ToString(),
                    allowancesTextBox.Text.ToString(), salaryAdvancesTextBox.Text.ToString(), date.Year + "-" + date.Month);
            }
            else
            {
                MessageBox.Show("Bạn nhập không đúng định dạng. Hãy kiểm tra lại!");
            }
            this.Close();
        }

        private void stiffSalaryTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
