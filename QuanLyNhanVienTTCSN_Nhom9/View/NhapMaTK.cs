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
    public partial class NhapMaTK : Form
    {
        private string duty = "";  
        public NhapMaTK(string duty)
        {
            InitializeComponent();
            this.duty = duty;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if(duty == "remove")
            {
                string idAcc = idAccountTextBox.Text.ToString();
                ManageForm mana = new ManageForm();
                if(mana.checkIdAccExit(idAcc) == false)
                {
                    MessageBox.Show("Không tồn tại tài khoản có mã: " + idAcc + " trong hệ thống!");
                }
                else
                {
                    mana.removeAccByIdAcc(idAcc);
                    this.Close();
                }    
            }
            else
            {
                string idAcc = idAccountTextBox.Text.ToString();
                if (idAcc == "")
                {
                    MessageBox.Show("Không được để trống mã tài khoản!");
                }
                else
                {
                    ManageForm mana = new ManageForm();
                    DataTable dt = mana.getInforbyIdAcc(idAcc);
                    if (dt.Rows.Count > 0)
                    {
                        SuaTaiKhoan sua = new SuaTaiKhoan(idAcc, dt.Rows[0][3].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][1].ToString(),
                            dt.Rows[0][7].ToString(), dt.Rows[0][4].ToString());
                        this.Hide();
                        sua.ShowDialog();

                    }
                    else
                    {
                        this.Close();
                        MessageBox.Show("Không tồn tại tài khoản có mã tài khoản: " + idAcc);
                    }

                }
            }    
            

        }
    }
}
