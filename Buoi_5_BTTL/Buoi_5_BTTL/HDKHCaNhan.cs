using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_BTTL
{
    internal class HDKHCaNhan : HoaDon
    {
        private double khoangCach;
        
        public double KhoangCach
        {
            get { return khoangCach; } 
            set { khoangCach = value; }
        }

        public HDKHCaNhan()
        {

        }
        public HDKHCaNhan(string ma, string ten, double sl, double gia, double km) : base (ma,ten,sl,gia)
        {
            khoangCach = km;
        }

        public override double TinhChietKhau()
        {
            double Tong = 0;
            if (SoLuong >= 5)
                Tong += 0.03 * (SoLuong * GiaBan);
            if (KhoangCach < 10)
                Tong += 20000 * SoLuong;
            return Tong;
        }
        public override void Xuat()
        {
            Console.WriteLine("==============================");
            base.XuatTT();
            Console.WriteLine("Khoang cach : {0,-20}",KhoangCach);
            Console.WriteLine("==============================");
        }
    }
}
