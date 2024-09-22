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
    public partial class SuaNghiPhepForm2 : Form
    {
        private string idEmp = "";
        private string idOnLeave = "";
        private string fullName = "";
        private DateTime dateFrom = new DateTime();
        private DateTime dateTo = new DateTime();
        private string typeAcc = "";
        public SuaNghiPhepForm2(string idEmp, string idOnLeave, string fullName,DateTime dateFrom, DateTime dateTo, string typeAcc)
        {
            InitializeComponent();
            this.idEmp = idEmp;
            this.idOnLeave = idOnLeave;
            this.fullName = fullName;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            this.typeAcc = typeAcc;
        }

        private void SuaNghiPhepForm2_Load(object sender, EventArgs e)
        {
            idEmployeeTextBox.Text = idEmp;
            fullNameTextBox.Text = fullName;
            fromDatePickTime.Value = dateFrom;
            toDatePickTime.Value= dateTo;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            ManageForm manage = new ManageForm();
            manage.repairOnLeave(idOnLeave, fromDatePickTime.Value, toDatePickTime.Value, idEmp, typeAcc);
            this.Close();
        }
    }
}
