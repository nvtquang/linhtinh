using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    internal class Truck : Vehicle
    {
        public int truckLoad { get; set; } 
        public Truck() : base()
        {
        }
        public Truck(string id, string maker, string model, int year, double price, int truckLoad) : base(id, maker, model, year, price)
        {
            this.truckLoad = truckLoad;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Tai trong: ");
            truckLoad = int.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0,-20}", truckLoad);
        }

    }
}
