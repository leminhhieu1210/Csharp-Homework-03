using System;
using System.Collections.Generic;
using System.Text;

namespace CanHoHCN
{
    class CH
    {
        int maphong;
        HCN kichthuoc;

        public HCN Kichthuoc { get => kichthuoc; set => kichthuoc = value; }

        public void nhapch()
        {
            maphong = int.Parse(Console.ReadLine());
            Kichthuoc = new HCN();
            Kichthuoc.nhap();
        }

        public void xuatch()
        {
            Console.Write("\nma phong:" + maphong.ToString());
            Kichthuoc.xuat(); 
            Console.Write("dien tich:" + Kichthuoc.tinhdt().ToString());
        }

    }
}
