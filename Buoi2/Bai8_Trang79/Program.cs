using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8_Trang79
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            DuAn DA = new DuAn();

            DA.Nhap();
            DA.themNhanVien();
            DA.HienThiThongTin();

            Console.ReadKey();
        }
    }
}
