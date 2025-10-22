using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_3_BTVN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DSNhanVien dsNV = new DSNhanVien();
            KhuTro kt = new KhuTro();
            Console.WriteLine("1. Bai 5");
            Console.WriteLine("2. Bai 6");
            Console.Write("Chon bai: ");
            int bai = int.Parse(Console.ReadLine());
            int chon;
            if (bai == 1)
            {
                do
                {
                    Console.WriteLine("1. Doc file XML");
                    Console.WriteLine("2. Xuat danh sach");
                    Console.WriteLine("3. Tinh tong luong NV");
                    Console.WriteLine("4. Loc - Xuat DS Lanh dao");
                    Console.WriteLine("5. Loc - Xuat DS NV X");
                    Console.WriteLine("6. Xoa NV co so ngay nho hon 10");
                    Console.WriteLine("7. Loc NV khong phai la lanh dao va lam viec hon 22 ngay");
                    Console.WriteLine("8. Sap xep danh sach giam dan theo luong");
                    Console.WriteLine("9. Sap xep danh sach giam dan theo luong va tang dan theo ten");
                    Console.WriteLine("0. Thoat chuong trinh");
                    Console.Write("Hay chon chuong trinh thuc thi : ");
                    chon = int.Parse(Console.ReadLine());
                    if (chon == 1)
                    {
                        dsNV.nhap(@"..\..\DSNV.xml");
                        Console.WriteLine("Doc file XML thanh cong!");
                    }
                    else if (chon == 2)
                        dsNV.xuat();
                    else if (chon == 3)
                        Console.WriteLine("Tong luong nhan vien : {0}", dsNV.sumList());
                    else if (chon == 4)
                        dsNV.loc_LanhDao().xuat();
                    else if (chon == 5)
                    {
                        Console.WriteLine("Nhap phong ban can loc: ");
                        dsNV.loc_PhongBan_DieuKien(Console.ReadLine()).xuat();
                    }
                    else if (chon == 6)
                        dsNV.delete_NV_NgayLamViecNhoHon(10).xuat();
                    else if (chon == 7)
                        dsNV.loc_NV_CongHienHonSoNgay(22).xuat();
                    else if (chon == 8)
                        dsNV.sapXep_GiamDan_Luong().xuat();
                    else if (chon == 9)
                        dsNV.sapXep_GDTheoLuong_TDTheoTen().xuat();
                    else
                        Console.WriteLine("Khong co chuong trinh nay!");
                } while (chon != 0);
            }
            else if (bai == 2)
            {
                do
                {
                    Console.WriteLine("1. Doc file XML");
                    Console.WriteLine("2. Xuat danh sach");
                    Console.WriteLine("3. Tinh tong tien thue phong");
                    Console.WriteLine("4. Sap xep DS tang dan theo so luong khach, giam dan theo tien phong");
                    Console.WriteLine("5. Phong su dung dien nhieu nhat");
                    Console.WriteLine("0. Thoat chuong trinh");
                    Console.Write("Hay chon chuong trinh thuc thi : ");
                    chon = int.Parse(Console.ReadLine());
                    if (chon == 1)
                    {
                        kt.nhap(@"..\..\DSPhongTro.xml");
                        Console.WriteLine("Doc file XML thanh cong!");
                    }
                    else if (chon == 2)
                        kt.xuat();
                    else if (chon == 3)
                        Console.WriteLine("Tong tien thue phong: {0}", kt.tinhTongTien());
                    else if (chon == 4)
                        kt.sapXep_GDTheoSoLuongKhach_GDTheoTienPhong().xuat();
                    else if (chon == 5)
                        kt.max_SoDien().xuat();
                    else
                        Console.WriteLine("Khong co chuong trinh nay!");
                } while (chon != 0);
            }
            else
            {
                Console.WriteLine("Khong co bai nay!");
            }
        }
    }
}
