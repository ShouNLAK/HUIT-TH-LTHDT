using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_BTVN
{
    internal class HoaDonKhachVIP : HoaDon
    {
        public HoaDonKhachVIP(string ma, string ten, DateTime ngay, MatHang sanpham, double sl)
            : base(ma, ten, ngay, sanpham, sl)
        {
        }
        public override double TinhKhuyenMai()
        {
            if (SoLuong > 50)
                return 0.05* TinhThanhTien();
            else if (SoLuong <= 50 && TinhThanhTien() >= 600000)
                return 0.04*TinhThanhTien();
            else if (SoLuong > 10)
                return 0.01 *TinhThanhTien();
            return 0;
        }
    }
}
