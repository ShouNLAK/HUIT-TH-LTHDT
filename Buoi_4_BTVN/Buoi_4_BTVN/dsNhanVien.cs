using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Buoi_4_BTVN
{
    internal class dsNhanVien
    {
        List<NhanVien> danhsachNhanVien;
        public dsNhanVien()
        {
            danhsachNhanVien = new List<NhanVien>();
        }
        public List<NhanVien> DSNV
        {
            get { return danhsachNhanVien; }
            set { danhsachNhanVien = value; }
        }
        public void Nhap_XML(string tenFile)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(tenFile);
            XmlNodeList nodelists = doc.SelectNodes("/DanhSach/NhanVien");
            foreach (XmlNode node in nodelists)
            {
                string hoTen = node["Ten"].InnerText;
                string maNV = node["Ma"].InnerText;
                double heSoLuong = double.Parse(node["HeSoLuong"].InnerText);
                if (node.Attributes["ChucVu"] != null)
                {
                    string chucVu = node.Attributes["ChucVu"].Value;
                    double thamNienQL = double.Parse(node["ThamNienQL"].InnerText);
                    DSNV.Add(new CBLanhDao(maNV, hoTen, heSoLuong, chucVu, thamNienQL));
                }
                else
                    DSNV.Add(new NhanVien(maNV, hoTen, heSoLuong));
            }
        }
        public void Xuat()
        {
            Console.WriteLine("{0,-6} | {1,-20} | {2,-12} | {3,-10} | {4,-10} | {5,-10} | {6,-15}", "Ma", "Ten", "H.s Luong", "Thu nhap", "Phu cap", "Tong thu nhap", "Chuc vu");
            foreach (NhanVien x in DSNV)
            {
                x.Xuat();
                Console.WriteLine();
            }
        }
    }
}
