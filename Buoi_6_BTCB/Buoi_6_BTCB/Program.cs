using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_6_BTCB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DSHoaDon ds = new DSHoaDon();
            while (true)
            {
                Console.WriteLine("1. Nhap du lieu tu XML");
                Console.WriteLine("2. Nhap du lieu tu ban phim");
                Console.WriteLine("3. Xuat du lieu");
                Console.WriteLine("4. Tinh tong tien tat ca hoa don");
                Console.WriteLine("5. Khach hang co so luong mua nhieu nhat");
                Console.WriteLine("6. Tong so tien chiet khau tu hoa don cong ty");
                Console.WriteLine("7. In thong tin chi tiet hoa don la dai ly cap 1");
                Console.WriteLine("8. Sap xep tang dan theo so luong va giam dan theo thanh tien");
                Console.WriteLine("9. Tong tien tro gia cua cong ty da ho tro");

                Console.Write(">> Chon chuong trinh thuc thi : ");
                int chon = int.Parse(Console.ReadLine());
                if (chon == 1)
                {
                    ds.Doc_DSHD_XML(@"..\..\DanhSach.xml");
                    Console.WriteLine("Da doc file XML");
                }
                else if (chon == 2)
                    ds.NhapDS();
                else if (chon == 3)
                    ds.Xuat_DSHD();
                else if (chon == 4)
                    Console.WriteLine("Tong tien tren tat ca cac hoa don la : {0,-20}", ds.TinhTongTien());
                else if (chon == 5)
                {
                    List<HoaDon> KQ = new List<HoaDon>();
                    Console.WriteLine("Khach hang co so luong mua nhieu nhat la : ");
                    KQ = ds.KhachHangMuaNhieuNhat();
                    foreach (HoaDon node in KQ)
                        node.Xuat();
                }
                else if (chon == 6)
                    Console.WriteLine("Tong so tien chiet khau tu hoa don cong ty : {0,-20}", ds.TinhTongChietKhau_HDCTy());
                else if (chon == 7)
                {
                    List<HDDaiLy> KQ = new List<HDDaiLy>();
                    KQ = ds.LocHDDaiLy();
                    foreach (HDDaiLy node in KQ)
                        node.Xuat();
                }
                else if (chon == 8)
                {
                    List<HoaDon> KQ = new List<HoaDon>();
                    KQ = ds.sapXep_TDSoLuong_GDThanhTien();
                    foreach (HoaDon node in KQ)
                        node.Xuat();
                }
                else if (chon == 9)
                {
                    Console.WriteLine("Tong tien tro gia cua cong ty da ho tro : {0,-20}", ds.sum_HoTroGia_HDCongTy());
                }
                else if (chon == 0)
                    break;
            }

            Console.ReadKey();
        }
    }
}
