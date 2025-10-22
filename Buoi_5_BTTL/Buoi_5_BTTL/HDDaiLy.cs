using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_BTTL
{
    internal class HDDaiLy : HoaDon
    {
        protected int thoiGianHopTac;
        public int ThoiGianHopTac
        {
            get { return thoiGianHopTac; }
            set 
            {
                if (DateTime.Now.Year - value > 0)
                    thoiGianHopTac = DateTime.Now.Year - value;
                else
                    thoiGianHopTac = 0;
            }
        }
        public HDDaiLy()
        {

        }
        public HDDaiLy(string ma, string ten, double sl, double gia, int nam) : base(ma,ten,sl,gia)
        {
            ThoiGianHopTac = nam;
        }

        public override double TinhChietKhau()
        {
            double Tong = SoLuong * GiaBan * 0.3;
            if (ThoiGianHopTac > 3 && ThoiGianHopTac < 9)
                Tong += SoLuong * GiaBan * (ThoiGianHopTac - 3) * 0.01;
            else if (ThoiGianHopTac <= 9)
                Tong += SoLuong * GiaBan * 0.05;
            return Tong;
        }
        public override void Xuat()
        {
            Console.WriteLine("==============================");
            base.XuatTT();
            Console.WriteLine("Thoi gian hop tac : {0,-20} (nam)", ThoiGianHopTac);
            Console.WriteLine("==============================");
        }
    }
}
