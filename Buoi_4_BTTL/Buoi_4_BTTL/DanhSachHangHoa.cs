using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Buoi_4_BTTL
{
    internal class DanhSachHangHoa
    {
        List<HangHoa> dsHangHoa;
        public DanhSachHangHoa()
        {
            dsHangHoa = new List<HangHoa>();
        }
        public List<HangHoa> DSHangHoa
        {
            get { return dsHangHoa; }
            set { dsHangHoa = value; }
        }
        public void Nhap_XML(string tenFile)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(tenFile);
            XmlNodeList nodelists = doc.SelectNodes("/DanhSach/HangHoa");
            foreach (XmlNode node in nodelists)
            {
                string maHang = node["Ma"].InnerText;
                string tenHang = node["Ten"].InnerText;
                if (node.Attributes["Loai"] != null && node.Attributes["Loai"].Value.Equals("NGK"))
                {
                        string DVT = node["DVT"].InnerText;
                        int soLuong = int.Parse(node["SoLuong"].InnerText);
                        double donGia = double.Parse(node["DonGia"].InnerText);
                        DSHangHoa.Add(new NuocGiaiKhat(maHang, tenHang, DVT, soLuong, donGia));
                }
                else
                    DSHangHoa.Add(new HangHoa(maHang, tenHang));
            }
        }
        public void Xuat()
        {
            Console.WriteLine("{0,-8} | {1,-15} | {2,-8} | {3,-8} | {4,-10} | {5,-10}",
                "Ma hang", "Ten hang", "DV. Tinh", "So luong", "Don gia", "Tong tien");
            foreach (HangHoa x in DSHangHoa)
            {
                x.Xuat();
                Console.WriteLine();
            }
        }
    }
}
