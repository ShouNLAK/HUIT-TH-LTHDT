using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_4_BTTL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Bai Hang hoa - Nuoc giai khat");
            Console.WriteLine("2. Bai Nguoi - Sinh vien");
            Console.Write("---> Hay chon chuong trinh thuc thi : ");
            int chon = int.Parse(Console.ReadLine());
            if (chon == 1)
            {
                DanhSachHangHoa ds = new DanhSachHangHoa();
                ds.Nhap_XML(@"..\..\DanhSachHangHoa.xml");
                ds.Xuat();

                //List<HangHoa> ds = new List<HangHoa>();
                //ds.Add(new HangHoa("HH002", "Sting"));
                //ds.Add(new NuocGiaiKhat("KH003", "Coca", "Lon", 1, 8000));
                //foreach (HangHoa hh in ds)
                //{
                //    hh.Xuat();
                //    Console.WriteLine();
                //}
            }
            else if (chon == 2)
            {
                DanhSachNguoi ds = new DanhSachNguoi();
                ds.Nhap_XML(@"..\..\DanhSachNguoi.xml");
                ds.Xuat();

                //ds.Add(new Nguoi("Tran Van A", "01/01/1980", "Nam"));
                //ds.Add(new SinhVien("Nguyen Le Anh Khoa", "15/10/2006", "Nam", "2001240206", "Dai hoc"));
                //foreach (Nguoi x in ds)
                //{
                //    x.Xuat();
                //    Console.WriteLine();
                //}
            }

            Console.ReadKey();
        }
    }
}
