using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_1
{
    internal class NhanVien
    {
        private string maSo;
        private string hoTen;
        private int ngayCong;

        public static int luongNgay = 200000;

        public string MaSo
        {
            get { return maSo; }
            set
            {
                if (value != null && !String.IsNullOrEmpty(value))
                    maSo = value;
                else
                    throw new Exception("Mã số không được để trống");
            }
        }

        public string HoTen
        {
            get { return hoTen; }
            set
            {
                if (value != null && !String.IsNullOrEmpty(value))
                    hoTen = value;
                else
                    throw new Exception("Họ Tên không được để trống");
            }
        }

        public int NgayCong
        { 
            get
            {
                return ngayCong;
            }
            set
            {
                if (value >= 0)
                    ngayCong = value;
                else
                    throw new Exception("Số ngày công phải lớn hơn hoặc bằng 0");
            }
        }

        public char XepLoai
        {
            get
            {
                if (ngayCong > 26)
                    return 'A';
                if (ngayCong >= 22)
                    return 'B';
                return 'C';
            }
        }

        public NhanVien ()
        {
            MaSo = "NV000";
            HoTen = "NULL";
            NgayCong = 0;
        }

        public NhanVien (string ms, string ht, int nc)
        {
            MaSo = ms;
            HoTen = ht;
            NgayCong = nc;
        }

        public NhanVien (NhanVien t)
        {
            MaSo = t.MaSo;
            HoTen = t.HoTen;
            NgayCong = t.NgayCong;
        }


        public int tinhLuongNV()
        {
            return luongNgay * ngayCong;
        }

        public double tinhThuongNV()
        {
            if (XepLoai == 'A')
                return tinhLuongNV() * 5 / 100;
            if (XepLoai == 'B')
                return tinhLuongNV() * 2 / 100;
            return 0;
        }

        public void NhapTTNV()
        {
            Console.WriteLine("Nhập mã số nhân viên : ");
            MaSo = Console.ReadLine();
            Console.WriteLine("Nhập họ tên nhân viên :");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhập số ngày công của nhân viên : ");
            NgayCong = Int32.Parse(Console.ReadLine());
        }

        public void XuatTTNV()
        {
           Console.WriteLine("Mã số nhân viên : {0} | Họ và tên : {1} | Số ngày công : {2} | Xếp loại : {3}\nTiền lương : {4} | Tiền thưởng : {5} | Tổng tiền : {6}\t",maSo, hoTen, ngayCong,XepLoai,tinhLuongNV(),tinhThuongNV(),tinhLuongNV() + tinhThuongNV());
        }
    }
}
