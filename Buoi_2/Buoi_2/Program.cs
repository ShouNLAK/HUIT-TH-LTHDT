using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Buoi_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Danh sach phan so");
            Console.WriteLine("2. Dnah sach nhan vien");
            Console.WriteLine("------------------------");
            Console.Write("Chon chuong trinh thuc thi : ");
            int Choose = int.Parse(Console.ReadLine());
            if (Choose == 1)
            {
                PhanSo PS = new PhanSo(6, 3);
                PhanSo PS2 = new PhanSo(9, 4);
                Console.WriteLine("{0}/{1} + {2}/{3} = {4}/{5}", PS.TuSo, PS.MauSo, PS2.TuSo, PS2.MauSo, PS.tinhTong2PS(PS2).TuSo, PS.tinhTong2PS(PS2).MauSo);
                Console.WriteLine("{0}/{1} + {2} = {3}/{4}", PS.TuSo, PS.MauSo, 1, PS.tinhTong2PS(1).TuSo, PS.tinhTong2PS(1).MauSo);

                DanhSachPS ListPS = new DanhSachPS();
                ListPS.nhap();
                ListPS.xuat();
                PhanSo x = new PhanSo();

                Console.WriteLine("Nhap x can tim : ");
                x.nhap();
                Console.WriteLine("Ket qua tim {0}/{1} : {2}", x.TuSo, x.MauSo, ListPS.timPS(x));

                DanhSachPS kq = new DanhSachPS();
                Console.WriteLine("Xep danh sach theo gia tri tang dan : ");
                kq = ListPS.sortGiaTri();
                kq.xuat();

                Console.WriteLine("Danh sach co gia tri lon hon mot : ");
                kq = ListPS.locGiaTriLonHon1();
                kq.xuat();

                Console.WriteLine("Top 3 gia tri lon nhat : ");
                kq = ListPS.Top3DS();
                kq.xuat();
            }
            else if (Choose == 2)
            {
                DanhSachNV ListNV = new DanhSachNV();
                ListNV.nhap();
                ListNV.xuat();
                Console.WriteLine("Tong luong nhan vien : {0}", ListNV.SumList());
                DanhSachNV KQ = new DanhSachNV();
                NhanVien kq = new NhanVien();
                kq = ListNV.MaxList();
                Console.WriteLine("Nhan vien co luong cao nhat : ");
                kq.xuat();
                Console.WriteLine("Danh sach tang dan theo nam vao lam :");
                KQ = ListNV.sortNamVaoLam();
                KQ.xuat();
            }



            Console.ReadLine();
        }
    }
}
