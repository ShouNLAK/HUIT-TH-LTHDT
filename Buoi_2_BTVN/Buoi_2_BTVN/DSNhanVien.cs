using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_2_BTVN
{
    public class DSNhanVien
    {
        List<NhanVien> dsNhanVien;
        public List<NhanVien> DanhSachNV
        {
            get { return dsNhanVien; }
            set { dsNhanVien = value; }
        }
        public DSNhanVien()
        {
            DanhSachNV = new List<NhanVien>();
        }
        public DSNhanVien(List<NhanVien> obj)
        {
            DanhSachNV = obj;
        }
        public void nhap()
        {
            Console.Write("Nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin nhan vien thu {0}:", i + 1);
                NhanVien x = new NhanVien();
                x.nhap();
                dsNhanVien.Add(x);
            }
        }
        public void xuat()
        {
            Console.WriteLine("MaNV\tTenNV\tPhongBan\tChucVu\tHeSoLuong\tThamNienCT\tSoNgayLamViec\tPhuCap\tLuong");
            foreach (NhanVien nv in DanhSachNV)
            {
                nv.xuat();
            }
        }
        public DSNhanVien sort_Theo_HSTD()
        {
            DSNhanVien kq = new DSNhanVien();
            kq.dsNhanVien = DanhSachNV.OrderByDescending(nv => nv.tinh_HeSoThiDua()).ToList();
            return kq;
        }
        public DSNhanVien loc_PhongBan_DieuKien(string phongBan)
        {
            DSNhanVien kq = new DSNhanVien();
            kq.dsNhanVien = DanhSachNV.Where(nv => nv.PhongBan == phongBan).ToList();
            return kq;
        }
        public DSNhanVien loc_LanhDao()
        {
            DSNhanVien kq = new DSNhanVien();
            kq.dsNhanVien = DanhSachNV.Where(nv => nv.ChucVu == "Lanh dao").ToList();
            return kq;
        }
        public double sumList()
        {
            return DanhSachNV.Sum(nv => nv.tinh_Luong());
        }
        public DSNhanVien delete_NV_NgayLamViecNhoHon(int soNgay)
        {
            DSNhanVien kq = new DSNhanVien();
            kq.dsNhanVien = DanhSachNV.Where(nv => nv.SoNgayLamViec >= soNgay).ToList();
            return kq;
        }
        public DSNhanVien loc_NV_CongHienHonSoNgay(int soNgay)
        {
            DSNhanVien kq = new DSNhanVien();
            kq.DanhSachNV = dsNhanVien.Where(nv => (nv.SoNgayLamViec > soNgay) && (nv.ChucVu != "Lãnh đạo")).ToList();
            return kq;
        }
        public DSNhanVien loc_theoHSL_PhongBan(double heSo, string phongBan)
        {
            DSNhanVien kq = new DSNhanVien();
            kq.DanhSachNV = dsNhanVien.Where(nv => (nv.HeSoLuong >= heSo) && (nv.PhongBan == phongBan)).ToList();
            return kq;
        }
    }
}
