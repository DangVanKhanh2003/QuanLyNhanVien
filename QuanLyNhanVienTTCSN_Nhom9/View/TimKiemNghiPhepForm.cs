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
    public partial class TimKiemNghiPhepForm : Form
    {
        private string typeAcc = null;
        private DataGridView tableOnLeave = null;
        private Label monthYear = null;
        public TimKiemNghiPhepForm(string typeAcc, DataGridView dtv, Label monthYear)
        {
            InitializeComponent();
            this.typeAcc = typeAcc;
            this.tableOnLeave = dtv;
            this.monthYear = monthYear;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            DateTime selectedMonth = monthPicke.Value;
            ManageForm mana = new ManageForm();
            DataTable dt = new DataTable();
            dt = mana.findOnLeave(typeAcc, idEmployeeTextBox.Text.ToString(), selectedMonth.Month,
                selectedMonth.Year, fullNameTexBox.Text.ToString(), positionComBox.Text.ToString());
            tableOnLeave.DataSource = dt;
            monthYear.Text = selectedMonth.Month.ToString() + "-" + selectedMonth.Year.ToString();

            this.Close();
        }

        private void toDatePickTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TimKiemNghiPhepForm_Load(object sender, EventArgs e)
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
            positionComBox.DataSource = items;
        }

        private void positionComBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
    }
}
