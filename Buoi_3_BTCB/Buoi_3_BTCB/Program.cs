using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_3_BTCB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Khoa khoa = new Khoa();
            khoa.DocDSGiangVien(@"..\..\Khoa.xml");
            Console.WriteLine("\n----- Danh sach giang vien -----");
            khoa.XuatDSGiangVien();
            Console.WriteLine("\nTong so nhom huong dan: {0}", khoa.TinhTongNhomHD());
            Console.WriteLine("\n=> Danh sach giang vien sau khi sap xep tang dan theo ho ten : ");
            khoa.SXTangDanHoTen();
            khoa.XuatDSGiangVien();
            Console.WriteLine("\n=> Danh sach giang vien sau khi sap xep giam dan theo so nhom : ");
            khoa.SXGiamDanNhomHD();
            khoa.XuatDSGiangVien();
            Console.WriteLine("\n=> Danh sach giang vien co so nhom huong dan lon hon 1 : ");
            List<GiangVien> locGV = khoa.LocSoNhomLonHon1();
            Console.WriteLine("Ho ten \t\t So nhom HD");
            foreach (GiangVien gv in locGV)
            {
                gv.xuat();
            }

            Console.ReadKey();
        }
    }
}
