using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_4_BTVN
{
    internal class NhanVien
    {
        protected string maNV;
        protected string tenNV;
        protected double heSoLuong;

        public static double LuongCB = 2340000;
        public string MaNV
        {
            get { return maNV; } 
            set 
            {
                if (value.StartsWith("NV"))
                    maNV = value;
                else
                    maNV = "NV001";
            }
        }
        public NhanVien()
        {
            maNV = "NV001";
            tenNV = "Nguyen Van A";
            heSoLuong = 2.34;
        }
        public NhanVien(string ma, string ten, double hsl)
        {
            MaNV = ma;
            tenNV = ten;
            heSoLuong = hsl;
        }
        public double TinhThuNhap()
        {
            return heSoLuong * LuongCB;
        }
        public virtual void Xuat()
        {
            Console.Write("{0,-6} | {1,-20} | {2,-12} | {3,-10} | ",MaNV,tenNV,heSoLuong,TinhThuNhap());
        }
    }
}
