using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7_Trang79
{
    internal class HocPhan
    {
        private string tenHP;
        private string maHP;
        private double soTinChi;
        private double diemThi;

        public HocPhan()
        {
            this.tenHP = "";
            this.maHP = "";
            this.soTinChi = 0;
            this.diemThi = 0;
        }

        public HocPhan(string tenHP, string maHP, double soTinChi, double diemThi)
        {
            this.tenHP = tenHP;
            this.maHP = maHP;
            this.soTinChi = soTinChi;
            this.diemThi = diemThi;
        }

        public void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            tenHP = Console.ReadLine();

            Console.Write("Nhập mã sinh viên: ");
            maHP = Console.ReadLine();

            Console.Write("Nhập điểm Toán: ");
            soTinChi = double.Parse(Console.ReadLine());

            Console.Write("Nhập điểm Văn: ");
            diemThi = double.Parse(Console.ReadLine());
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"{"Tên",-20} {"Mã sinh viên",-15} {"Điểm toán",-15} {"Điểm văn",-15}");
            Console.WriteLine($"{tenHP,-20} {maHP,-15} {soTinChi,-15} {diemThi,-15}");
        }

        public void TinhDiemTB()
        {
            double diemTb = (soTinChi + diemThi) / 2;
            Console.WriteLine($"Sinh viên {tenHP} có điểm trung bình là: {diemTb}");
        }

    }
}
