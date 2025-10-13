using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi_5_BTCB
{
    public abstract class NhanVienABC
    {
        protected string gioiTinh;
        protected double heSoLuong;
        protected string maNhanVien;
        protected int namSinh;
        protected int namVaoLam;
        protected string tenNhanVien;

        public static int LuongCoBan = 2340000;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set
            {
                if (value == "1")
                    gioiTinh = "Nu";
                else
                    gioiTinh = "Nam";
            }
        }

        public NhanVienABC(string ma, string ten, int ns, int nvl, string phai, double hsl)
        {
            maNhanVien = ma;
            tenNhanVien = ten;
            namSinh = ns;
            namVaoLam = nvl;
            GioiTinh = phai;
            heSoLuong = hsl;
        }

        public double TinhPhuCapThamNien()
        {
            return (DateTime.Now.Year - namVaoLam) / 100.0 * LuongCoBan;
        }

        public double TinhThuNhap()
        {
            if (XepLoai() == 'A')
                return TinhLuong() * 1.0 + TinhPhuCapThamNien();
            else if (XepLoai() == 'B')
                return TinhLuong() * 0.75 + TinhPhuCapThamNien();
            else if (XepLoai() == 'C')
                return TinhLuong() * 0.5 + TinhPhuCapThamNien();
            else
                return TinhPhuCapThamNien();
        }

        public abstract char XepLoai();
        public abstract double TinhLuong();
    }
}