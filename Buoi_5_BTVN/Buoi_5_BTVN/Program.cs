using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_BTVN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSachMonHoc ds = new DanhSachMonHoc();
            DanhSachHoaDon dshd = new DanhSachHoaDon();
            while (true)
            {
                Console.WriteLine("1. Nhap - Xuat XML mon hoc");
                Console.WriteLine("2. Nhap - Xuat XML hoa don");
                Console.WriteLine("3. Hoa don - Xuat danh sach khach vang lai");
                Console.WriteLine("4. Hoa don - Tong tri gia cac hoa don");
                Console.WriteLine("5. Hoa don - Hoa don co tri gia cao nhat");
                Console.WriteLine("6. Hoa don - Dem so hoa don VIP & Than thiet");
                Console.WriteLine("7. Hoa don - Sap xep tang dan theo tri gia va giam dan theo ma so");
                Console.WriteLine("0. Thoat");
                Console.Write("Chon chuc nang: ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    ds.Nhap_XML(@"..\..\DSMH.xml");
                    ds.Xuat();
                }
                else if (choice == "2")
                {
                    dshd.Nhap_XML(@"..\..\DSHD.xml");
                    dshd.Xuat();
                }
                else if (choice == "3")
                {
                    List<HoaDonKhachVangLai> KQ = dshd.HoaDonKhachVangLai();
                    foreach (HoaDonKhachVangLai hd in KQ)
                    {
                        hd.Xuat();
                        Console.WriteLine();
                    }
                }
                else if (choice == "4")
                    Console.WriteLine("Tong tri gia cac hoa don = {0,-20}", dshd.TongTriGia());
                else if (choice == "5")
                {
                    List<HoaDon> KQ = dshd.MaxTriGia();
                    foreach (HoaDon hd in KQ)
                    {
                        hd.Xuat();
                        Console.WriteLine();
                    }
                }
                else if (choice == "6")
                    Console.WriteLine("Tong so hoa don VIP & Than thiet = {0,-3}", dshd.Dem_HD_VIP_TT());
                else if (choice == "7")
                {
                    List<HoaDon> KQ = dshd.sapXep_TDTriGia_GDMaSo();
                    foreach (HoaDon hd in KQ)
                    {
                        hd.Xuat();
                        Console.WriteLine();
                    }
                }
                else if (choice == "0")
                    break;
                else
                {
                    Console.WriteLine("Lua chon khong hop le. Nhan phim bat ky de tiep tuc...");
                    Console.ReadKey();
                }
            }

            Console.ReadKey();
        }
    }
}
