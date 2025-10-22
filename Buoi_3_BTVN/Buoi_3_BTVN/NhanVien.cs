using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_3_BTVN
{
    internal class NhanVien
    {
        private string maNV;
        private string tenNV;
        private string phongBan;
        private string chucVu;
        private double heSoLuong;
        private double thamNienCT;
        private int soNgayLamViec;

        public static double luongCB = 2340000;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        public string ChucVu
        {
            get { return chucVu; }
            set
            {
                if (value == "1")
                    chucVu = "Nhan vien";
                else if (value == "2")
                    chucVu = "Lanh dao";
                else
                    throw new Exception("Chuc vu khong hop le");
            }
        }
        public string PhongBan
        {
            get { return phongBan; }
            set { phongBan = value; }
        }
        public double HeSoLuong
        {
            get { return heSoLuong; }
            set { heSoLuong = value; }
        }
        public double ThamNienCT
        {
            get { return thamNienCT; }
            set { thamNienCT = value; }
        }
        public int SoNgayLamViec
        {
            get { return soNgayLamViec; }
            set { soNgayLamViec = value; }
        }

        public NhanVien()
        {
            MaNV = "";
            TenNV = "";
            ChucVu = "1";
            PhongBan = "";
            HeSoLuong = 0;
            ThamNienCT = 0;
            SoNgayLamViec = 0;
        }
        public NhanVien(string maNV, string tenNV, string phongBan, string chucVu, double heSoLuong, double thamNienCT, int soNgayLamViec)
        {
            MaNV = maNV;
            TenNV = tenNV;
            PhongBan = phongBan;
            ChucVu = chucVu;
            HeSoLuong = heSoLuong;
            ThamNienCT = thamNienCT;
            SoNgayLamViec = soNgayLamViec;
        }
        public NhanVien(NhanVien obj)
        {
            MaNV = obj.MaNV;
            TenNV = obj.TenNV;
            PhongBan = obj.PhongBan;
            ChucVu = obj.ChucVu;
            HeSoLuong = obj.HeSoLuong;
            ThamNienCT = obj.ThamNienCT;
            SoNgayLamViec = obj.SoNgayLamViec;
        }

        public double tinh_HeSoThiDua()
        {
            if (ChucVu == "Lanh dao")
            {
                return 1.0;
            }
            else
            {
                if (SoNgayLamViec > 22)
                    return 1.0;
                else if (SoNgayLamViec > 20)
                    return 0.8;
                else
                    return 0.6;
            }
        }
        public double tinh_PhuCap()
        {
            if (ChucVu == "Lanh dao")
                return 1350000;
            return 0;
        }
        public double tinh_Luong()
        {
            return HeSoLuong * luongCB * tinh_HeSoThiDua() + 1100000 + tinh_PhuCap();
        }

        public void xuat()
        {
            Console.WriteLine("{0,-8} {1,-20} {2,-15} {3,-12} {4,-10} {5,-12} {6,-15} {7,-10} {8,-12}",
                MaNV, TenNV, PhongBan, ChucVu, HeSoLuong, ThamNienCT, SoNgayLamViec, tinh_PhuCap(), tinh_Luong());
        }
    }
}
