using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_Trang77
{
    internal class QLNV
    {
        private NhanVien[] nv;
        private int soLuongnv;

        public void themNV()
        {
            Console.Write("Nhap so luong nhan vien: ");
            soLuongnv = int.Parse(Console.ReadLine());
            nv = new NhanVien[soLuongnv];
            for (int i = 0; i < nv.Length; i++)
            {
                nv[i] = new NhanVien();
                nv[i].Nhap();
            }
        }

        public void tinhLuong()
        {
            for (int i = 0; i < nv.Length; i++)
            {
                double luong = nv[i].luongcb * nv[i].songaycong;
                Console.WriteLine($"Luong cua nhan vien {nv[i].name} la: {luong}");
            }
        }

        public void hienThiThongTin()
        {
            for (int i = 0; i < nv.Length; i++)
            {
                nv[i].Hien();
            }
        }
    }
}
