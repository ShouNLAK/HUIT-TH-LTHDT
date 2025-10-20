using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_6_BTCB
{
    internal class HDKHCaNhan : HoaDon,IHoTro
    {
        private double khoangCach;
        
        public double KhoangCach
        {
            get { return khoangCach; } 
            set { khoangCach = value; }
        }

        public HDKHCaNhan() : base()
        {
            KhoangCach = 0;
        }
        public HDKHCaNhan(string ma, string ten, double sl, double gia, double km) : base (ma,ten,sl,gia)
        {
            khoangCach = km;
        }

        public override double TinhChietKhau()
        {
            double Tong = 0;
            if (SoLuong > 7)
                Tong += 0.05 * (SoLuong * GiaBan);
            if (KhoangCach < 10)
                Tong += 10000 * SoLuong;
            return Tong;
        }
        public double HoTroGia()
        {
            double hoTro = 0;
            hoTro = 0.02 * SoLuong * GiaBan;
            if (SoLuong > 2)
                hoTro += 100000;
            return hoTro;
        }
        public override double TinhThanhTien()
        {
            return base.TinhThanhTien() - HoTroGia();
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap khoang cach (km) : ");
            KhoangCach = double.Parse(Console.ReadLine());
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
