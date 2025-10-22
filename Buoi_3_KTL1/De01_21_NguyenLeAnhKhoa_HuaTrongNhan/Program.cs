using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De01_21_NguyenLeAnhKhoa_HuaTrongNhan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhaXuatBan nxb = new NhaXuatBan();
            NhaXuatBan KQ = new NhaXuatBan();
            int choose;
            do
            {
                Console.WriteLine("\n\n1. Doc file XML tao ra danh sach");
                Console.WriteLine("2. Xuat danh sach giao trinh cua nha xuat ban");
                Console.WriteLine("3. Tinh tong chi phi cua tat ca giao trinh cua nha xuat ban");
                Console.WriteLine("4. Sap xep theo tang dan so ban in , neu trung thi giam dan theo so trang in");
                Console.WriteLine("5. Xuat giao trinh co chi phi xuat ban lon nhat");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.WriteLine("-------------------------------------------------");
                Console.Write("Nhap chuong trinh ban muon chay : ");
                choose = int.Parse(Console.ReadLine());
                if (choose == 1)
                {
                    Console.WriteLine("Da nhap file XML");
                    nxb.nhap_DS_File(@"..\..\ThongTinGiaoTrinh.xml");
                }
                else if (choose == 2)
                    nxb.xuat_DSGT();
                else if (choose == 3)
                    Console.WriteLine("Tong chi phi = {0}", nxb.tinh_TongChiPhi());
                else if (choose == 4)
                {
                    KQ = nxb.sapXep_SoBanInTD_SoTrangInGD();
                    KQ.xuat_DSGT();
                }
                else if (choose == 5)
                {
                    GiaoTrinh x = new GiaoTrinh();
                    x = nxb.max_ChiPhiGT();
                    Console.WriteLine("{0,-6} {1,-50} {2,-20} {3,-5} {4,-10} {5,-10} {6,-10}", "Ma GT", "Ten GT", "Ten CB", "Nam SX", "So Luong XB", "So Trang", "Chi Phi");
                    x.Xuat();
                }
            } while (choose != 0);
            Console.WriteLine("Da thoat chuong trinh");
            Console.ReadKey();

        }
    }
}
