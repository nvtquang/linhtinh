using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    internal class Car : Vehicle
    {
        public string color { get; set; }
        public Car() : base()
        {
           
        }
        public Car(string id, string maker, string model, int year, double price, string color) : base(id, maker, model, year, price)
        {
            this.color = color;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Mau Xe: ");
            color = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0,-20}", color);
        }

    }
}
