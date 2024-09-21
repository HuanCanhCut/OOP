using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_Trang77
{
    internal class NhanVien
    {
        private string hoTen, maNV;
        private double luongCoBan;
        private int soNgayCong;


        public NhanVien()
        {
            this.hoTen = "";
            this.maNV = "";
            this.luongCoBan = 0;
            this.soNgayCong = 0;

        }


        public NhanVien(string hoTen, string maNV, double luongCoBan, int soNgayCong)
        {
            this.hoTen = hoTen;
            this.maNV = maNV;
            this.luongCoBan = luongCoBan;
            this.soNgayCong = soNgayCong;
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten nhan vien: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap ma nhan vien: ");
            maNV = Console.ReadLine();
            Console.Write("Nhap luong co ban: ");
            luongCoBan = double.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay cong: ");
            soNgayCong = int.Parse(Console.ReadLine());
        }

        public void Hien()
        {
            Console.WriteLine($"Ho ten NV: {hoTen}");
            Console.WriteLine($"Ma NV: {maNV}");
            Console.WriteLine($"Luong co ban: {luongCoBan}");
            Console.WriteLine($"So ngay cong: {soNgayCong}");

        }

        public double luongcb { get { return this.luongCoBan; } }
        public int songaycong { get { return this.soNgayCong; } }
        public string name { get { return this.hoTen; } }
    }
}
