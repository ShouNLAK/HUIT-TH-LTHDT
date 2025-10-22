using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_BTCB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DSNhanVien ds = new DSNhanVien();
            ds.DocDSNV_XML(@"..\..\DSNV.xml");
            ds.XuatDSNV();
            Console.WriteLine("Tong thu nhap cua tat ca nhan vien: {0}", ds.TinhTongThuNhapNV());

            Console.ReadKey();
        }
    }
}
