using BVN1_0;
using System;

namespace BVN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            TuyenSinh[] ts = new TuyenSinh[100];

            Console.Write("Nhap so luong thi sinh: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                ts[i] = new TuyenSinh();
                ts[i].input();
            }

            int diemChuan;
            Console.Write("Nhap diem chuan: ");
            diemChuan = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\t\tDANH SACH THI SINH TRUNG TUYEN");
            for (int i = 0; i < n; ++i)
            {
                if (ts[i].tongDiem() >= diemChuan)
                {
                    ts[i].output();
                }
            }
        }
    }
}
