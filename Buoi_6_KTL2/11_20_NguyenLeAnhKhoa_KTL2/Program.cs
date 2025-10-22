using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_20_NguyenLeAnhKhoa_KTL2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chon = 0;
            NguyenLeAnhKhoa_QuanLyHocSinh ds = new NguyenLeAnhKhoa_QuanLyHocSinh();
            do
            {
                Console.WriteLine("\n\n1. Nhap danh sach tu file XML");
                Console.WriteLine("2. Xuat danh sach");
                Console.WriteLine("3. Xuat tong tien ma truong thu duoc");
                Console.WriteLine("4. Sap xep cac phieu thu theo khoi lop (Giam dan theo tong tien neu cung khoi lop"); Console.WriteLine("3. Xuat tong tien truong thu duoc");
                Console.WriteLine("5. Xuat tong tien tu chi phi co so vat chat ma truong thu duoc");
                Console.WriteLine("6. Xuat tong tien thu duoc tu hoc sinh (Tieng anh tang cuong)");
                Console.WriteLine("7. Tim va xuat thong tin cua hoc sinh co ma X");
                Console.WriteLine("-------------------");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.WriteLine("-------------------");
                Console.Write("Nhap chuong trinh can thuc thi : ");
                chon = int.Parse(Console.ReadLine());
                if (chon == 0)
                    Console.WriteLine(">> Da thoat chuong trinh");
                else if (chon == 1)
                {
                    ds.Nhap_DS_XML(@"..\..\NguyenLeAnhKhoa_TruongTHCS.xml");
                    Console.WriteLine(">> Da nhap danh sach tu file XML");
                }
                else if (chon == 2)
                    ds.Xuat();
                else if (chon == 3)
                    Console.WriteLine(">> Tong tien ma truong thu duoc : {0}", ds.TinhTong_Tien());
                else if (chon == 4)
                {
                    Console.WriteLine("{0,-10} | {1,-20} | {2,-5} | {3,-10} | {4,-15} | {5,-15} | {6,-15} | {7}",
                "Ma HS", "Ten HS", "Khoi", "So buoi nghi", "Hoc phi", "chi phi khac", "Tong tien", "Thong tin them");
                    List<NguyenLeAnhKhoa_HocSinh> KQ = ds.sapXep_TDKhoiLop_GDTongTien();
                    foreach (NguyenLeAnhKhoa_HocSinh hs in KQ)
                    {
                        hs.Xuat();
                        Console.WriteLine();
                    }
                }
                else if (chon == 5)
                    Console.WriteLine(">> Tong tien tu chi phi Co so vat chat ma truong thu duoc : {0}", ds.TinhTong_TienCSVC());
                else if (chon == 6)
                    Console.WriteLine(">> Tong tien ma truong thu duoc tu hoc sinh Tieng anh Tang cuong : {0}", ds.TinhTong_Tien_HSTiengAnhTangCuong());
                else if (chon == 7)
                {
                    Console.Write("Hay nhap ma hoc sinh ban can tim : ");
                    string ma = Console.ReadLine();
                    if (ds.Tim_HS_TheoMa(ma) != null)
                    {
                        Console.WriteLine("{0,-10} | {1,-20} | {2,-5} | {3,-10} | {4,-15} | {5,-15} | {6,-15} | {7}",
                            "Ma HS", "Ten HS", "Khoi", "So buoi nghi", "Hoc phi", "chi phi khac", "Tong tien", "Thong tin them");
                        ds.Tim_HS_TheoMa(ma).Xuat();
                    }
                    else
                        Console.WriteLine("Hoc sinh ma {0} khong ton tai", ma);
                }
                else
                    Console.WriteLine("Nhap sai chuong trinh - Vui long nhap lai");

            } while (chon != 0);
            Console.ReadKey();
        }
    }
}
