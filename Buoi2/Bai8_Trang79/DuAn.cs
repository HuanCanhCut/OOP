using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_Trang79
{
    internal class DuAn
    {
        private string tenDA, maDA;
        private DateTime ngayBD, ngayKT;
        private double tongKinhPhi;
        private List<string> DanhSachNV;

        public DuAn()
        {
            this.tenDA = "";
            this.maDA = "";
            this.ngayBD = DateTime.Now;
            this.ngayKT = DateTime.Now;
            this.tongKinhPhi = 0;
            this.DanhSachNV = new List<string>();
        }

        public DuAn(string tenDA, string maDA, DateTime ngayBD, DateTime ngayKT, List<string> DanhSachNV, double tongKinhPhi)
        {
            this.tenDA = tenDA;
            this.maDA = maDA;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
            this.tongKinhPhi = tongKinhPhi;
            this.DanhSachNV = DanhSachNV;
        }

        public DuAn(DuAn DA)
        {
            this.tenDA = DA.tenDA;
            this.maDA = DA.maDA;
            this.ngayBD = DA.ngayBD;
            this.ngayKT = DA.ngayKT;
            this.DanhSachNV = DA.DanhSachNV;
            this.tongKinhPhi = DA.tongKinhPhi;
        }

        private void AddNhanVien (string title)
        {
            while (true)
            {
                Console.Write(title);
                string nhanVien = Console.ReadLine();
                if (nhanVien == "")
                {
                    break;
                }
                DanhSachNV.Add(nhanVien);
            }
        }

        public void Nhap()
        {
            Console.Write("Nhập tên dự án: ");
            tenDA = Console.ReadLine();

            Console.Write("Nhập mã dự án: ");
            maDA = Console.ReadLine();

            Console.Write("Nhập ngày bắt đầu dự án: ");
            ngayBD = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Nhập ngày kết thúc dự án: ");
            ngayKT = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Tổng kinh phí: ");
            tongKinhPhi = Convert.ToDouble(Console.ReadLine());


            this.AddNhanVien("Nhập danh sách nhân viên: ");

        }

        public void themNhanVien()
        {
            Console.WriteLine("Thêm nhân viên");

            this.AddNhanVien("Nhập tên nhân viên: ");

        }

        public void ThoiGianThucHien()
        {
            Console.WriteLine(ngayBD - ngayKT);
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"{"Tên đề án", -20} {"Mã đề án", -10} {"Ngày BD", -25} {"Ngày KT", -25} {"Tổng kinh phí", -15}");
            Console.WriteLine($"{tenDA, -20} {maDA, -10} {ngayBD, -25} {ngayKT, -25} {tongKinhPhi, -20}");
        }
    }
}
