using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_Trang77
{
    internal class SanPham
    {
        private string tenSP, maSP;
        private double giaBan;
        private int soLuongTon;

        public Sanpham(string tenSP, string maSP, double giaBan, int soLuongTon)
        {
            this.tenSP = tenSP;
            this.maSP = maSP;
            this.giaBan = giaBan;
            this.soLuongTon = soLuongTon;
        }


        public Sanpham()
        {
            this.tenSP = "";
            this.maSP = "";
            this.giaBan = 0;
            this.soLuongTon = 0;
        }


        public Sanpham(Sanpham sp)
        {
            this.tenSP = sp.tenSP;
            this.maSP = sp.maSP;
            this.giaBan = sp.giaBan;
            this.soLuongTon = sp.soLuongTon;
        }

        public bool hetHang()
        {
            if (soLuongTon == 0)
            {
                return true;
            }
            return false;
        }

        public void Nhap()
        {
            Console.Write("Nhap ten san pham: ");
            tenSP = Console.ReadLine();
            Console.Write("Nhap ma san pham: ");
            maSP = Console.ReadLine();
            Console.Write("Nhap gia ban: ");
            giaBan = double.Parse(Console.ReadLine());
            Console.Write("Nhap so luong ton kho: ");
            soLuongTon = int.Parse(Console.ReadLine());

        }

        public void hienThi()
        {
            Console.WriteLine($"ten san pham: {tenSP}");
            Console.WriteLine($"ma san pham: {maSP}");
            Console.WriteLine($"gia ban: {giaBan}");
            Console.WriteLine($"so luong ton kho: {soLuongTon}");
        }

        public string tensp
        {
            get { return this.tenSP; }
        }
    }
}
