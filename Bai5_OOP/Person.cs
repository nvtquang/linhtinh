using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_OOP
{
    internal class Person
    {
        public string hoten { get; set; }
        public string gioitinh { get; set; }
        public int namsinh { get; set; }

        public Person()
        {

        }
        public Person(string hoten, string gioitinh, int namsinh)
        {
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.namsinh = namsinh;
        }
        public virtual void Input()
        {
            Console.Write("Nhap ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap gioi tinh: ");
            gioitinh = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namsinh = int.Parse(Console.ReadLine());
        }
        public virtual void Output()
        {
            Console.Write("{0,-20}{0,-20}{0,-20}", hoten,gioitinh,namsinh);
        }
    }
}
