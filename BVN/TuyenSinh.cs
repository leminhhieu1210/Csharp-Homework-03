using System;
using System.Collections.Generic;
using System.Text;

namespace BVN1_0
{
    class TuyenSinh : ThiSinh
    {
        private int khuVuc;

        public TuyenSinh():base()
        {
            khuVuc = 1;
        }

        public void input()
        {
            base.nhap();
            
            while (true)
            {
                try
                {
                    Console.Write("Khu vuc (1, 2, 3): ");
                    khuVuc = int.Parse(Console.ReadLine());
                    if (khuVuc < 1 || khuVuc > 3)
                    {
                        Console.WriteLine("Khong co khu vuc {0}", khuVuc);
                    }
                    else break;
                }
                catch
                {
                    Console.WriteLine("Loi kieu du lieu!");
                }
            }
            
        }

        public void output()
        {
            Console.WriteLine("SBD: " + Sbd);
            Console.WriteLine("Ho ten: " + Ht);
            Console.WriteLine("Mon 1: {0}\t Mon 2: {1}\t Mon 3: {2}", M1, M2, M3);
            Console.WriteLine("Khu vuc: " + khuVuc.ToString());
        }

        public double tongDiem()
        {
            int diemKV;

            if (khuVuc == 1) diemKV = 0;
            else if (khuVuc == 2) diemKV = 1;
            else diemKV = 2;

            return base.tinhTong() + diemKV;
        }
    }
}
