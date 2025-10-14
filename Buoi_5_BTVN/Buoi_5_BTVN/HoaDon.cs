using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_BTVN
{
    abstract class HoaDon
    {
        protected string maSo;
        protected string tenKhachHang;
        protected DateTime ngayLap;
        protected MatHang matHang;
        protected double soLuong;

        public string MaSo
        {
            get { return maSo; }
            set { maSo = value; }
        }
        public string TenKhachHang
        {
            get { return tenKhachHang; }
            set { tenKhachHang = value; }
        }
        public DateTime NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }
        public double SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public HoaDon(string ma, string ten, DateTime ngay, MatHang sanpham, double sl)
        {
            MaSo = ma;
            TenKhachHang = ten;
            NgayLap = ngay;
            matHang = sanpham;
            SoLuong = sl;
        }
        public void Xuat()
        {
            Console.Write("{0,-10} | {1,-20} | {2,-15} | {3,-10} - {4,-20} - {5,-10} | {6,-10} | {7,-10} | {8,-10} | {9,-10}",
                MaSo,TenKhachHang,NgayLap,matHang.MaHang,matHang.TenHang,matHang.DonGia,SoLuong,TinhThanhTien(),TinhKhuyenMai(),TinhTriGia());
        }

        public double TinhThanhTien()
        {
            return SoLuong * matHang.DonGia;
        }
        public double TinhTriGia()
        {
            return TinhThanhTien() - TinhKhuyenMai();
        }
        public abstract double TinhKhuyenMai();
    }
}
