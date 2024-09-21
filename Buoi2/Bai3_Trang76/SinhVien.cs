using System;
using System.Collections.Generic;

namespace QuanLyDuAn
{
    internal class DuAn
    {
        private string tenDA;
        private string maDA;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;
        private decimal tongKinhPhi;
        private List<NhanVien> danhSachNhanVien;

        public DuAn()
        {
            this.tenDA = "";
            this.maDA = "";
            this.ngayBatDau = DateTime.Now;
            this.ngayKetThuc = DateTime.Now;
            this.tongKinhPhi = 0;
            this.danhSachNhanVien = new List<NhanVien>();
        }

        public DuAn(string tenDA, string maDA, DateTime ngayBatDau, DateTime ngayKetThuc, decimal tongKinhPhi)
        {
            this.tenDA = tenDA;
            this.maDA = maDA;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.tongKinhPhi = tongKinhPhi;
            this.danhSachNhanVien = new List<NhanVien>();
        }

        public DuAn(DuAn duAn)
        {
            this.tenDA = duAn.tenDA;
            this.maDA = duAn.maDA;
            this.ngayBatDau = duAn.ngayBatDau;
            this.ngayKetThuc = duAn.ngayKetThuc;
            this.tongKinhPhi = duAn.tongKinhPhi;
            this.danhSachNhanVien = new List<NhanVien>(duAn.danhSachNhanVien);
        }

        public void ThemNhanVien(NhanVien nhanVien)
        {
            danhSachNhanVien.Add(nhanVien);
        }

        public TimeSpan TinhThoiGianThucHien()
        {
            return ngayKetThuc - ngayBatDau;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"{"Tên dự án",-20} {"Mã dự án",-15} {"Ngày bắt đầu",-15} {"Ngày kết thúc",-15} {"Tổng kinh phí",-20}");
            Console.WriteLine($"{tenDA,-20} {maDA,-15} {ngayBatDau.ToShortDateString(),-15} {ngayKetThuc.ToShortDateString(),-15} {tongKinhPhi,-20:C}");
            Console.WriteLine("Danh sách nhân viên tham gia:");
            foreach (var nhanVien in danhSachNhanVien)
            {
                Console.WriteLine($"- {nhanVien.HoTen}");
            }
        }
    }
}