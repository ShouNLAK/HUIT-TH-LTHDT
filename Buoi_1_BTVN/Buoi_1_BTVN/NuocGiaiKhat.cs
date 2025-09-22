using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_1_BTVN
{
    internal class NuocGiaiKhat
    {
        private string tenHang;
        private string donViTinh;
        private int soLuong;    
        private double donGia;

        public static double thueVAT = 0.1;

        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }
        public string DonViTinh
        {
            get { return donViTinh; }
            set {
                if (value.ToLower() == "c" || value.ToLower() == "t" || value.ToLower() == "l")
                    donViTinh = value;
                else
                    donViTinh = "k";
            }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set {
                if (value >= 0)
                    soLuong = value;
                else
                    throw new Exception("So luong phai lon hon hoac bang 0");
            }
        }
        public double DonGia
        {
            get { return donGia; }
            set {
                if (value >= 0)
                    donGia = value;
                else
                    throw new Exception("Don gia phai lon hon hoac bang 0");
            }
        }
        public NuocGiaiKhat()
        {
            tenHang = "Chua xac dinh";
            donViTinh = "k";
            soLuong = 0;
            donGia = 0;
        }
        public NuocGiaiKhat(string tenHang, string donViTinh, int soLuong, double donGia)
        {
            TenHang = tenHang;
            DonViTinh = donViTinh;
            SoLuong = soLuong;
            DonGia = donGia;
        }
        public NuocGiaiKhat(NuocGiaiKhat obj)
        {
            tenHang = obj.tenHang;
            donViTinh = obj.donViTinh;
            soLuong = obj.soLuong;
            donGia = obj.donGia;
        }
        public double tinhTien()
        {
            if (donViTinh == "c")
                return SoLuong * (DonGia/20)*(1+thueVAT);
            else if (donViTinh == "l")
                return SoLuong * (DonGia/24)*(1+thueVAT);
            else
                return SoLuong * DonGia * (1 + thueVAT);
        }
        
        public void nhap()
        {
            Console.Write("Nhap ten hang: ");
            TenHang = Console.ReadLine();
            Console.Write("Nhap don vi tinh (t: thung, c: chai, l: lon, k: ket): ");
            DonViTinh = Console.ReadLine();
            Console.Write("Nhap so luong: ");
            SoLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap don gia: ");
            DonGia = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("Ten hang: " + TenHang);
            Console.WriteLine("Don vi tinh: " + DonViTinh);
            Console.WriteLine("So luong: " + SoLuong);
            Console.WriteLine("Don gia: " + DonGia);
            Console.WriteLine("Thanh tien: " + tinhTien());
        }
    }
}
