using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_1
{
    internal class KhoaHoc
    {
        private string maKH;
        private string tenKH;
        private int soBuoi;
        private string gioHoc;
        private int soLuongHV;
        private string tenGVGD;

        public static int hocPhi_BuoiHoc = 100;
        public static int thuLao_GiangVien = 500;

        public string MaKH
        {
            get { return maKH; }
            set
            {
                if (value.Length == 5 && value.StartsWith("KH") && (Int32.Parse(value.Substring(2, 1)) <= 3 
                        && Int32.Parse(value.Substring(2, 1)) >= 1) && value.Substring(3).All(char.IsDigit))
                    maKH = value;
                else
                    throw new Exception("Sai định dạng của mã Khóa học");
            }
        }
        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        public int SoBuoi
        {
            get { return  soBuoi; }
            set
            {
                if (value > 0)
                    soBuoi = value;
                else throw new Exception("Số buổi phải lớn hơn 0");
            }
        }
        public string GioHoc
        {
            get { return gioHoc; }
            set 
            {
                if (value == "2")
                    gioHoc = "2,4,6";
                if (value == "3")
                    gioHoc = "3,5,7";
                else
                    gioHoc = "7,CN";
            }
        }
        public int SoLuongHV
        {
            get { return soLuongHV; }
            set
            {
                if (value >= 10 && value <= 20)
                    soLuongHV = value;
                else throw new Exception("Số lượng học viên phải nhỏ hơn 10 và lớn hơn 20");
            }
        }
        public string TenGVGD 
        {
            get { return tenGVGD; }
            set { tenGVGD  = value; }
        }
        public KhoaHoc()
        {
            MaKH = "KH123";
            TenKH = "NULL";
            SoBuoi = 6;
            GioHoc = "2";
            SoLuongHV = 19;
        }
        public KhoaHoc(string MA, string TEN, int SOBUOI, string GIOHOC, int SLHV, string GVGD)
        {
            MaKH = MA;
            TenKH = TEN;
            SoBuoi = SOBUOI;
            GioHoc = GIOHOC;
            SoLuongHV = SLHV;
        }
        public KhoaHoc (KhoaHoc obj)
        {
            MaKH = obj.MaKH;
            TenKH = obj.TenKH;
            SoBuoi = obj.SoBuoi;
            GioHoc = obj.GioHoc;
            SoLuongHV = obj.SoLuongHV;
        }
        public double tinhHocPhiMotBuoi()
        {
            if (gioHoc == "7,CN")
                return hocPhi_BuoiHoc * 1.2;
            return hocPhi_BuoiHoc;
        }
        public double tinhHocPhi()
        {
            return soBuoi * tinhHocPhiMotBuoi();
        }
        public double tinhThuLaoMotBuoi()
        {
            if (soLuongHV >= 15)
                return thuLao_GiangVien + 10;
            return thuLao_GiangVien;
        }
        public double tinhThuLaoGV()
        {
            return soBuoi * tinhThuLaoMotBuoi();
        }
        public void nhap()
        {
            Console.WriteLine("Nhập mã khóa học : ");
            MaKH = Console.ReadLine();
            Console.WriteLine("Nhập tên khóa học : ");
            TenKH = Console.ReadLine();
            Console.WriteLine("Nhập số buổi : ");
            SoBuoi = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giờ học ( 1 - 2,4,6 | 2 - 3,5,7 | 3 - 7,CN ) : ");
            GioHoc = Console.ReadLine();
            Console.WriteLine("Nhập số lượng học viên : ");
            SoLuongHV = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tên giáo viên giảng dạy : ");
            TenGVGD = Console.ReadLine();
        }
        public void xuat()
        {
            Console.WriteLine("\t--- Thông tin khóa học : {0} ---\n" +
                "Mã khóa học : {0} | Tên khóa học : {1} | Số buổi : {2} |\n" +
                "Giờ học {3} | Số lượng học viên : {4} | Tên GV giảng dạy : {5} |\nHọc phí 1 buổi : {6} | Học phí khóa học : {7} | Thù lao 1 buổi : {8} | Thù lao giáo viên : {9}",
                maKH, tenKH, soBuoi, gioHoc, soLuongHV, tenGVGD, tinhHocPhiMotBuoi(),tinhHocPhi(),tinhThuLaoMotBuoi(),tinhThuLaoGV());
        }
    }
}
