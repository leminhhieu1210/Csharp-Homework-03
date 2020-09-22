using System;
using System.Collections.Generic;
using System.Text;

namespace BVN1_2
{
    class ThueXe
    {
        private string hoten;
        private int gio, loai;

        public ThueXe()
        {
            hoten = "";
            gio = loai = 0;
        }

        static void check_error(string s, out int x, int a, int b)
        {
            while (true)
            {
                try
                {
                    Console.Write(s + ": ");
                    x = int.Parse(Console.ReadLine());
                    if (x < a || x > b)
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

            check_error("Loai xe (1. Xe du lich; 2. Xe tai)", out loai, 1, 2);
            check_error("Gio thue xe", out gio, 0, 999999);
        }

        public void xuat()
        {
            Console.WriteLine("\nHo ten: " + hoten);
            if (loai == 1) Console.WriteLine("Loai xe: Xe du lich");
            else Console.WriteLine("Loai xe: Xe tai");
            Console.WriteLine("Gio thue xe: {0} gio", gio);
        }

        public int tienThueXe()
        {
            if (gio == 0) return 0;
            if (loai == 1) return 250000 + 70000 * (gio - 1);
            return 220000 + 85000 * (gio - 1);
        }
    }
}
