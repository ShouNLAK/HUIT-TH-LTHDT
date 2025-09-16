using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_1
{
    internal class SanPhamDienTu
    {
        private string hangSX;
        private string soSeries;
        private string tenSP;
        private double giaBan;
        private string loaiSP;

        public double thueVAT = 0.1;

        public string HangSX
        {
            get { return hangSX; }
            set
            {
                if (value != null && !String.IsNullOrEmpty(value))
                    hangSX = value;
            }
        }

        public string SoSeries
        {
            get { return soSeries; }
            set
            {
                if (value.StartsWith("S"))
                    soSeries = value;
                else
                    soSeries = "S000";
            }
        }
        public double GiaBan
        {
            get { return giaBan; }
            set
            {
                if (value > 4000000)
                    giaBan = value;
                else
                    throw new Exception("Giá bán của sản phẩm phải lớn hơn 4 triệu đồng");
            }
        }
        public string LoaiSP
        {
            get { return loaiSP; }
            set
            {
                if (value.ToLower() == "desktop" || value.ToLower() == "laptop")
                    loaiSP = value;
                else
                    loaiSP = "phone";
            }
        }
        public string TenSP
        {
            get { return tenSP; }
            set
            {
                if (value != null && !String.IsNullOrEmpty(value))
                    tenSP = value;
            }
        }

        public SanPhamDienTu()
        {
            HangSX = "NULL";
            SoSeries = "S000";
            TenSP = "NULL";
            GiaBan = 4000001;
            LoaiSP = "Phone";
        }
        public SanPhamDienTu(string Brand, string Series, string Name, double Price, string Type)
        {
            HangSX = Brand;
            SoSeries = Series;
            TenSP = Name;
            GiaBan = Price;
            LoaiSP = Type;
        }
        public SanPhamDienTu(SanPhamDienTu obj)
        {
            HangSX += obj.hangSX;
            SoSeries += obj.soSeries;
            TenSP += obj.tenSP;
            GiaBan += obj.giaBan;
            LoaiSP += obj.loaiSP;
        }


        public double tinhPhiBaoHanh()
        {
            if (loaiSP == "desktop")
                return giaBan * 0.08;
            if (loaiSP == "laptop")
                return giaBan * 0.05;
            if (giaBan * 0.1 > 2000000)
                return 2000000;
            return giaBan * 0.1;
        }
        public double tinhUuDai()
        {
            if (hangSX == "Samsung")
                return 500000;
            return 0;
        }
        public double tinhThue()
        {
            return giaBan * thueVAT;
        }
        public double tinhThanhTien()
        {
            return giaBan + tinhPhiBaoHanh() - tinhUuDai() + tinhThue();
        }

        public void nhap()
        {
            Console.WriteLine("Nhập tên hãng sản xuất : ");
            hangSX = Console.ReadLine();
            Console.WriteLine("Nhập số Series của sản phẩm : ");
            soSeries = Console.ReadLine();
            Console.WriteLine("Nhập tên sản phẩm : ");
            tenSP = Console.ReadLine();
            Console.WriteLine("Nhập giá bán sản phẩm : ");
            giaBan = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhập loại sản phẩm \t(Desktop - Máy tính để bàn | Laptop - Máy tinh xách tay | Phone - Điện thoại di động)");
            loaiSP = Console.ReadLine();
        }
        public void xuat()
        {
            Console.WriteLine("\t--- Thông tin thiết bị : {2} ---\nHãng sản xuất : {0} | Số Series : {1} | Tên sản phẩm : {2} | Giá bán : {3} | Loại sản phẩm : {4} | Thành tiền : {5}\n", hangSX, soSeries, tenSP, giaBan, loaiSP, tinhThanhTien());
        }
    }
}
