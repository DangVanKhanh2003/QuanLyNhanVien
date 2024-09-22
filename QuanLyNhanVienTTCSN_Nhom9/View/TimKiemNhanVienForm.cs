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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    public partial class TimKiemNhanVienForm : Form
    {
        DataTable tableEmployee = new DataTable();
        DataGridView dgvEmployee = null;
        string typeAcc = null;
        public TimKiemNhanVienForm(DataTable tableEmployees, DataGridView dgvEmployees, string typeAcc)
        {
            InitializeComponent();
            this.tableEmployee = tableEmployees;
            this.dgvEmployee = dgvEmployees;
            this.typeAcc = typeAcc;
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageForm management = new ManageForm();
            if (!dateJoinCompany.Checked)
            {
                // hide date value since it's not set
                dateJoinCompany.CustomFormat = " ";
                dateJoinCompany.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dateJoinCompany.Format = DateTimePickerFormat.Custom;
                dateJoinCompany.CustomFormat = "dd/MM/yyyy";
            }

            if (!dateOfBirth.Checked)
            {
                // hide date value since it's not set
                dateOfBirth.CustomFormat = " ";
                dateOfBirth.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dateOfBirth.Format = DateTimePickerFormat.Custom;
                dateOfBirth.CustomFormat = "dd/MM/yyyy";
            }
            // Assuming you have a DateTimePicker named datePicker
           
            
            DataTable tableFind = management.findEmployee(tableEmployee, idEmpTextBox.Text.ToString(), fullNameTextBox.Text.ToString(), addressTextBox.Text.ToString(),
                phoneNumberTextBox.Text.ToString(), identificationCardTextBox.Text.ToString(), mailTextBox.Text.ToString(),
                dateOfBirth.Text.ToString(), dateJoinCompany.Text.ToString(), genderCombobox.Text.ToString(), positionComboBox.Text.ToString());
            dgvEmployee.DataSource = tableFind;
        }

        private void genderCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TimKiemNhanVienForm_Load(object sender, EventArgs e)
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
        }

        private void genderCombobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }

        private void positionComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
    }
}
