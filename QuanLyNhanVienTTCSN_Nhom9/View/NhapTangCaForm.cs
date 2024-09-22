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
    public partial class NhapTangCaForm : Form
    {
        private string typeAcc = "";
        private string duty = "";
        public NhapTangCaForm(string typeAcc, string duty)
        {
            InitializeComponent();
            this.typeAcc = typeAcc;
            this.duty = duty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = idOT.Text.ToString();
            if (id == "")
            {
                MessageBox.Show("Không được để trống mã tăng ca.");
            }
            else
            {
                ManageForm mana = new ManageForm();
                bool check = mana.checkOTExistById(id);
                if (!check) 
                {
                    MessageBox.Show("Không tim thấy dữ liệu tăng ca có mã tăng ca là: " + id);
                    return;
                }
                WorkWithDatabase work = new WorkWithDatabase();
                if(typeAcc == "Admin")
                {
                    if (duty == "remove")
                    {
                        mana.deleteOTById(id, typeAcc);
                    }
                    else
                    {
                        SuaTangCaForm sua = new SuaTangCaForm(typeAcc, id);
                        sua.ShowDialog();
                    }
                }
                else
                {
                    string command = "SELECT * FROM TangCa WHERE maTangCa = '" + id + "'";
                    DataTable dt = work.loadDataFromDB(command);
                    string dep1 = mana.getIdDepByIdEmp(dt.Rows[0][1].ToString());
                    string dep2 = mana.getIdDepByTypeAcc(typeAcc);
                    if (dep1 == dep2)
                    {
                        if (duty == "remove")
                        {
                            mana.deleteOTById(id, typeAcc);
                        }
                        else
                        {
                            SuaTangCaForm sua = new SuaTangCaForm(typeAcc, id);
                            sua.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã tăng ca này không thuộc thẩm quyền quản lý của bạn!");
                    }
                }
                
            }
            this.Hide();
        }
    }
}
