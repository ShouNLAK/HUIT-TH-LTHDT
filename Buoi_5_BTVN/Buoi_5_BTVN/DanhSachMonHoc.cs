using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Buoi_5_BTVN
{
    internal class DanhSachMonHoc
    {
        List<MonHoc> dsMonHoc;
        public DanhSachMonHoc()
        {
            dsMonHoc = new List<MonHoc>();
        }
        public List<MonHoc> DSMonHoc
        {  
            get { return dsMonHoc; } 
            set { dsMonHoc = value; }
        }

        public void Nhap_XML(string tenFile)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(tenFile);
            XmlNodeList nodeList = doc.SelectNodes("/Monhocs/MH");
            foreach (XmlNode node in nodeList)
            {
                string ma = node["Ma"].InnerText;
                string ten = node["Ten"].InnerText;
                int soTC = int.Parse(node["SoTC"].InnerText);
                string khoaQL = node["KhoaQL"].InnerText;
                if (node["Loai"].InnerText == "1")
                {
                    double dtl = double.Parse(node["DiemTL"].InnerText);
                    double dgk = double.Parse(node["DiemGK"].InnerText);
                    double dck = double.Parse(node["DiemCK"].InnerText);
                    DSMonHoc.Add(new MonLyThuyet(ma, ten, soTC, khoaQL, dtl, dgk, dck));
                }
                else if (node["Loai"].InnerText == "2")
                {
                    double d1 = double.Parse(node["DiemLan1"].InnerText);
                    double d2 = double.Parse(node["DiemLan2"].InnerText);
                    double d3 = double.Parse(node["DiemLan3"].InnerText);
                    double d4 = double.Parse(node["DiemLan4"].InnerText);
                    DSMonHoc.Add(new MonThucHanh(ma, ten, soTC, khoaQL, d1, d2, d3, d4));
                }
                else if (node["Loai"].InnerText == "3")
                {
                    double diemhd = double.Parse(node["DiemGVHD"].InnerText);
                    double diempb = double.Parse(node["DiemGVPB"].InnerText);
                    DSMonHoc.Add(new MonDoAn(ma, ten, soTC, khoaQL, diemhd, diempb));
                }
                else
                    throw new Exception("Nhap sai loai mon hoc");
            }
        }

    }
}
