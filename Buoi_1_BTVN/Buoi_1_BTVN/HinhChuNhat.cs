using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_1_BTVN
{
    internal class HinhChuNhat
    {
        private double chieuDai;
        private double chieuRong;

        public double ChieuDai
        {
            get { return chieuDai; }
            set {
                if (value > 0)
                    chieuDai = value;
                else
                    throw new Exception("Chieu dai phai lon hon 0");
            }
        }
        public double ChieuRong
        {
            get { return chieuRong; }
            set {
                if (value > 0)
                    chieuRong = value;
                else
                    throw new Exception("Chieu rong phai lon hon 0");
            }
        }

        public HinhChuNhat()
        {
            chieuDai = 1;
            chieuRong = 1;
        }
        public HinhChuNhat(double cd, double cr)
        {
            ChieuDai = cd;
            ChieuRong = cr;
        }
        public HinhChuNhat(HinhChuNhat obj)
        {
            chieuDai = obj.chieuDai;
            chieuRong = obj.chieuRong;
        }

        public double tinhChuVi()
        {
            return (chieuDai + chieuRong) * 2;
        }
        public double tinhDienTich()
        {
            return chieuDai * chieuRong;
        }
        public double tinhDuongCheo()
        {
            return Math.Sqrt(chieuDai * chieuDai + chieuRong * chieuRong);
        }
        public void xuat()
        {
            Console.WriteLine("Chieu dai: " + chieuDai);
            Console.WriteLine("Chieu rong: " + chieuRong);
            Console.WriteLine("Chu vi: " + tinhChuVi());
            Console.WriteLine("Dien tich: " + tinhDienTich());
            Console.WriteLine("Duong cheo: " + tinhDuongCheo());
        }
        public void nhap()
        {
            Console.Write("Nhap chieu dai: ");
            ChieuDai = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            ChieuRong = double.Parse(Console.ReadLine());
        }
    }
}
