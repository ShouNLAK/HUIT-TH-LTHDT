using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_BTTL
{
    abstract class HoaDon
    {
        protected string maKH;
        protected string tenKH;
        protected double soLuong;
        protected double giaBan;

        public static double thueVAT = 0.1;

        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        public double GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }
        public double SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public HoaDon()
        {

        }
        public HoaDon(string ma, string ten, double sl, double gia)
        {
            MaKH = ma;
            TenKH = ten;
            SoLuong = sl;
            GiaBan = gia;
        }

        public double TinhThanhTien()
        {
            return SoLuong * GiaBan - TinhChietKhau() + (thueVAT * (SoLuong * GiaBan));
        }

        public void XuatTT()
        {
            Console.WriteLine("{0,-10} | {1,-30} | {2,-10} | {3,-20} | {4,-20} | {5,-20}",
                MaKH,TenKH,SoLuong,GiaBan,TinhChietKhau(), TinhThanhTien());
        }

        public abstract double TinhChietKhau();
        public abstract void Xuat();
    }
}
