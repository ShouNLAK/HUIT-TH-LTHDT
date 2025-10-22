using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace De01_21_NguyenLeAnhKhoa_HuaTrongNhan
{
    internal class NhaXuatBan
    {
        private string tenNXB;
        private string diaChiNXB;

        List<GiaoTrinh> dsGT;
        public List<GiaoTrinh> DSGT
        {
            get { return dsGT; }
            set { dsGT = value; }
        }
        public string TenNXB
        {
            get { return tenNXB; }
            set { tenNXB = value; }
        }
        public string DiaChiNXB
        {
            get { return diaChiNXB; }
            set { diaChiNXB = value; }
        }

        public NhaXuatBan()
        {
            dsGT = new List<GiaoTrinh>();
        }
        public NhaXuatBan (NhaXuatBan obj)
        {
            dsGT = obj.dsGT;
        }

        public void nhap_DS_File(string tenFile)
        {
            XmlDocument Doc = new XmlDocument();
            Doc.Load(tenFile);
            TenNXB = Doc.SelectSingleNode("/NhaXuatBan/TenNXB").InnerText;
            DiaChiNXB = Doc.SelectSingleNode("/NhaXuatBan/DiaChiNXB").InnerText;
            XmlNodeList nodeList = Doc.SelectNodes("/NhaXuatBan/DanhSachGT/GiaoTrinh");
            foreach (XmlNode node in nodeList)
            {
                GiaoTrinh gt = new GiaoTrinh();
                gt.MaGT = node["MaGT"].InnerText;
                gt.TenGT = node["TenGT"].InnerText;
                gt.TenChuBien = node["ChuBien"].InnerText;
                gt.NamXB = int.Parse(node["NamXB"].InnerText);
                gt.SoLuongXB = int.Parse(node["SoLuongXB"].InnerText);
                gt.SoTrang = int.Parse(node["SoTrangIn"].InnerText);

                dsGT.Add(gt);
            }
        }
        public void xuat_DSGT()
        {
            Console.WriteLine("--- Thong tin nha xuat ban : {0} --- ",TenNXB);
            Console.WriteLine("--- Dia chi : {0} --- ",DiaChiNXB);
            Console.WriteLine("--- Danh sach giao trinh cua Nha Xuat Ban ---");
            Console.WriteLine("{0,-6} {1,-50} {2,-20} {3,-5} {4,-10} {5,-10} {6,-10}","Ma GT" , "Ten GT" , "Ten CB" , "Nam SX" ,"So Luong XB" , "So Trang", "Chi Phi");
            foreach (GiaoTrinh x in dsGT)
            {
                x.Xuat();
            }
        }

        public double tinh_TongChiPhi()
        {
            return dsGT.Sum(t => t.TinhChiPhi());
        }
        public NhaXuatBan sapXep_SoBanInTD_SoTrangInGD()
        {
            NhaXuatBan KQ = new NhaXuatBan();
            KQ.dsGT = dsGT.OrderBy(t=>t.SoLuongXB).ThenByDescending(t=>t.SoTrang).ToList();
            return KQ;
        }
        public GiaoTrinh max_ChiPhiGT()
        {
            double max = dsGT.Max(t => t.TinhChiPhi());
            return dsGT.First(t => t.TinhChiPhi() == max);
        }
    }
}
