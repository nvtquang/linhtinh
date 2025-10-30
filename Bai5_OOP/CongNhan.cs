using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_OOP
{
    internal class CongNhan : Person
    {
        public string tencongty { get; set; }
        public double hesoluong { get; set; }
        public CongNhan() : base()
        {
            tencongty = "";
            hesoluong = 0;
        }
        public CongNhan(string hoten, string gioitinh, int namsinh, string tencongty, double hesoluong) : base(hoten, gioitinh, namsinh)
        {
            this.tencongty = tencongty;
            this.hesoluong = hesoluong;
        }
        public double TinhLuong()
        {
            return hesoluong * 850000;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap ten cong ty: ");
            tencongty = Console.ReadLine();
            Console.Write("Nhap he so luong: ");
            hesoluong = double.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", tencongty, hesoluong, TinhLuong());
        }
    }
}
