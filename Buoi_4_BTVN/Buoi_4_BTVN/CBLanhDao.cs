using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_4_BTVN
{
    internal class CBLanhDao : NhanVien
    {
        private string chucVu;
        private double thamNienQL;

        public CBLanhDao()
        {
            MaNV = "NV009";
            tenNV = "Dieu Hien";
            heSoLuong = 4.67;
            chucVu = "Giam doc";
            thamNienQL = 10;
        }
        public CBLanhDao(string ma, string ten, double hsl, string cv, double tnql) : base(ma,ten,hsl)
        {
            chucVu = cv;
            thamNienQL = tnql;
        }
        public double HeSoLanhDao
        { 
            get
            {
                if (chucVu == "Giam doc") return 7.0;
                else if (chucVu == "Truong phong") return 6.0;
                else if (chucVu == "Pho phong") return 4.5;
                return 1.0;
            } 
        }
        public double phuCapLD()
        {
            return 1500000*HeSoLanhDao;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.Write("{0,-10} | {1,-13} | {2,-15}",phuCapLD(),TinhThuNhap() + phuCapLD(),chucVu);
        }
    }
}
