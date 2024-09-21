using System;

namespace QuanLyMatHang
{
    public class MatHang
    {
        private string maHH; // Mã mặt hàng
        private string tenHH; // Tên mặt hàng
        private float donGia; // Đơn giá của mặt hàng
        private int soLuong; // Số lượng

        // Phương thức khởi tạo không tham số
        public MatHang()
        {
            this.maHH = "";
            this.tenHH = "";
            this.donGia = 0;
            this.soLuong = 0;
        }

        // Phương thức khởi tạo 4 tham số
        public MatHang(string maHH, string tenHH, float donGia, int soLuong)
        {
            this.maHH = maHH;
            this.tenHH = tenHH;
            this.donGia = donGia;
            this.soLuong = soLuong;
        }

        // Phương thức nhap
        public void Nhap()
        {
            Console.Write("Nhập mã hàng hóa: ");
            this.maHH = Console.ReadLine();
            Console.Write("Nhập tên hàng hóa: ");
            this.tenHH = Console.ReadLine();
            Console.Write("Nhập đơn giá: ");
            this.donGia = float.Parse(Console.ReadLine());
            Console.Write("Nhập số lượng: ");
            this.soLuong = int.Parse(Console.ReadLine());
        }

        // Phương thức TinhTien
        public float TinhTien()
        {
            return this.donGia * this.soLuong;
        }

        // Phương thức HienThi
        public void HienThi()
        {
            Console.WriteLine($"{this.maHH,-10} {this.tenHH,-20} {this.donGia,-15} {this.soLuong,10} {" ",15}");
        }
    }
}