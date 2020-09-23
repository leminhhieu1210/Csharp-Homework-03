using System;
using System.Collections.Generic;
using System.Text;

namespace BVN1_0
{
    class ThiSinh
    {
        private string sbd, ht;
        private double m1, m2, m3;

        public ThiSinh()
        {
            Sbd = Ht = "";
            M1 = M2 = M3 = 0;
        }

        public string Sbd { get => sbd; set => sbd = value; }
        public string Ht { get => ht; set => ht = value; }
        public double M1 { get => m1; set => m1 = value; }
        public double M2 { get => m2; set => m2 = value; }
        public double M3 { get => m3; set => m3 = value; }

        public void nhap()
        {
            Console.Write("SBD: ");
            Sbd = Console.ReadLine();

            Console.Write("Ho ten: ");
            Ht = Console.ReadLine();
                
            while(true)
            {
                try
                {
                    Console.Write("Diem mon 1: ");
                    M1 = double.Parse(Console.ReadLine());

                    if (M1 < 0 || M1 > 10)
                    {
                        Console.WriteLine("Diem khong hop le!");
                    }
                    else
                        break;
                }
                catch
                {
                    Console.WriteLine("Loi kieu du lieu!");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Diem mon 2: ");
                    M2 = double.Parse(Console.ReadLine());

                    if (M2 < 0 || M2 > 10)
                    {
                        Console.WriteLine("Diem khong hop le!");
                    }
                    else
                        break;
                }
                catch
                {
                    Console.WriteLine("Loi kieu du lieu!");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Diem mon 3: ");
                    M3 = double.Parse(Console.ReadLine());

                    if (M3 < 0 || M3 > 10)
                    {
                        Console.WriteLine("Diem khong hop le!");
                    }
                    else
                        break;
                }
                catch
                {
                    Console.WriteLine("Loi kieu du lieu!");
                }
            }
        }

        public double tinhTong()
        {
            return M1 + M2 + M3;
        }
    }
}
