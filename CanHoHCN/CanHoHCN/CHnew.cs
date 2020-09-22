using System;
using System.Collections.Generic;
using System.Text;

namespace CanHoHCN
{
    class CHNew : CH
    {
        string HuongBC;
        public CHNew() : base()
        {
            HuongBC = "Huong Nam";
        }

        public string HuongBC1 { get => HuongBC; set => HuongBC = value; }

        public void nhapCHNew()
        {
            base.nhapch();
            Console.Write("nhap huong ban cong:"); 
            HuongBC = Console.ReadLine();
        }

        public void xuatCHNew()
        {
            base.xuatch();
            Console.WriteLine("\nhuong ban cong:" + HuongBC);
        }

    }
}
