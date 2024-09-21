using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_Trang76
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            QLSV QL = new QLSV();

            QL.Nhap();
            QL.HienThiThongTin();
            QL.TinhDiemTB();

            Console.ReadKey();
        }
    }
}
