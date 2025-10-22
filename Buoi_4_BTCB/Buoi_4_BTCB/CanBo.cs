using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_4_BTCB
{
    internal class CanBo : NhanVien
    {
        private string chucVu;
        private double heSoChucVu;
        private string phongBan;
        public string ChucVu
        {
            get { return chucVu; }
            set 
            { 
                chucVu = value;
                if (!(chucVu == "Giam doc" || chucVu == "Pho GD" || chucVu == "Truong phong" || chucVu == "Pho phong"))
                {
                    chucVu = "Truong phong";
                }
            }
        }
        public double HeSoChucVu
        {
            get { return heSoChucVu; }
            set { heSoChucVu = value; }
        }
        public string PhongBan
        {
            get { return phongBan; }
            set { phongBan = value; }
        }
        public CanBo() : base()
        {
            chucVu = "Truong phong";
            heSoChucVu = 5.0;
            phongBan = "Hanh chinh";
        }
        public CanBo(string maNV, string tenNV, double heSo, string chucVu, double heSoChucVu) : base(maNV,tenNV,DateTime.Today.Year,heSo,1)
        {
            ChucVu = chucVu;
            PhongBan = "Hanh chinh";
            HeSoChucVu = heSoChucVu;
        }
        public CanBo(string maNV, string tenNV, int namVaoLam, double heSo, int soNgayNghi, string chucVu, double heSoChucVu, string phongBan) 
            : base(maNV, tenNV, namVaoLam, heSo, soNgayNghi)
        {
            ChucVu = chucVu;
            HeSoChucVu = heSoChucVu;
            PhongBan = phongBan;
        }
        public override char XepLoai()
        {
            return 'A';
        }
        public double TinhPhuCapLanhDao()
        {
            return HeSoChucVu * LuongCoBan;
        }
        public override double TinhLuong()
        {
            return base.TinhLuong() + TinhPhuCapLanhDao();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Chuc vu: {0}, He so chuc vu: {1}, Phong ban: {2}", ChucVu, HeSoChucVu, PhongBan);
        }
    }
}
