using System;
using System.Collections.Generic;
using System.Text;

namespace BVN1_1
{
    class DanhSach
    {
        private int n;
        private SinhVien[] sv = new SinhVien[100];

        public DanhSach()
        {
            n = 0;
        }

        public void xuLy()
        {
            Console.Write("Nhap so luong sinh vien: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                sv[i] = new SinhVien();
                sv[i].nhap();
            }

            bool check = false;
            Console.WriteLine("\n\t\tDANH SACH SINH VIEN LAM KHOA LUAN TOT NGHIEP");
            for (int i = 0; i < n; ++i)
            {
                if (sv[i].dieuKien() >= 8)
                {
                    sv[i].xuat();
                    check = true;
                }
            }
            if (check == false) Console.WriteLine("Khong co sinh vien!");

            check = false;
            Console.WriteLine("\n\t\tDANH SACH SINH VIEN LAM CHUYEN DE TOT NGHIEP");
            for (int i = 0; i < n; ++i)
            {
                if (sv[i].dieuKien() != -1)
                {
                    sv[i].xuat();
                    check = true;
                }
            }
            if (check == false) Console.WriteLine("Khong co sinh vien!");
        }
    }
}
