using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_3_BTVN
{
    internal class PhongTro
    {
        private string maPhong;
        private int soLuongNguoi;
        private double giaThue;
        private int soDien;
        private int coMayLanh;

        public static double giaDien = 3500;

        public string MaPhong
        {
            get { return maPhong; }
            set 
            { 
                if (value.Length == 4 && value.StartsWith("PT"))
                    maPhong = value;
                else
                    maPhong = "PT00";
            }
        }
        public int SoLuongNguoi
        {
            get { return soLuongNguoi; }
            set 
            { 
                if (value > 0)
                    soLuongNguoi = value; 
                else
                    throw new Exception("So luong nguoi phai lon hon 0!");
            }
        }
        public double GiaThue
        {
            get { return giaThue; }
            set 
            { 
                if (value > 0)
                    giaThue = value; 
                else
                    throw new Exception("Gia thue phai lon hon 0!");
            }
        }
        public int SoDien
        {
            get { return soDien; }
            set 
            { 
                if (value >= 0)
                    soDien = value; 
                else
                    throw new Exception("So dien phai lon hon hoac bang 0!");
            }
        }
        public int CoMayLanh
        {
            get { return coMayLanh; }
            set 
            {
                if (value == 1 || value == 0)
                    coMayLanh = value; 
                else
                    throw new Exception(" ( 0 - Khong may lanh | 1 - Co may lanh ) ");
            }
        }

        public PhongTro()
        {
            MaPhong = "PT01";
            SoLuongNguoi = 3;
            GiaThue = 1500000;
            SoDien = 0;
            CoMayLanh = 1;
        }
        public PhongTro(string ma, int sl, double gt, int sd, int cml)
        {
            MaPhong = ma;
            SoLuongNguoi = sl;
            GiaThue = gt;
            SoDien = sd;
            CoMayLanh = cml;
        }
        public PhongTro(PhongTro obj)
        {
            MaPhong = obj.MaPhong;
            SoLuongNguoi = obj.SoLuongNguoi;
            GiaThue = obj.GiaThue;
            SoDien = obj.SoDien;
            CoMayLanh = obj.CoMayLanh;
        }
        public double tinhTienDien()
        {
            return SoDien * giaDien;
        }
        public double tinhTienMayLanh()
        {
            if (CoMayLanh == 1)
                return 50000 * SoLuongNguoi;
            return 0;
        }
        public double tinhTienPhong()
        {
            return GiaThue + tinhTienDien() + tinhTienMayLanh();
        }
        public void xuat()
        {
            Console.WriteLine("{0,-10} {1,-10} {2,-10} {3,-10} {4,-12} {5,-15} {6,-15} {7,-15}",
                MaPhong,SoLuongNguoi,GiaThue,SoDien,CoMayLanh == 1 ? "Co" : "Khong",tinhTienDien(),tinhTienMayLanh(),tinhTienPhong());
        }
    }
}
