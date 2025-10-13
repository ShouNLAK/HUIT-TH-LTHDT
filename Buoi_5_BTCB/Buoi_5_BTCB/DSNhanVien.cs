using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Buoi_5_BTCB
{
    public class DSNhanVien
    {
        // Change from int to List<NhanVienABC>
        private List<NhanVienABC> lst_dsNhanVien;
        public List<NhanVienABC> Lst_dsNhanVien
        {
            get { return lst_dsNhanVien; }
            set { lst_dsNhanVien = value; }
        }

        public DSNhanVien()
        {
            lst_dsNhanVien = new List<NhanVienABC>();
        }

        public void DocDSNV_XML(string tenFile)
        {
            XmlDocument read = new XmlDocument();
            read.Load(tenFile);
            XmlNodeList nodeList = read.SelectNodes("/CongTy/NhanVien");
            foreach (XmlNode node in nodeList)
            {
                NhanVienABC nv;
                int loaiNV = int.Parse(node["Loai"].InnerText);
                string maNV = node["MaNhanVien"].InnerText;
                string tenNV = node["HoTen"].InnerText;
                int namSinh = int.Parse(node["NamSinh"].InnerText);
                string gioiTinh = node["GioiTinh"].InnerText;
                double heSoLuong = double.Parse(node["HeSoLuong"].InnerText);
                int namVaoLam = int.Parse(node["NamVaoLam"].InnerText);
                if (loaiNV == 1)
                {
                    int soNgayNghi = int.Parse(node["SoNgayNghi"].InnerText);
                    nv = new NhanVienSX(maNV, tenNV, namSinh, namVaoLam, gioiTinh, heSoLuong, soNgayNghi);
                }
                else if (loaiNV == 2)
                {
                    double dsThucTe = double.Parse(node["DSThucTe"].InnerText);
                    double dsToiThieu = double.Parse(node["DSToiThieu"].InnerText);
                    nv = new NhanVienKD(maNV, tenNV, namSinh, namVaoLam, gioiTinh, heSoLuong, dsThucTe, dsToiThieu);
                }
                else if (loaiNV == 3)
                {
                    string chucVu = node["ChucVu"].InnerText;
                    double heSoChucVu = double.Parse(node["HeSoChucVu"].InnerText);
                    nv = new CanBo(maNV, tenNV, namSinh, namVaoLam, gioiTinh, heSoLuong, chucVu, heSoChucVu);
                }
                else 
                    throw new Exception("Loai nhan vien khong hop le!"); 
                Lst_dsNhanVien.Add(nv);
            }
        }

        public double TinhTongThuNhapNV()
        {
            return Lst_dsNhanVien.Sum(nv => nv.TinhThuNhap());
        }

        public void XuatDSNV()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-8} | {1,-20} | {2,-5} | {3,-5} | {4,-5} | {5,-5} | {6,-28} | {7,-2} | {8,-10}", 
                "MaNV", "Ho Ten", "NSinh", "NVaoL", "GTinh", "HSLuong", "ThemThongTin", "XL", "ThuNhap");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            foreach (NhanVienABC nv in Lst_dsNhanVien)
            {
                if (nv is NhanVienSX)
                    ((NhanVienSX)nv).Xuat();
                else if (nv is NhanVienKD)
                    ((NhanVienKD)nv).Xuat();
                else if (nv is CanBo)
                    ((CanBo)nv).Xuat();
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
        }
    }
}