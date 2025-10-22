using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_BTVN
{
    internal class MatHang
    {
        private string maHang;
        private string tenHang;
        private double donGia;

        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }
        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }
        public double DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public MatHang(string ma, string ten, double gia)
        {
            MaHang = ma;
            TenHang = ten;
            DonGia = gia;
        }
    }
}
