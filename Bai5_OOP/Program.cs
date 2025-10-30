using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CongNhan> list = new List<CongNhan>();
            int n;
            Console.Write("Nhap so cong nhan: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin cong nhan thu {0}:", i + 1);
                CongNhan cn = new CongNhan();
                cn.Input();
                list.Add(cn);
            }
            Console.WriteLine("==============Thong tin cong nhan=============");
            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}", "Ho Ten", "Gioi Tinh", "Nam Sinh", "Ten Cong Ty", "He So Luong", "Luong");
            foreach (CongNhan cn in list)
            {
                cn.Output();
            }
            Console.WriteLine("==============Thong tin cong nhan co luong cao nhat =============");
            Console.WriteLine("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}", "Ho Ten", "Gioi Tinh", "Nam Sinh", "Ten Cong Ty", "He So Luong", "Luong");
            double max = list[0].TinhLuong();
            for (int i = 0; i < list.Count; i++)
            {
                if (max < list[i].TinhLuong())
                {
                    max = list[i].TinhLuong();
                }
            }
            foreach (CongNhan cn in list)
            {
                if (cn.TinhLuong() == max)
                {
                    cn.Output();
                }
            }
            Console.ReadLine();
        }
    }
}
