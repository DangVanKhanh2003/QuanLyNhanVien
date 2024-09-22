using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QuanLyNhanVienTTCSN_Nhom9.Control
{
    internal class WorkWithDatabase
    {
        private string strCon = @"Server=DESKTOP-19ENTAL\SQLEXPRESS;Database=QuanLyNhanVien;Integrated Security=SSPI;";

        private SqlConnection sqlCon = null;

        public void connectToDatabase()
        {
            try
            {
                if(this.sqlCon == null) 
                {
                    this.sqlCon = new SqlConnection(strCon);
                }
                if(this.sqlCon.State == System.Data.ConnectionState.Closed)
                {
                    this.sqlCon.Open();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        public DataTable loadDataFromDB(string strCommand)
        {
            connectToDatabase();
            try
            {
                SqlCommand command = this.sqlCon.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                command.CommandText = strCommand;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                sqlCon.Close();
                return table;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public void modifierDB(string strCommand) 
        {
            connectToDatabase();
            try
            {
                SqlCommand command = sqlCon.CreateCommand();
                command.CommandText = strCommand;
                command.ExecuteNonQuery();
                sqlCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
