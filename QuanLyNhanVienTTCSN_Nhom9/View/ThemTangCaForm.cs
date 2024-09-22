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
    public partial class ThemTangCaForm : Form
    {
        private string typeAcc = "";
        public ThemTangCaForm(string typeAcc)
        {
            InitializeComponent();
            this.typeAcc = typeAcc;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string idEmp = idEmpTextBox.Text.ToString();
            int timeOT = (int)timeOTUpDown.Value;
            DateTime dateOT = (DateTime)MonthYearPickTime.Value;
            string typeOT = TypeComboBox.Text.ToString();
            ManageForm mana  = new ManageForm();
            mana.addOT(typeAcc, idEmp, timeOT, dateOT, typeOT);
            this.Close();
        }

        private void TypeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void MonthYearPickTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void timeOTUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
    }
}
