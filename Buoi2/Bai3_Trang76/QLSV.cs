    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Bai3_Trang76
    {
        internal class QLSV
        {
            private SinhVien[] danhSachSV;
            private int soLuongSV;

            public void Nhap()
            {
                Console.Write("Nhập số lượng sinh viên: ");
                soLuongSV = int.Parse(Console.ReadLine());
                danhSachSV = new SinhVien[soLuongSV];

                for (int i = 0; i < danhSachSV.Length; i++)
                {
                    danhSachSV[i] = new SinhVien();
                    danhSachSV[i].Nhap();
                }
            }

            public void HienThiThongTin()
            {
                for (int i = 0; i < danhSachSV.Length; i++)
                {
                    danhSachSV[i].HienThiThongTin();
                }
            }

            public void TinhDiemTB ()
            {
                for (int i = 0; i < danhSachSV.Length; i++)
                {
                    danhSachSV[i].TinhDiemTB();
                }
            }
        }
    }
