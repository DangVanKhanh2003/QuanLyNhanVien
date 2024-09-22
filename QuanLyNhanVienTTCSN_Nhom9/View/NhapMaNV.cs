using QuanLyNhanVienTTCSN_Nhom9.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    public partial class NhapMaNV : Form
    {
        private string typeAcc = "";
        private string duty = "";
        public NhapMaNV(string typeAcc, string duty)
        {
            InitializeComponent();
            this.typeAcc = typeAcc;
            this.duty = duty;
        }

        private void NhapMaNV_Load(object sender, EventArgs e)
        {
            
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (duty == "remove")
            {
                ManageForm mana = new ManageForm();
                string idEmp = maNVTextBox.Text.ToString();
                if (idEmp == "")
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin.");
                }
                else
                {
                    // check id employee exist
                    bool checkEmpExist = mana.checkEmpExist(idEmp, typeAcc);
                    if (checkEmpExist)
                    {
                        DialogResult dialogResult = MessageBox.Show("Nếu xóa thì sẽ mất hết dữ liệu liên quan đến nhân viên." +
                            "Bạn có chắc chắn xóa?", "Confirmation", MessageBoxButtons.YesNo);

                        // Check the user's choice
                        if (dialogResult == DialogResult.Yes)
                        {
                            mana.RemoveData("NghiPhep", "maNV", "'" + idEmp + "'");
                            mana.RemoveData("Luong", "maNV", "'" + idEmp + "'");
                            mana.RemoveData("TangCa", "maNV", "'" + idEmp + "'");
                            mana.RemoveData("TaiKhoan", "maNV", "'" + idEmp + "'");
                            mana.RemoveData("NhanVien", "maNV", "'" + idEmp + "'");

                            MessageBox.Show("Xóa nhân viên thành công!");
                            this.Close();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại nhân viên với mã nhân viên: " + idEmp + " trong hệ thống!");
                        this.Close();
                    }
                }
            }
            else
            {
                ManageForm mana = new ManageForm();
                string idEmp = maNVTextBox.Text.ToString();
                if (idEmp == "")
                {
                    MessageBox.Show("Hãy điền đầy đủ thông tin.");
                }
                else
                {
                    // check id employee exist
                    bool checkEmpExist = mana.checkEmpExist(idEmp, typeAcc);
                    if (checkEmpExist)
                    {
                        // get information 
                        DataTable table = mana.getInforEmpById(idEmp, typeAcc);
                        // create suaNhanVien
                        SuaNhanVienForm repairFrom = new SuaNhanVienForm(typeAcc, idEmp, table.Rows[0][1].ToString(), table.Rows[0][2].ToString(),
                            table.Rows[0][3].ToString(), table.Rows[0][4].ToString(), table.Rows[0][5].ToString(), (DateTime)table.Rows[0][6],
                            (DateTime)table.Rows[0][7], table.Rows[0][8].ToString(), table.Rows[0][11].ToString());

                        this.Hide();
                        repairFrom.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại nhân viên có mã nhân viên " + idEmp + "trong hệ thống");
                    }
                }

            }
        }
    }
}
