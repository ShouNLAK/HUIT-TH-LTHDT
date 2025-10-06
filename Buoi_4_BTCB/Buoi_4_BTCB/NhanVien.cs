using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_4_BTCB
{
    internal class NhanVien
    {
        private string maNV;
        private string tenNV;
        private int namVaoLam;
        private double heSo;
        private int soNgayNghi;

        public static int LuongCoBan = 1150;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        public int NamVaoLam
        {
            get { return namVaoLam; }
            set 
            {
                namVaoLam = value;
                if (namVaoLam > DateTime.Now.Year)
                {
                    namVaoLam = DateTime.Now.Year;
                }
            }
        }
        public double HeSo
        {
            get { return heSo; }
            set { heSo = value; }
        }
        public int SoNgayNghi
        {
            get { return soNgayNghi; }
            set 
            { 
                soNgayNghi = value;
                if (soNgayNghi < 0)
                {
                    soNgayNghi = 0;
                }
            }
        }
        public NhanVien()
        {
            maNV = "NV001";
            tenNV = "Ho Ten NV";
            namVaoLam = 2006;
            heSo = 2.0;
            soNgayNghi = 2;
        }
        public NhanVien(string maNV, string tenNV,double heSo, int soNgayNghi)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.namVaoLam = DateTime.Today.Year;
            this.heSo = heSo;
            this.soNgayNghi = soNgayNghi;
        }
        public NhanVien(string maNV, string tenNV, int namVaoLam, double heSo, int soNgayNghi)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.namVaoLam = namVaoLam;
            this.heSo = heSo;
            this.soNgayNghi = soNgayNghi;
        }
        public double PhuCapThamNien()
        {
            int thamNien = DateTime.Now.Year - namVaoLam;
            if (thamNien >= 5)
                return thamNien * LuongCoBan / 100.0;
            return 0;
        }
        public virtual char XepLoai()
        {
            if (SoNgayNghi <= 1)    return 'A';
            if (SoNgayNghi <= 3)    return 'B';
            return 'C';
        }
        public virtual double TinhLuong()
        {
            double hsThiDua = 0.5;
            char xl = XepLoai();
            if (xl == 'A') hsThiDua = 1.0;
            if (xl == 'B') hsThiDua = 0.75;
            return LuongCoBan * HeSo * hsThiDua + PhuCapThamNien();
        }
        public virtual void Xuat()
        {
            Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6}",MaNV,TenNV,NamVaoLam,HeSo,SoNgayNghi,XepLoai(),TinhLuong());
        }
    }
}
