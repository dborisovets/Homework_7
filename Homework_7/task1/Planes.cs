using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7.task1
{
    public class Planes : Transport
    {
        public bool isHelicopter;
        public int wingsNumber;

        public Planes(bool isHelicopter)
        {
            this.isHelicopter = isHelicopter;
        }
        public int Price { get; set; }

        public override double BuyModel(double sum)
        {
            throw new NotImplementedException();
        }

        public void ShowWingsNumber()
        {
            Console.WriteLine($"Doors number is {wingsNumber}");
        }

        public override string Summary()
        {
            throw new NotImplementedException();
        }
    }
}
