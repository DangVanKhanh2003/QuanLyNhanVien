using QuanLyNhanVienTTCSN_Nhom9.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace QuanLyNhanVienTTCSN_Nhom9.View
{
    public partial class XoaNghiPhepForm : Form
    {
        private string typeAcc = "";
        private string idEmp = "";
        private DataTable table;
        private int year = 0;
        private int month = 0;
        public XoaNghiPhepForm(string typeAcc, string idEmp, DataTable table, int year, int month)
        {
            InitializeComponent();
            this.typeAcc = typeAcc;
            this.idEmp = idEmp;
            this.table = table;
            this.year = year;
            this.month = month;
        }

        private void XoaNghiPhepForm_Load(object sender, EventArgs e)
        {
            DateTime date = new DateTime(year, month, 1);
            dateTimePicker1.Value = date;
            if(table != null)
            {
                dataGridView1.DataSource = table;

            }
            int newWidth = this.ClientSize.Width;
            int newHeight = this.ClientSize.Height;

            dataGridView1.Size = new System.Drawing.Size(this.ClientSize.Width, this.ClientSize.Height);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ManageForm mana = new ManageForm();
            DateTime  date = dateTimePicker1.Value;
            year = date.Year;
            month = date.Month;
            table = mana.getOnLeaveByIdEmp(idEmp, year, month);
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
            dataGridView1.DataSource = table;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void XoaNghiPhepForm_SizeChanged(object sender, EventArgs e)
        {
            int newWidth = this.ClientSize.Width;
            int newHeight = this.ClientSize.Height;

            dataGridView1.Size = new System.Drawing.Size(this.ClientSize.Width, this.ClientSize.Height);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ManageForm mana = new ManageForm();
            DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
            if(selectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa các dòng đã chọn không?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Iterate through the selected rows and retrieve data
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        string idOnLeave = row.Cells[0].Value.ToString();
                        //delete
                        mana.removeOnLeave(idOnLeave);
                    }
                    DateTime date = dateTimePicker1.Value;
                    year = date.Year;
                    month = date.Month;
                    table = mana.getOnLeaveByIdEmp(idEmp, year, month);
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
                    dataGridView1.DataSource = table;
                }

            }
        }
    }
}
