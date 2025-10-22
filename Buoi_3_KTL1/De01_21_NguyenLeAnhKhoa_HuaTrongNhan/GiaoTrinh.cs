using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De01_21_NguyenLeAnhKhoa_HuaTrongNhan
{
    public class GiaoTrinh
    {

        private string maGT;
        private string tenGT;
        private string tenChuBien;
        private int soLuongXB;
        private int soTrang;
        private int namXB;

        public static double donGiaTrangIn = 200;
        public string MaGT
        {
            get { return maGT; }
            set
            {
                if (value.Length <= 6 && value.StartsWith("GT")) 
                    maGT = value;
                else 
                    maGT = "GT0000";
            }
        }
        public string TenGT
        {
            get { return tenGT; }
            set
            {
                if (value.Length <= 50) tenGT = value;
                else throw new Exception("Loi TenGT!");
            }
        }
        public string TenChuBien
        {
            get { return tenChuBien; }
            set
            {
                if (value.Length <= 30) tenChuBien = value;
                else throw new Exception("Loi TenChuBien!");
            }
        }
        public int SoLuongXB
        {
            get { return soLuongXB; }
            set
            {
                if (value >= 100) soLuongXB = value;
                else soLuongXB = 100;
            }
        }
        public int SoTrang
        {
            get { return soTrang; }
            set
            {
                if (value >= 30) soTrang = value;
                else soTrang = 30;
            }
        }
        public int NamXB
        {
            get { return namXB; }
            set
            {
                if (value <= DateTime.Now.Year) namXB = value;
                else throw new Exception("Loi Nam!");
            }
        }
        public GiaoTrinh()
        {
            MaGT = "GT1001";
            TenGT = "Lap trinh huong doi tuong";
            TenChuBien = "Lam Thi Hoa Mi";
            SoLuongXB = 1000;
            SoTrang = 106;
            NamXB = 2025;
        }
        public GiaoTrinh(string magt, string tengt, string tencb, int slxb, int sotrang, int namxb)
        {
            MaGT = magt;
            TenGT = tengt;
            TenChuBien = tencb;
            SoLuongXB = slxb;
            SoTrang = sotrang;
            NamXB = namxb;
        }

        public double TinhChiPhi()
        {
            return TinhPhiInAn() + TinhPhiBienTap();
        }
        public double TinhPhiInAn()
        {
            return SoTrang * (donGiaTrangIn + 2500) * 1.0d;
        }
        public double TinhPhiBienTap()
        {
            return SoTrang * 10000;
        }
        public void Xuat()
        {
            Console.WriteLine("{0,-6} {1,-50} {2,-20} {3,-5} {4,-10} {5,-10} {6,-10}", MaGT, TenGT, TenChuBien,NamXB, SoLuongXB, SoTrang, TinhChiPhi());
        }
    }
}
