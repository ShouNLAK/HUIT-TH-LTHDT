using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_1_BTVN
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Bai 1: Nuoc Giai Khat");
                Console.WriteLine("Bai 2: Hinh Chu Nhat");
                Console.WriteLine("-------------------");
                Console.Write("Nhap bai can chay: ");
                int choose = Int32.Parse(Console.ReadLine());
            if (choose == 1)
            {
                NuocGiaiKhat nuoc1 = new NuocGiaiKhat();
                NuocGiaiKhat nuoc2 = new NuocGiaiKhat("Coca", "l", 48, 12000);
                NuocGiaiKhat nuoc3 = new NuocGiaiKhat(nuoc2);
                nuoc1.nhap();
                Console.WriteLine("Nuoc 1: ");
                nuoc1.xuat();
                Console.WriteLine("Nuoc 2: ");
                nuoc2.xuat();
                Console.WriteLine("Nuoc 3: ");
                nuoc3.xuat();
            }
            else if (choose == 2)
            {
                HinhChuNhat hcn1 = new HinhChuNhat();
                HinhChuNhat hcn2 = new HinhChuNhat(3, 4);
                HinhChuNhat hcn3 = new HinhChuNhat(hcn2);
                Console.WriteLine("Hinh chu nhat 1: ");
                Console.WriteLine("Chieu dai: " + hcn1.ChieuDai);
                Console.WriteLine("Chieu rong: " + hcn1.ChieuRong);
                Console.WriteLine("Chu vi: " + hcn1.tinhChuVi());
                Console.WriteLine("Dien tich: " + hcn1.tinhDienTich());
                Console.WriteLine("Hinh chu nhat 2: ");
                Console.WriteLine("Chieu dai: " + hcn2.ChieuDai);
                Console.WriteLine("Chieu rong: " + hcn2.ChieuRong);
                Console.WriteLine("Chu vi: " + hcn2.tinhChuVi());
                Console.WriteLine("Dien tich: " + hcn2.tinhDienTich());
                Console.WriteLine("Hinh chu nhat 3: ");
                Console.WriteLine("Chieu dai: " + hcn3.ChieuDai);
                Console.WriteLine("Chieu rong: " + hcn3.ChieuRong);
                Console.WriteLine("Chu vi: " + hcn3.tinhChuVi());
                Console.WriteLine("Dien tich: " + hcn3.tinhDienTich());
                System.Console.WriteLine("---------------------------");
                System.Console.WriteLine("Change size hcn1");
                hcn1.ChangeSize(2, 3, 1);
                Console.WriteLine("Hinh chu nhat 1: ");
                Console.WriteLine("Chieu dai: " + hcn1.ChieuDai);
                Console.WriteLine("Chieu rong: " + hcn1.ChieuRong);
                Console.WriteLine("Chu vi: " + hcn1.tinhChuVi());
                Console.WriteLine("Dien tich: " + hcn1.tinhDienTich());

            }
            else
            {
                Console.WriteLine("Khong co bai nay");
            }
            Console.ReadLine();
        }
    }
}
