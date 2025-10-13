using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi_5_BTCB
{
    public class CanBo : NhanVienABC
    {
        private string chucVu;
        private double heSoChucVu;

        public CanBo(string ma, string ten, int ns, int nvl, string phai, double hsl, string cv, double hscv)
            : base(ma, ten, ns, nvl, phai, hsl)
        {
            chucVu = cv;
            heSoChucVu = hscv;
        }

        public override double TinhLuong()
        {
            return heSoLuong * LuongCoBan + (heSoChucVu*1350);
        }

        public override char XepLoai()
        {
            return 'A';
        }

        public void Xuat()
        {
            Console.WriteLine("{0,-8} | {1,-20} | {2,-5} | {3,-5} | {4,-5} | {5,-7} | C.Vu - H.so : {6,-8} - {7,-3} | {8,-2} | {9,-10}",
                            maNhanVien, tenNhanVien, namSinh, namVaoLam, gioiTinh, heSoLuong, chucVu, heSoChucVu, XepLoai(), TinhThuNhap());
        }
    }
}