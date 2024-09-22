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
    public partial class SuaTangCaForm : Form
    {
        private string typeAcc = "";
        private string idOT = "";
        private DateTime oldDate = new DateTime();
        public SuaTangCaForm(string typeAcc, string idOT)
        {
            InitializeComponent();
            this.typeAcc = typeAcc;
            this.idOT = idOT;
        }

        private void timeOTUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void MonthYearPickTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void TypeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string idEmp = idEmpTextBox.Text.ToString();
            int timeOT = (int)timeOTUpDown.Value;
            DateTime dateOT = (DateTime)MonthYearPickTime.Value;
            string typeOT = TypeComboBox.Text.ToString();
            ManageForm mana = new ManageForm();
            mana.repairOT(typeAcc,idOT, idEmp, timeOT, dateOT, typeOT, oldDate);
            this.Close();
        }

        private void SuaTangCaForm_Load(object sender, EventArgs e)
        {
            ManageForm mana = new ManageForm();
            DataTable dt = mana.loadOTById(idOT);
            idEmpTextBox.Text = dt.Rows[0][1].ToString();
            timeOTUpDown.Text = dt.Rows[0][2].ToString();
            MonthYearPickTime.Text = dt.Rows[0][3].ToString();
            TypeComboBox.Text = dt.Rows[0][4].ToString();
            oldDate = (DateTime)dt.Rows[0][3];
        }
    }
}
