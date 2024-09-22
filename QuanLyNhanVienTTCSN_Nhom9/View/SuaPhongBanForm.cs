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
using System.Xml.Linq;

namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    public partial class SuaPhongBanForm : Form
    {
        private string id = "";
        private string oldName = "";
        public SuaPhongBanForm(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newName = NewNameTextBox.Text.ToString();
            if(newName == "")
            {
                MessageBox.Show("Không được để trống thông tin!");
            }
            else
            {
                if(newName == oldName)
                {
                    MessageBox.Show("Tên mới không thể giống với tên cũ!");
                }    
                else
                {
                    ManageForm mana = new ManageForm();
                    bool check = mana.checkDepExistByName(newName);
                    if (check)
                    {
                        MessageBox.Show("Phòng ban đã tồn tại trong hệ thống!");
                        return;
                    }
                    mana.repairDepartment(id, newName);
                    this.Close();
                }    
            }    
        }

        private void SuaPhongBanForm_Load(object sender, EventArgs e)
        {
            idDep.Text = id;
            ManageForm mana = new ManageForm();
            string name = mana.getNameDepbyIdDep(id);
            if(name == "")
            {
                this.Close();
            }    
            NewNameTextBox.Text = name;
            oldName = name;
        }
    }
}
