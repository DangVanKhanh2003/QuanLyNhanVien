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
    public partial class NhapMaLuong : Form
    {
        private string typeAcc = "";
        private string duty = "";
        public NhapMaLuong(string typeAcc, string duty )
        {
            InitializeComponent();
            this.typeAcc = typeAcc;
            this.duty = duty;
        }

        private void confirm_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void confirm_Click_1(object sender, EventArgs e)
        {
            if (duty == "remove")
            {

                string idEmployee = idEmpTextBox.Text;
                // check input empty
                if (idEmployee == "")
                {
                    MessageBox.Show("Không được để trống mã sinh viên!");
                }
                else
                {
                    ManageForm mana = new ManageForm();
                    bool check = mana.checkEmpExist(idEmployee, typeAcc);
                    DateTime now = DateTime.Now;
                    int year = now.Year;
                    int month = now.Month;
                    if (month == 1)
                    {
                        year = now.Year - 1;
                        month = 12;
                    }
                    else
                    {
                        month = now.Month - 1;
                    }
                    DateTime date = new DateTime(year, month, 1);

                    if (check)
                    {

                        DataTable table = mana.findSalary(typeAcc, idEmployee, "", -1, -1, -1, -1, -1, year, month);
                        if (table.Rows.Count > 0)
                        {
                            XoaLuongForm xoa = new XoaLuongForm(idEmployee, typeAcc, table.Rows[0][1].ToString(),
                                (int)decimal.Parse(table.Rows[0][4].ToString()), (int)decimal.Parse(table.Rows[0][5].ToString()),
                                (int)decimal.Parse(table.Rows[0][7].ToString()), (int)decimal.Parse(table.Rows[0][6].ToString()), date);
                           
                            this.Hide();
                            xoa.ShowDialog();
                        }
                        else
                        {
                            XoaLuongForm xoa = new XoaLuongForm(idEmployee, typeAcc, "", -1, -1, -1, -1, date);
                            this.Hide();
                            xoa.ShowDialog();
                           
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại trong hệ thống!");
                    }
                }

            }
            else
            {
                string idEmployee = idEmpTextBox.Text;
                // check input empty
                if (idEmployee == "")
                {
                    MessageBox.Show("Không được để trống mã sinh viên!");
                }
                else
                {
                    ManageForm mana = new ManageForm();
                    bool check = mana.checkEmpExist(idEmployee, typeAcc);
                    DateTime now = DateTime.Now;
                    int year = now.Year;
                    int month = now.Month;
                    if (month == 1)
                    {
                        year = now.Year - 1;
                        month = 12;
                    }
                    else
                    {
                        month = now.Month - 1;
                    }
                    DateTime date = new DateTime(year, month, 1);

                    if (check)
                    {

                        DataTable table = mana.findSalary(typeAcc, idEmployee, "", -1, -1, -1, -1, -1, year, month);
                        if (table.Rows.Count > 0)
                        {
                            SuaLuongFrom sua = new SuaLuongFrom(idEmployee, typeAcc, duty, table.Rows[0][1].ToString(),
                                (int)decimal.Parse(table.Rows[0][4].ToString()), (int)decimal.Parse(table.Rows[0][5].ToString()),
                                (int)decimal.Parse(table.Rows[0][7].ToString()), (int)decimal.Parse(table.Rows[0][6].ToString()), date);
                            this.Hide();
                            sua.ShowDialog();

                        }
                        else
                        {
                            SuaLuongFrom sua = new SuaLuongFrom(idEmployee, typeAcc, duty, "", -1, -1, -1, -1, date);
                            this.Hide();
                            sua.ShowDialog();


                        }

                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại trong hệ thống!");
                    }



                }
            }
        }
    }
}
