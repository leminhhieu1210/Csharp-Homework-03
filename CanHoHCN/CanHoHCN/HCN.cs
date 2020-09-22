using System;
using System.Collections.Generic;
using System.Text;

namespace CanHoHCN
{
    class HCN
    {
        double cd, cr;

        public double Cd { get => cd; set => cd = value; }
        public double Cr { get => cr; set => cr = value; }

        public void nhap()
        {
            Cd = double.Parse(Console.ReadLine());
            Cr = double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("\tcd " + Cd.ToString("0.00") + "\tcr " + Cr.ToString("0.00"));
        }

        public double tinhdt()
        {
            return cd * cr;
        }
    }
}
