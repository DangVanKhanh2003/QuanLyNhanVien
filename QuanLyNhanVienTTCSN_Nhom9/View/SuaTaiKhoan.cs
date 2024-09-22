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
    public partial class SuaTaiKhoan : Form
    {
        private string idAcc = "";
        private string fullName = "";
        private string idEmp = "";
        private string userName = "";
        private string typeAcc = "";
        private string password = "";
        public SuaTaiKhoan(string idAcc, string fullName, string idEmp, string userName, string typeAcc, string password)
        {
            InitializeComponent();
            this.idAcc = idAcc;
            this.fullName = fullName;
            this.idEmp = idEmp;
            this.userName = userName;
            this.typeAcc = typeAcc;
            this.password = password;

        }

        private void SuaTaiKhoan_Load(object sender, EventArgs e)
        {
            ManageForm mana = new ManageForm();
            idEmployeeTextBox.Text = idEmp;
            fullNameTextBox.Text = fullName;
            userNameTextBox.Text = userName;
           
            DataTable tblDepartment = mana.loadTableDepartment();
            List<string> items2 = new List<string>();
            items2.Add("Nhân viên");
            foreach (DataRow row in tblDepartment.Rows)
            {
                items2.Add("Quản lý phòng " + row[0].ToString()); // Convert to string if it's not already
            }

            // Set the ComboBox's DataSource to the list
            typeAccComboBox.DataSource = items2;
            if (typeAcc == "NhanVien")
            {
                typeAccComboBox.Text = "Nhân viên";
            }
            else
            {
                string idDepartment = typeAcc.Substring(6, typeAcc.Length - 6);
                typeAccComboBox.Text = "Quản lý phòng" +  mana.getNameDepbyIdDep(idDepartment);
            }
        }

        private void Comfirm_Click(object sender, EventArgs e)
        {
            string typeAcc = typeAccComboBox.Text.ToString();
            ManageForm mana = new ManageForm();

            if (typeAcc == "Nhân viên")
            {
                mana.repairAcc(idAcc, "NhanVien");
            }   
            else
            {
                string idDep = mana.getIdDepartmentByName(typeAcc.Substring(14, typeAcc.Length - 14));
                mana.repairAcc(idAcc, "QuanLy" + idDep);
            }
            
            this.Close();
        }
    }
}
