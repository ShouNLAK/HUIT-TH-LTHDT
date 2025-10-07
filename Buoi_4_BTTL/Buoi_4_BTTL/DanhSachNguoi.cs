using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Buoi_4_BTTL
{
    internal class DanhSachNguoi
    {
        List<Nguoi> dsNguoi;
        public DanhSachNguoi()
        {
            dsNguoi = new List<Nguoi>();
        }
        public List<Nguoi> DSNguoi
        {
            get { return dsNguoi; }
            set { dsNguoi = value; }
        }
        public void Nhap_XML(string tenFile)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(tenFile);
            XmlNodeList nodelists = doc.SelectNodes("/DanhSach/Nguoi");
            foreach (XmlNode node in nodelists)
            {
                string hoTen = node["Ten"].InnerText;
                string ngaySinh = node["NgaySinh"].InnerText;
                string gioiTinh = node["Phai"].InnerText;
                if (node.Attributes["MSSV"] != null)
                {
                    string MSSV = node.Attributes["MSSV"].Value;
                    string HDT = node["HeDaoTao"].InnerText;
                    DSNguoi.Add(new SinhVien(hoTen, ngaySinh, gioiTinh, MSSV, HDT));
                }
                else
                    DSNguoi.Add(new Nguoi(hoTen, ngaySinh, gioiTinh));
            }
        }
        public void Xuat()
        {
            Console.WriteLine("{0,-20} | {1,-10} | {2,-5} | {3,-10} | {4,-15} | {5,-8} | {6,-10} | {7,-10}",
                "Ho va ten", "Ngay sinh", "Phai", "MSSV", "He dao tao", "Tong TC", "HP / TC", "Tong HP");
            foreach (Nguoi x in DSNguoi)
            {
                x.Xuat();
                Console.WriteLine();
            }
        }
    }
}
