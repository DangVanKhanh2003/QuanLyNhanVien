using QuanLyNhanVienTTCSN_Nhom9.Control;
using QuanLyNhanVienTTCSN_Nhom9.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;


namespace QuanLyNhanVienTTCSN_Nhom9
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ChiTietQuanLyForm("NV01"));
            Application.Run(new DangNhapForm());
            //Application.Run(new NhanVienForm("TK10","NV10"));
            //Application.Run(new AdminForm("AD01"));
            //ManageForm mana = new ManageForm();
           //MessageBox.Show(mana.countOnLeave(1, 2023,12, "NV03").ToString());
        }
    }
}
