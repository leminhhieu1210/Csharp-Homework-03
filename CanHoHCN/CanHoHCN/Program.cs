using System;

namespace CanHoHCN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            //CH[] h = new CH[200];
            string huongTk;
            bool kq = false;
            CHNew[] hn = new CHNew[200];

            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                hn[i] = new CHNew();
                hn[i].nhapCHNew();
            }

            for (int i = 0; i < n; i++)
            {

                hn[i].xuatCHNew();
            }

            //double max;
            //CH chmax = h[1];
            //max = h[1].Kichthuoc.tinhdt();
            //for (int i = 2; i <= n; i++)
            //{
            //    if (max < h[i].Kichthuoc.tinhdt())
            //    {
            //        max = h[i].Kichthuoc.tinhdt();
            //        chmax = h[i];
            //    }
            //}

            //Console.Write("\ncan ho co dien tich max:"); chmax.xuatch();



            Console.Write("Huong ban cong can tim: ");
            huongTk = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                if (string.Compare(huongTk, hn[i].HuongBC1) == 0)
                {
                    kq = true;
                    break;
                }
            }

            if (kq == false) Console.Write("Het can huong ", huongTk);
            else
            {
                Console.WriteLine("\nKQ tim:");
                for (int i = 0; i < n; i++)
                    if (string.Compare(huongTk, hn[i].HuongBC1) == 0)
                        hn[i].xuatCHNew();
            }

            Console.ReadKey();
        }
    }
}
