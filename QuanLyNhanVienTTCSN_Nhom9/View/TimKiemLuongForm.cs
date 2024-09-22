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
    public partial class TimKiemLuongForm : Form
    {
        DataGridView dgvEmployee = null;
        string typeAcc = null;
        Label thangNam = null;
        public TimKiemLuongForm(DataGridView dgv, string type, Label thangNam)
        {
            InitializeComponent();
            this.typeAcc = type;
            this.dgvEmployee = dgv;
            this.thangNam = thangNam;
        }

        private void TimKiemLuongForm_Load(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            ManageForm mana = new ManageForm();
            DataTable dt = new DataTable();
            BigInteger salary = -1;
            BigInteger bounus = -1;
            BigInteger allowance = -1;
            BigInteger advance = -1;
            BigInteger totalSal = -1;

            DateTime selectedDate = dateTimePicker1.Value;
            try
            {
                if(stiffSalaryTextBox.Text.ToString() != "")
                {
                    if (!BigInteger.TryParse(stiffSalaryTextBox.Text.ToString(), out salary))
                    {
                        MessageBox.Show("Lương cứng không đúng định dạng!");
                        this.Close();
                    }
                    else
                    {
                        salary = BigInteger.Parse(stiffSalaryTextBox.Text.ToString());

                    }    
                }
                
                if(bonusTextBox.Text.ToString() != "")
                {
                    if (!BigInteger.TryParse(bonusTextBox.Text.ToString(), out bounus))
                    {
                        MessageBox.Show("Thưởng không đúng định dạng!");
                        this.Close();
                    }
                    else
                    {
                        bounus = BigInteger.Parse(bonusTextBox.Text.ToString());

                    }
                }
                if(allowancesTextBox.Text.ToString() != "")
                {
                    if (!BigInteger.TryParse(allowancesTextBox.Text.ToString(), out allowance))
                    {
                        MessageBox.Show("Trợ cấp trước không đúng định dạng!");
                        this.Close();
                    }
                    else
                    {
                        allowance = BigInteger.Parse(allowancesTextBox.Text.ToString());

                    }
                }
                
                if(salaryAdvancesTextBox.Text.ToString() != "")
                {
                    if (!BigInteger.TryParse(salaryAdvancesTextBox.Text.ToString(), out advance))
                    {
                        MessageBox.Show("Lương ứng trước không đúng định dạng!");
                        this.Close();
                    }
                    else
                    {
                        advance = BigInteger.Parse(salaryAdvancesTextBox.Text.ToString());

                    }
                }
                if(totalSalTextBox.Text.ToString() != "")
                {
                    if (!BigInteger.TryParse(totalSalTextBox.Text.ToString(), out totalSal))
                    {
                        MessageBox.Show("Lương cứng không đúng định dạng!");
                        this.Close();
                    }
                    else
                    {
                        totalSal = BigInteger.Parse(totalSalTextBox.Text.ToString());

                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            dt = mana.findSalary(typeAcc, idEmployeeTextBox.Text.ToString(), fullNameTextBox.Text.ToString(),
                salary, bounus, allowance, advance, totalSal, selectedDate.Year, selectedDate.Month);
            dgvEmployee.DataSource = dt;
            thangNam.Text = selectedDate.Month + "-" + selectedDate.Year;
            this.Close();
        }

        private void idEmployeeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
