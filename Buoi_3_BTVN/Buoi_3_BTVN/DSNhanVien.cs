using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Buoi_3_BTVN
{
    internal class DSNhanVien
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
        public void nhap(string tenFile)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(tenFile);
            XmlNodeList nodeList = doc.SelectNodes("/DSNhanVien/NhanVien");
            foreach (XmlNode node in nodeList)
            {
                string MaNV = node.Attributes["MaNV"].Value;
                string TenNV = node["TenNV"].InnerText;
                string PhongBan = node["PhongBan"].InnerText;
                string ChucVu = node["ChucVu"].InnerText;
                double HeSoLuong = double.Parse(node["HeSoLuong"].InnerText);
                double ThamNienCT = double.Parse(node["ThamNienCT"].InnerText);
                int SoNgayLamViec = int.Parse(node["SoNgayLamViec"].InnerText);
                NhanVien nv = new NhanVien(MaNV, TenNV, PhongBan, ChucVu, HeSoLuong, ThamNienCT, SoNgayLamViec);
                DanhSachNV.Add(nv);
            }
        }
        public void xuat()
        {
            Console.WriteLine("{0,-8} {1,-20} {2,-15} {3,-12} {4,-10} {5,-12} {6,-15} {7,-10} {8,-12}",
                "MaNV", "TenNV", "PhongBan", "ChucVu", "HeSoLuong", "ThamNienCT", "SoNgayLamViec", "PhuCap", "Luong");
            foreach (NhanVien nv in DanhSachNV)
            {
                nv.xuat();
            }
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
            kq.DanhSachNV = dsNhanVien.Where(nv => (nv.SoNgayLamViec > soNgay) && (nv.ChucVu != "Lanh dao")).ToList();
            return kq;
        }
        public DSNhanVien sapXep_GiamDan_Luong()
        {
            DSNhanVien kq = new DSNhanVien();
            kq.DanhSachNV = dsNhanVien.OrderByDescending(t=>t.tinh_Luong()).ToList();
            return kq;
        }
        public DSNhanVien sapXep_GDTheoLuong_TDTheoTen()
        {
            DSNhanVien kq = new DSNhanVien();
            kq.DanhSachNV = dsNhanVien.OrderByDescending(t => t.tinh_Luong()).ThenBy(t=>t.TenNV).ToList();
            return kq;
        }
    }
}
