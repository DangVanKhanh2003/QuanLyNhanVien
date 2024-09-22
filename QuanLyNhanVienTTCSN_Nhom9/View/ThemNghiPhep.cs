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
    public partial class ThemNghiPhep : Form
    {
        private string typeAcc = "";
        DataGridView dgv = null;
        public ThemNghiPhep(string typeAcc, DataGridView dgv)
        {
            InitializeComponent();
            this.typeAcc = typeAcc;
            this.dgv = dgv;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            DateTime dateTo = (DateTime)toDatePickTime.Value;
            DateTime dateFrom = (DateTime)fromDatePickTime.Value;
            ManageForm mana = new ManageForm();
            mana.addOnLeave(typeAcc, idEmployeeTextBox.Text.ToString(), dateTo, dateFrom);
            this.Close();

        }

        private void toDatePickTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
