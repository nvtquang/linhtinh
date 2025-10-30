using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    internal class Vehicle : IVehicle, IComparable
    {
        public string id { get; set; }
        public string maker { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public double price { get; set; }
        public Vehicle()
        {

        }
        public Vehicle(string id)
        {
            this.id = id;
        }
        public Vehicle(string id, string maker, string model, int year, double price)
        {
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
        }
        public virtual void Input()
        {
            Console.Write("Nhap ID: ");id = Console.ReadLine();
            Console.Write("Nhap Hang San Xuat: ");maker = Console.ReadLine();
            Console.Write("Nhap Model: ");model = Console.ReadLine();
            Console.Write("Nhap Nam San Xuat: ");year = int.Parse(Console.ReadLine());
            Console.Write("Nhap Gia: ");price = double.Parse(Console.ReadLine());
        }
        public virtual void Output()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Hang San Xuat : " + maker);
            Console.WriteLine("Model : " + model);
            Console.WriteLine("Nam San Xuat : " + year);
            Console.WriteLine("Gia : " + price);

        }
        public int CompareTo(object obj)
        {
            Vehicle v = (Vehicle)obj;
            return this.price.CompareTo(v.price);
        }
        public override string ToString()
        {
            var str = String.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}", id, maker, model, year, price);
            return str;
        }
        public override bool Equals(object obj)
        {
            Vehicle v = (Vehicle)obj;
            return this.id.Equals(v.id);
        }

       
    }
}
