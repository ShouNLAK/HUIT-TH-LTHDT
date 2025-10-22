using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Buoi_6_BTTL
{
    internal class DanhSachBDS
    {
        List<BatDongSan> dsBDS;
        public List<BatDongSan> DSBDS
        {
            get { return dsBDS; }
            set { dsBDS = value; }
        }
        public DanhSachBDS()
        {
            dsBDS = new List<BatDongSan>();
        }

        public void Nhap_XML(string tenFile)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(tenFile);
            XmlNodeList nodeLists = doc.SelectNodes("/BDSs/BDS");
            foreach (XmlNode node in nodeLists)
            {
                string ma = node["Ma"].InnerText;
                double cd = double.Parse(node["Dai"].InnerText);
                double cr = double.Parse(node["Rong"].InnerText);
                if (node["Loai"].InnerText == "1")
                    DSBDS.Add(new DatTrong(ma, cd, cr));
                else if (node["Loai"].InnerText == "2")
                {
                    int soLau = int.Parse(node["SoLau"].InnerText);
                    DSBDS.Add(new NhaO(ma, cd, cr, soLau));
                }
                else if (node["Loai"].InnerText == "3")
                {
                    double soSao = double.Parse(node["SoSao"].InnerText);
                    DSBDS.Add(new KhachSan(ma, cd, cr, soSao));
                }
                else if (node["Loai"].InnerText == "4")
                    DSBDS.Add(new BietThu(ma, cd, cr));
                else
                    throw new Exception("Sai dinh dang");
            }
        }

        public void Xuat()
        {
            Console.WriteLine("{0,-10} | {1,-10} | {2,-10} | {3,-10} | {4,-20}", "Ma so", "Chieu dai", "Chieu rong" , "Dien tich", "Gia tri");
            foreach (BatDongSan node in DSBDS)
            {
                node.Xuat();
                Console.WriteLine();
            }
        }
        public double TongGiaTriBDS()
        {
            return DSBDS.Sum(t => t.TinhGiaTri());
        }
        public double TongPhiKinhDoanhBDS()
        {
            List<KhachSan> x = DSBDS.OfType<KhachSan>().ToList();
            double a = x.Sum(t => t.PhiKinhDoanh());
            List<BietThu> y = DSBDS.OfType<BietThu>().ToList();
            a += y.Sum(t => t.PhiKinhDoanh());
            //double a = 0;
            //foreach (BatDongSan x in DSBDS)
            //{
            //    if (x is KhachSan )
            //    {
            //        KhachSan obj= (KhachSan)x;
            //        a += obj.PhiKinhDoanh();                   
            //    }
            //    else if(x is BietThu)
            //    {
            //        BietThu obj= (BietThu)x;
            //        a += obj.PhiKinhDoanh();
            //    }
            //}
            return a;
        }
    }
}
