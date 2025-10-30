using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opt = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Vehicle> list = new List<Vehicle>();
            do
            {
                Console.WriteLine("============");
                Console.WriteLine("1. Nhap du lieu");
                Console.WriteLine("2. Hien thi du lieu");
                Console.WriteLine("3. Tim kiem theo id");
                Console.WriteLine("4. Tim kiem theo maker");
                Console.WriteLine("5. Sap xep theo price");
                Console.WriteLine("6. Thoat");
                Console.Write("Choice: "); opt = int.Parse(Console.ReadLine());

            } while (opt != 6);
        }
    }
}
