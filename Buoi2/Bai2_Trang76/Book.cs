using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_Trang76
{
    internal class Book
    {
        private string tenSach;
        private string maSach;
        private string tacGia;
        private int soLuong;

        public Book ()
        {
            this.tenSach = "";
            this.maSach = "";
            this.tacGia = "";
            this.soLuong = 0;
        }

        // Khởi tạo constructor với 4 tham số
        public Book(string tenSach, string maSach, string tacGia, int soLuong)
        {
            this.tenSach = tenSach;
            this.maSach = maSach;
            this.tacGia = tacGia;
            this.soLuong = soLuong;
        }

        public void Nhap()
        {
            Console.Write("Tên sách: ");
            tenSach = Console.ReadLine();

            Console.Write("Mã sách: ");
            maSach = Console.ReadLine();

            Console.Write("Tác giả: ");
            tacGia = Console.ReadLine();

            Console.Write("Số lượng: ");
            soLuong = int.Parse(Console.ReadLine());
        }

        public void Hien ()
        {
            Console.WriteLine($"{"Tên", -20} {"Mã sách", -15} {"Tác giả", -15} {"Số lượng", -15}");
            Console.WriteLine($"{tenSach, -20} {maSach, -15} {tacGia, -15} {soLuong, -15}");
        }

        public string TenSach
        {
            get
            {
                return this.tenSach;
            }
        }

        public int SoLuong
        {
            get
            {
                return this.soLuong;
            }
        }
    }
}
