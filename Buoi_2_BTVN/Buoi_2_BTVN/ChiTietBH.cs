using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_2_BTVN
{
    public class ChiTietBH
    {
        private string maSP;
        private string tenSP;
        private double giaBan;
        private int soLuongBan;

        public static double thueVAT = 10;

        public string MaSP
        {
            get { return maSP; }
            set
            {
                if (value.StartsWith("SP"))
                    maSP = value;
                else
                    maSP = "SP0000";
            }
        }
        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }
        public double GiaBan
        {
            get { return giaBan; }
            set
            {
                if (value > 0)
                    giaBan = value;
                else
                    throw new Exception("Gia ban khong hop le");
            }
        }
        public int SoLuongBan
        {
            get { return soLuongBan; }
            set
            {
                if (value > 0)
                    soLuongBan = value;
                else
                    throw new Exception("So luong ban khong hop le");

            }
        }

        public ChiTietBH()
        {
            MaSP = "SP0010";
            TenSP = "May tinh Dell";
            SoLuongBan = 2;
            GiaBan = 15000;
        }
        public ChiTietBH(string maSP, string tenSP, double giaBan, int soLuongBan)
        {
            MaSP = maSP;
            TenSP = tenSP;
            GiaBan = giaBan;
            SoLuongBan = soLuongBan;
        }
        public ChiTietBH(ChiTietBH obj)
        {
            MaSP = obj.MaSP;
            TenSP = obj.TenSP;
            GiaBan = obj.GiaBan;
            SoLuongBan = obj.SoLuongBan;
        }
        public double tinh_ThanhTien()
        {
            return SoLuongBan * GiaBan * (1 + thueVAT);
        }

        public void nhap()
        {
            Console.Write("Nhap ma san pham : ");
            MaSP = Console.ReadLine();
            Console.Write("Nhap ten san pham : ");
            TenSP = Console.ReadLine();
            Console.Write("Nhap gia ban : ");
            GiaBan = double.Parse(Console.ReadLine());
            Console.Write("Nhap so luong ban : ");
            SoLuongBan = int.Parse(Console.ReadLine());
        }
        public void xuat()
        { 
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",MaSP, TenSP, GiaBan, SoLuongBan,tinh_ThanhTien());
        }
    }
}
