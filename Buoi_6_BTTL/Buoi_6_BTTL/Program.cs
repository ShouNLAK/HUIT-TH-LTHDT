using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_6_BTTL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSachBDS ds = new DanhSachBDS();
            ds.Nhap_XML(@"..\..\DSBatDongSan.xml");
            ds.Xuat();

            Console.WriteLine("Tong gia tri cua cac BDS : {0,-20}", ds.TongGiaTriBDS());
            Console.WriteLine("Tong phi kinh doanh cua cac BDS : {0,-20}", ds.TongPhiKinhDoanhBDS());
            Console.ReadKey();
        }
    }
}
