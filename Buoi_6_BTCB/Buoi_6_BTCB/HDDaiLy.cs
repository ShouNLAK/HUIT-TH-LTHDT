using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_6_BTCB
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
        public HDDaiLy() : base()
        {
            ThoiGianHopTac = 0;
        }
        public HDDaiLy(string ma, string ten, double sl, double gia, int nam) : base(ma,ten,sl,gia)
        {
            ThoiGianHopTac = nam;
        }

        public override double TinhChietKhau()
        {
            double phanTramCK = 0.3;
            if (ThoiGianHopTac > 5)
                phanTramCK += ThoiGianHopTac * 0.01;
            if (phanTramCK > 0.35)
                phanTramCK = 0.35;
            return SoLuong * GiaBan * phanTramCK;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap nam bat dau hop tac : ");
            int nam = int.Parse(Console.ReadLine());
            ThoiGianHopTac = nam;
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
