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

    public partial class NhapMaChucVu : Form
    {
        private string duty = "";

        public NhapMaChucVu(string duty)
        {
            InitializeComponent();
            this.duty = duty;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string idPosition = idPositonTextBox.Text.ToString();
            if(idPosition == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
            }
            else
            {
                if (duty == "remove")
                {
                    ManageForm mana = new ManageForm();
                    bool checkPosExist = mana.checkPositionExist(idPosition);
                    if (checkPosExist)
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa?", "Confirmation", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Check the user's response
                        if (result == DialogResult.Yes)
                        {
                            mana.removePosition(idPosition);
                            this.Hide();
                        }
                        else
                        {
                            this.Close();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại chức vụ có mã chức vụ là: \"" + idPosition + "\" trong hệ thống!");
                        this.Close();
                    }
                }
                else
                {
                    ManageForm mana = new ManageForm();
                    bool checkPosExist = mana.checkPositionExist(idPosition);
                    if (checkPosExist) 
                    {
                        SuaChucVuForm sua = new SuaChucVuForm(idPosition);
                        sua.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại chức vụ có mã chức vụ là: " + idPosition + " trong hệ thống!");
                        this.Close();
                    }
                    
                }
            }
            
        }
    }
}
