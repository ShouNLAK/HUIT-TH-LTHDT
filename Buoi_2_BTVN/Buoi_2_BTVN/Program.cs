using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_2_BTVN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DSNhanVien ds = new DSNhanVien();
            HoaDon hd = new HoaDon();
            Console.WriteLine("1. Bai 5");
            Console.WriteLine("2. Bai 6");
            Console.Write("Chon bai: ");
            int choose = 1;
            int bai = int.Parse(Console.ReadLine());
            while (bai == 1 && (choose >= 1 && choose <= 9))
            {
                Console.WriteLine("1. Nhap danh sach nhan vien");
                Console.WriteLine("2. Xuat danh sach nhan vien");
                Console.WriteLine("3. Sap xep danh sach nhan vien theo he so thi dua giam dan");
                Console.WriteLine("4. Loc danh sach nhan vien theo phong ban");
                Console.WriteLine("5. Loc danh sach nhan vien la lanh dao");
                Console.WriteLine("6. Tinh tong luong cua toan bo nhan vien");
                Console.WriteLine("7. Xoa NV co so ngay lam viec nho hon 10");
                Console.WriteLine("8. Xuat NV Khong phai la Lanh dao, va co 22 ngay lam viec tro len");
                Console.WriteLine("9. Xuat NV co he so luong tren 4.34 va o phong tai vu");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("Nhap chuong trinh can chay");
                choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                    ds.nhap();
                else if (choose == 2)
                    ds.xuat();
                else if (choose == 3)
                {
                    DSNhanVien kq = ds.sort_Theo_HSTD();
                    kq.xuat();
                }
                else if (choose == 4)
                {
                    Console.Write("Nhap phong ban can loc: ");
                    string phongBan = Console.ReadLine();
                    DSNhanVien kq = ds.loc_PhongBan_DieuKien(phongBan);
                    kq.xuat();
                }
                else if (choose == 5)
                {
                    DSNhanVien kq = ds.loc_LanhDao();
                    kq.xuat();
                }
                else if (choose == 6)
                {
                    double tongLuong = ds.sumList();
                    Console.WriteLine("Tong luong cua toan bo nhan vien: {0}", tongLuong);
                }
                else if (choose == 7)
                {
                    DSNhanVien kq = ds.delete_NV_NgayLamViecNhoHon(10);
                    kq.xuat();
                }
                else if (choose == 8)
                {
                    DSNhanVien kq = ds.loc_NV_CongHienHonSoNgay(22);
                    kq.xuat();
                }
                else if (choose == 9)
                {
                    DSNhanVien kq = ds.loc_theoHSL_PhongBan(4.34,"Tai vu");
                    kq.xuat();
                }
                else if (choose == 0)
                    return;
            }
            while (bai == 2)
            {
                Console.WriteLine("1. Nhap danh sach hoa don");
                Console.WriteLine("2. Xuat danh sach hoa don");
                Console.WriteLine("3. Sap xep hoa don theo thanh tien giam dan - neu cung thi tang dan gia ban");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("Nhap chuong trinh can chay");
                choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                    hd.nhap();
                else if (choose == 2)
                    hd.xuat();
                else if (choose == 3)
                {
                    Console.WriteLine("\n--- Hoa don truoc khi sap xep ---");
                    hd.xuat();
                    hd.sapXep();
                    Console.WriteLine("\n--- Hoa don sau khi sap xep ---");
                    hd.xuat();
                }
                else if (choose == 0)
                    return;
            }
            Console.ReadKey();
        }
    }
}
