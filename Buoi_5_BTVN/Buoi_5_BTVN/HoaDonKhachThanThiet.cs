using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_BTVN
{
    internal class HoaDonKhachThanThiet:HoaDon
    {
        public HoaDonKhachThanThiet(string ma, string ten, DateTime ngay, MatHang sanpham, double sl)
            : base(ma, ten, ngay, sanpham, sl)
        {
        }
        public override double TinhKhuyenMai()
        {
            if (SoLuong > 60)
                return 0.04*TinhThanhTien();
            else if (SoLuong <= 50 && TinhThanhTien() >= 800000)
                return 0.03*TinhThanhTien();
            return 0;
        }
    }
}
