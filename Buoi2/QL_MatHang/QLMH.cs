using QuanLyMatHang;
using System;

namespace Bai3_Trang76
{
    internal class QLMH
    {
        private MatHang[] danhSachMH;
        private int soLuongMH;

        public void Nhap()
        {
            Console.Write("Nhập số lượng mặt hàng: ");
            soLuongMH = int.Parse(Console.ReadLine());
            danhSachMH = new MatHang[soLuongMH];

            for (int i = 0; i < danhSachMH.Length; i++)
            {
                Console.WriteLine($"\nNhập thông tin mặt hàng thứ {i + 1}:");
                danhSachMH[i] = new MatHang();
                danhSachMH[i].Nhap();
            }
        }

        public void HienThiThongTin()
        {
            Console.WriteLine("\nDanh sách mặt hàng:");
            Console.WriteLine($"{"STT",-5} {"Mã hàng",-10} {"Tên hàng",-20} {"Đơn giá",-15} {"Số lượng",-10} {"Thành tiền",-15}");
            Console.WriteLine(new string('-', 80)); // Tạo đường kẻ ngang

            for (int i = 0; i < danhSachMH.Length; i++)
            {
                Console.Write($"{i + 1,-5} ");
                danhSachMH[i].HienThi();
            }
        }

        public void TinhTongTien()
        {
            float tongTien = 0;
            for (int i = 0; i < danhSachMH.Length; i++)
            {
                tongTien += danhSachMH[i].TinhTien();
            }
            Console.WriteLine($"\nTổng tiền tất cả mặt hàng: {tongTien:F2}");
        }
    }
}