using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_2
{
    public class NhanVien
    {
        private string maNV;
        private string hoTen;
        private double heSoLuong;
        private int namVaoLam;

        public static int mucLuongTT = 2340000;

        public String MaNV
        {
            get {return maNV;}
            set { maNV = value;}
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public double HeSoLuong
        {
            get { return heSoLuong; }
            set 
            { 
                if (value > 0)
                    heSoLuong = value;
                else
                    heSoLuong = 0;
            }
        }
        public int NamVaoLam
        {
            get { return namVaoLam; }
            set 
            {   
                if (value > 0 && value <= DateTime.Today.Year)
                    namVaoLam = value;
                else namVaoLam = DateTime.Today.Year;
            }
        }
        public int MucLuongTT
        {
            get { return mucLuongTT; }
            set { mucLuongTT = value; }
        }
        public NhanVien()
        {
            MaNV = "000";
            HoTen = "NULL";
            HeSoLuong = 0;
            NamVaoLam = 0;
        }
        public NhanVien(string maNV, string hoTen, double heSoLuong, int namVaoLam)
        {
            MaNV = maNV;
            HoTen = hoTen;
            HeSoLuong = heSoLuong;
            NamVaoLam = namVaoLam;
        }
        public NhanVien (NhanVien obj)
        {
            MaNV = obj.MaNV;
            HoTen = obj.HoTen;
            HeSoLuong = obj.HeSoLuong;
            NamVaoLam = obj.NamVaoLam;
        }
        public double heSoPhuCapThamNien()
        {
            return (DateTime.Today.Year*1.0-NamVaoLam*1.0) / 100;
        }
        public double luongCoBan()
        {
            return HeSoLuong * mucLuongTT;
        }
        public double luongNV()
        {
            return luongCoBan() * (1+heSoPhuCapThamNien());
        }
        public void nhap()
        {
            Console.Write("Nhap ma nhan vien : ");
            MaNV = Console.ReadLine();
            Console.Write("Nhap ho ten nhan vien : ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap he so luong nhan vien : ");
            HeSoLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhap nam vao lam cua nhan vien : ");
            NamVaoLam = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5} | {6} ",MaNV,HoTen, HeSoLuong,NamVaoLam,heSoPhuCapThamNien(),luongCoBan(),luongNV());
        }
    }
}
