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
    public partial class ChiTietQuanLyForm : Form
    {
        private string idEmp = "";
        public ChiTietQuanLyForm(string idEmp)
        {
            InitializeComponent();
            this.idEmp = idEmp;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChiTietQuanLyForm_Load(object sender, EventArgs e)
        {
            // Calculate the new size for the DataGridView based on the form size
            int newWidth = this.ClientSize.Width;
            int newHeight = this.ClientSize.Height;

            // Set the new size for the DataGridView
            tableSal.Size = new Size(newWidth - 15, newHeight - 15);
            dataGridViewLeave.Size = new Size(newWidth, newHeight - 15);
            tableOT.Size = new Size(newWidth, newHeight - 15);
            tableSal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLeave.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableOT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            loadOnLeave();
            loadOT();
            loadSal();
        }

        private void loadSal()
        {
            int year = ((DateTime)dateTimePicker3.Value).Year;
            int month = ((DateTime)dateTimePicker3.Value).Month;
            ManageForm mana = new ManageForm();
            DataTable dt = mana.findSalary("Admin", idEmp, "", -1, -1, -1, -1, -1, year, month);
            tableSal.DataSource = dt;
        }

        private void loadOnLeave()
        {
            ManageForm mana = new ManageForm();
            DateTime date = dateTimePicker2.Value;
            int year = date.Year;
            int month = date.Month;
            DataTable table = mana.getOnLeaveByIdEmp(idEmp, year, month);
            table.Columns[0].ColumnName = "Mã nghỉ phép";
            table.Columns[1].ColumnName = "Mã nhân viên";
            table.Columns[2].ColumnName = "Họ tên nhân viên";
            table.Columns[3].ColumnName = "Chức vụ";
            table.Columns[4].ColumnName = "Phòng ban";
            table.Columns[7].ColumnName = "Nghỉ từ ngày";
            table.Columns[8].ColumnName = "Nghỉ đến ngày";
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i][0].ToString() == idEmp)
                {
                    DataRow newRow = table.NewRow();
                    newRow.ItemArray = table.Rows[i].ItemArray; // Copy the entire row
                    table.Rows.Add(newRow);
                }
            }
            dataGridViewLeave.DataSource = table;
            dataGridViewLeave.Columns[5].Visible = false;
            dataGridViewLeave.Columns[6].Visible = false;
        }

        private void loadOT()
        {
            int year = ((DateTime)dateTimePicker1.Value).Year;
            int month = ((DateTime)dateTimePicker1.Value).Month;
            ManageForm mana = new ManageForm();
            string command = " SELECT * FROM TangCa WHERE maNV = '" + idEmp + "'" +
                                " AND MONTH(ngay) = " + month + " AND YEAR(ngay) = " + year; ;
            WorkWithDatabase work = new WorkWithDatabase();
            DataTable result = work.loadDataFromDB(command);
            result.Columns[0].ColumnName = "Mã tăng ca";
            result.Columns[1].ColumnName = "Mã nhân viên";
            result.Columns[2].ColumnName = "Số giờ tăng ca";
            result.Columns[4].ColumnName = "Loại tăng ca";
            result.Columns[3].ColumnName = "ngày";
            tableOT.DataSource = result;
        }

        private void ChiTietQuanLyForm_Resize(object sender, EventArgs e)
        {
            tabControl1.Dock = DockStyle.Fill;

            
        }

        private void ChiTietQuanLyForm_SizeChanged(object sender, EventArgs e)
        {
            // Calculate the new size for the DataGridView based on the form size
            int newWidth = this.ClientSize.Width;
            int newHeight = this.ClientSize.Height;

            // Set the new size for the DataGridView
            tableSal.Size = new Size(newWidth - 15, newHeight - 15);
            dataGridViewLeave.Size = new Size(newWidth, newHeight - 15);
            tableOT.Size = new Size(newWidth, newHeight - 15);
            tableSal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLeave.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableOT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dateTimePicker14_ValueChanged(object sender, EventArgs e)
        {
            loadSal();
        }

        private void dateTimePicker15_ValueChanged(object sender, EventArgs e)
        {
            loadOnLeave();
        }

        private void dateTimePicker16_ValueChanged(object sender, EventArgs e)
        {
            loadOT();
        }
    }
}
