using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*
 * Họ và Tên : Nguyễn Lê Anh Khoa
 * MSSV : 2001240206 - Số máy : 20
 */

namespace Buoi_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chọn chương trình bạn muốn chạy : ");
            Console.WriteLine("1. Quản lý nhân viên \t2. Quản lý Sản phẩm điện tử\t3. Quản lý lớp khóa học");
            Console.OutputEncoding = Encoding.UTF8;
            int Choose = Int32.Parse(Console.ReadLine());
            if (Choose == 1)
            {
                NhanVien nhanVien1 = new NhanVien();
                NhanVien nhanVien2 = new NhanVien();
                NhanVien nhanVien3 = new NhanVien("NV002", "Tran Hoang Anh", 25);

                //nhanVien2.NhapTTNV();

                nhanVien1.XuatTTNV();
                //nhanVien2.XuatTTNV();
                nhanVien3.XuatTTNV();
            }
            else if (Choose == 2)
            {
                SanPhamDienTu SP1 = new SanPhamDienTu("Samsung", "S2018", "S10 FE", 10000000, "Phone");
                SanPhamDienTu SP2 = new SanPhamDienTu("Xiaomi", "RPP", "Redmi Pad Pro", 7050000, "Laptop");
                SanPhamDienTu SP3 = new SanPhamDienTu("Lenovo", "S2024", "LOQ 2024", 32000000, "Laptop");

                SanPhamDienTu SP4 = new SanPhamDienTu();
                //SP4.nhap();

                SanPhamDienTu SP5 = new SanPhamDienTu(SP3);
                SP5.SoSeries = "S2025";

                SP1.xuat();
                SP2.xuat();
                SP3.xuat();
                //SP4.xuat();
                //SP5.xuat();
            }
            else if (Choose == 3)
            {
                KhoaHoc KH1 = new KhoaHoc();
                //KH1.nhap();
                KH1.xuat();
            }
            else
            {
                Console.WriteLine("Nhập sai - Hãy chạy lại chương trình");
            }

            //---
            Console.ReadLine();
        }
    }
}
