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
    public partial class NhapMaPhongBan : Form
    {
        private string duty = "";
        public NhapMaPhongBan(string duty)
        {
            InitializeComponent();
            this.duty = duty;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (duty == "remove")
            {
                string id = idDepartmentTextBox.Text.ToString();
                if(id == "")
                {
                    MessageBox.Show("Không được để trống thông tin!");
                }
                else
                {
                     ManageForm mana = new ManageForm();
                    mana.removeDepartment(id);
                    this.Close();
                }
            }
            else
            {
                string id = idDepartmentTextBox.Text.ToString();
                if (id == "")
                {
                    MessageBox.Show("Không được để trống thông tin!");
                }
                else
                {
                    SuaPhongBanForm sua = new SuaPhongBanForm(id);
                    this.Hide();
                    sua.ShowDialog();
                }
            }
           

        }

        private void NhapMaPhongBan_Load(object sender, EventArgs e)
        {

        }
    }
}
