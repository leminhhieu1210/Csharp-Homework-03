using System;

namespace BVN1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            ThueXe[] x = new ThueXe[100];

            Console.Write("Nhap so luong thong tin: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                x[i] = new ThueXe();
                x[i].nhap();
            }

            Console.WriteLine("\n\t\tDANH SACH THONG TIN THUE XE");
            for (int i = 0; i < n; ++i)
            {
                x[i].xuat();
                Console.WriteLine("Thanh tien: {0} VND", x[i].tienThueXe());
            }
        }
    }
}
