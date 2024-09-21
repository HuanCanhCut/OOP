using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_Trang76
{
    internal class LibraryManager
    {
        private Book[] books;
        private int soSach;

        public void ThemSach ()
        {
            Console.Write("Nhập số lượng sách: ");
            soSach = int.Parse(Console.ReadLine());

            books = new Book[soSach];

            for (int i = 0; i < books.Length; i++)
            {
                books[i] = new Book();
                books[i].Nhap();
            }
        }

        public void HienThiThongTin()
        {
            for(int i = 0; i < books.Length; i++)
            {
                books[i].Hien();
            }
        }

        public void KiemTraSoLuong()
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Sách {books[i].TenSach} co số lần {books[i].SoLuong}");
            }
        }
    }
}
