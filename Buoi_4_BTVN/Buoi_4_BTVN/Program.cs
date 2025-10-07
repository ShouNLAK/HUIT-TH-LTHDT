using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_4_BTVN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dsNhanVien ds = new dsNhanVien();
            ds.Nhap_XML(@"..\..\DSNV.xml");
            ds.Xuat();

            Console.ReadKey();
        }
    }
}
