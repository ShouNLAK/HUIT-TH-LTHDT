using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi_5_BTCB
{
    public class NhanVienSX : NhanVienABC
    {
        public static double hesoPCNN = 0.1;
        private int soNgayNghi;

        public NhanVienSX(string ma, string ten, int ns, int nvl, string phai, double hsl, int snn) : base(ma, ten, ns, nvl, phai, hsl)
        {
            soNgayNghi = snn;
        }

        public override double TinhLuong()
        {
            return heSoLuong * LuongCoBan * (1+ hesoPCNN);
        }

        public override char XepLoai()
        {
            if (soNgayNghi <= 1)
                return 'A';
            else if (soNgayNghi <= 3)
                return 'B';
            else if (soNgayNghi <= 5)
                return 'C';
            else
                return 'D';
        }

        public void Xuat()
        {
            Console.WriteLine("{0,-8} | {1,-20} | {2,-5} | {3,-5} | {4,-5} | {5,-7} | So ngay nghi : {6,-13} | {7,-2} | {8,-10}",
                maNhanVien,tenNhanVien,namSinh,namVaoLam,gioiTinh,heSoLuong,soNgayNghi,XepLoai(),TinhThuNhap());
        }
    }
}