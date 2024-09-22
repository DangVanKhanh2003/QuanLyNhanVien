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
    public partial class NhapMaNghiPhep : Form
    {
        private string typeAcc = "";
        private string duty = "";
        public NhapMaNghiPhep(string typeAcc, string duty)
        {
            InitializeComponent();
            this.typeAcc = typeAcc;
            this.duty = duty;
        }

        private void confirm_Click(object sender, EventArgs e)
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
                        // bug
                        DataTable table2 = mana.getOnLeaveByIdEmp(idEmployee, year, month);
                        table2.Columns[0].ColumnName = "Mã nghỉ phép";
                        table2.Columns[1].ColumnName = "Mã nhân viên";
                        table2.Columns[2].ColumnName = "Họ tên nhân viên";
                        table2.Columns[3].ColumnName = "Chức vụ";
                        table2.Columns[4].ColumnName = "Phòng ban";
                        table2.Columns[7].ColumnName = "Nghỉ từ ngày";
                        table2.Columns[8].ColumnName = "Nghỉ đến ngày";


                        if (table2.Rows.Count > 0)
                        {
                            XoaNghiPhepForm xoa = new XoaNghiPhepForm(typeAcc, idEmployee, table2, year, month);
                            this.Hide();
                            xoa.ShowDialog();
                        }
                        else
                        {
                            this.Hide();
                            DialogResult result = MessageBox.Show("Không tìm thấy thông tin về nghỉ phép của nhân viên trong tháng" +
                                " gần nhất. Nếu muốn tiếp tục hãy ấn 'Yes'.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                //bug
                                XoaNghiPhepForm xoa = new XoaNghiPhepForm(typeAcc, idEmployee, table2, year, month) ;

                                this.Hide();
                                xoa.ShowDialog();
                            }
                            else
                            {
                                this.Close();

                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại trong hệ thống!");
                    }
                }

            }
            else if(duty == "detailOnLeave")
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
                        // 
                        DataTable table2 = mana.getOnLeaveByIdEmp(idEmployee, year, month);
                        table2.Columns[0].ColumnName = "Mã nghỉ phép";
                        table2.Columns[1].ColumnName = "Mã nhân viên";
                        table2.Columns[2].ColumnName = "Họ tên nhân viên";
                        table2.Columns[3].ColumnName = "Chức vụ";
                        table2.Columns[4].ColumnName = "Phòng ban";
                        table2.Columns[7].ColumnName = "Nghỉ từ ngày";
                        table2.Columns[8].ColumnName = "Nghỉ đến ngày";


                        if (table2.Rows.Count > 0)
                        {
                            ChiTietNghiPhepForm form = new ChiTietNghiPhepForm(typeAcc, idEmployee, table2, year, month);
                            this.Hide();
                            form.ShowDialog();
                        }
                        else
                        {
                            this.Hide();
                            DialogResult result = MessageBox.Show("Không tìm thấy thông tin về nghỉ phép của nhân viên trong tháng" +
                                " gần nhất. Nếu muốn tiếp tục hãy ấn 'Yes'.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                //bug
                                ChiTietNghiPhepForm form = new ChiTietNghiPhepForm(typeAcc, idEmployee, table2, year, month);

                                this.Hide();
                                form.ShowDialog();
                            }
                            else
                            {
                                this.Close();

                            }

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
                        // bug
                        DataTable table2 = mana.getOnLeaveByIdEmp(idEmployee, year, month);
                        table2.Columns[0].ColumnName = "Mã nghỉ phép";
                        table2.Columns[1].ColumnName = "Mã nhân viên";
                        table2.Columns[2].ColumnName = "Họ tên nhân viên";
                        table2.Columns[3].ColumnName = "Chức vụ";
                        table2.Columns[4].ColumnName = "Phòng ban";
                        table2.Columns[7].ColumnName = "Nghỉ từ ngày";
                        table2.Columns[8].ColumnName = "Nghỉ đến ngày";

                        if (table2.Rows.Count > 0)
                        {
                            SuaNghiPhepFrom sua = new SuaNghiPhepFrom(typeAcc, idEmployee, table2, year, month);
                            this.Hide();
                            sua.ShowDialog();
                        }
                        else
                        {
                            this.Hide();
                            DialogResult result = MessageBox.Show("Không tìm thấy thông tin về nghỉ phép của nhân viên trong tháng" +
                                " gần nhất. Nếu muốn tiếp tục hãy ấn 'Yes'.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                //bug
                                SuaNghiPhepFrom sua = new SuaNghiPhepFrom(typeAcc, idEmployee, table2, year, month);

                                this.Hide();
                                sua.ShowDialog();
                            }
                            else
                            {
                                this.Close();

                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại trong hệ thống!");
                    }
                }
            }
        }

        private void NhapMaNghiPhep_Load(object sender, EventArgs e)
        {

        }
    }
}
