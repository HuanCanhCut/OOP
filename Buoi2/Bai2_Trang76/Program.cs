using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_Trang76
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            LibraryManager QL = new LibraryManager();

            QL.ThemSach();

            QL.HienThiThongTin();

            QL.KiemTraSoLuong();

            Console.ReadKey();
        }
    }
}
