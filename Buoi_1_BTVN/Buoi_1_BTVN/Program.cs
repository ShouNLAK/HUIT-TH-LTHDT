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
            Console.ReadLine();
        }
    }
}
