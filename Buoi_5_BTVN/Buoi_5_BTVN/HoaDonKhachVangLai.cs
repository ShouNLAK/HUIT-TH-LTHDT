using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_BTVN
{
    internal class HoaDonKhachVangLai : HoaDon
    {
        public HoaDonKhachVangLai(string ma, string ten, DateTime ngay, MatHang sanpham, double sl)
            : base(ma, ten, ngay, sanpham, sl)
        {
        }
        public override double TinhKhuyenMai()
        {
            if(TinhThanhTien() > 1000000)
                return 0.03 * TinhThanhTien();
            return 0;
        }
    }
}
