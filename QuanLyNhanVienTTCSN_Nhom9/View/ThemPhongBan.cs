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
    public partial class ThemPhongBan : Form
    {
        public ThemPhongBan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tenPhongBanTextBox.Text.ToString();
            if(name == "")
            {
                MessageBox.Show("Không được để trống thông tin!");
            }
            else
            {
                ManageForm mana = new ManageForm();
                bool check = mana.checkDepExistByName(name);
                if(check) 
                {
                    MessageBox.Show("Phòng ban đã tồn tại trong hệ thống!");
                    return;
                }
                mana.addDepartment(name);
                this.Close();
            }    
        }
    }
}
