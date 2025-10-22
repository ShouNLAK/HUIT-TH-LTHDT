using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_4_BTCB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CongTy congTy = new CongTy();
            congTy.Nhap(@"..\..\DSCTY.xml");
            congTy.Xuat();

            Console.ReadKey();

            NhanVien nhanVien1 = new NhanVien();
            nhanVien1.Xuat();
            NhanVien nhanVien2 = new NhanVien("NV00003", "Hoa Van", 3.0,0);
            nhanVien2.Xuat();
            CanBo canBo1 = new CanBo();
            canBo1.Xuat();
            CanBo canBo2 = new CanBo("NV00004", "Van Trang", 4.0, "Pho truong phong", 2.0);
            canBo2.Xuat();
            CanBo canBo3 = new CanBo("NV00006", "Hai", 2013,3.6, 5, "Giam doc", 7.0 ,"Ban quan ly");
            canBo3.Xuat();
            Console.ReadKey();
        }
    }
}
