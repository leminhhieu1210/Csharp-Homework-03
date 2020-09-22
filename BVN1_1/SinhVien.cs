using System;
using System.Collections.Generic;
using System.Text;

namespace BVN1_1
{
    class SinhVien
    {
        private string hoten;
        private int ngaySinh;
        private double lapTrinh, CSDL, web;

        public SinhVien()
        {
            hoten = "";
            ngaySinh = 0;
            lapTrinh = CSDL = web = 0;
        }

        public SinhVien(string hoten, int ngaySinh, double lapTrinh, double cSDL, double web)
        {
            this.hoten = hoten;
            this.ngaySinh = ngaySinh;
            this.lapTrinh = lapTrinh;
            CSDL = cSDL;
            this.web = web;
        }

        static void check_error(out double x, string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s + ": ");
                    x = double.Parse(Console.ReadLine());

                    if (x < 0 || x > 10)
                    {
                        Console.WriteLine(s + " khong hop le!");
                    }
                    else
                        break;
                }
                catch
                {
                    Console.WriteLine("Sai kieu du lieu!");
                }
            }
        }

        public void nhap()
        {
            Console.Write("Ho ten: ");
            hoten = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.Write("Ngay sinh: ");
                    ngaySinh = int.Parse(Console.ReadLine());

                    if (ngaySinh < 1 || ngaySinh > 31)
                    {
                        Console.WriteLine("Ngay sinh khong hop le!");
                    }
                    else
                        break;
                }
                catch
                {
                    Console.WriteLine("Sai kieu du lieu!");
                }
            }
            check_error(out lapTrinh, "Diem lap trinh");
            check_error(out CSDL, "Diem co so du lieu");
            check_error(out web, "Diem thiet ke web");
        }

        public void xuat()
        {
            Console.WriteLine("\nHo ten: " + hoten);
            Console.WriteLine("Ngay sinh: {0}", ngaySinh);
            Console.WriteLine("Diem lap trinh: {0}\t Diem CSDL: {1}\t Diem thiet ke web: {2}", lapTrinh, CSDL, web);
        }
        public double dieuKien()
        {
            if (lapTrinh < 5 || CSDL < 5 || web < 5) return -1;
            return (lapTrinh + CSDL + web) / 3;
        }
    }
}
