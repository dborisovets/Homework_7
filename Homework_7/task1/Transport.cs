using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7.task1
{
    public abstract class Transport
    {
        public string nameOfTransport;
        public string modelOfTransport;
        public int releaseDate;
        public int price;
        public abstract string Summary();

        public static void BuyTransport()
        {
            Console.WriteLine("Bought!");
        }

        public abstract double BuyModel(double sum);


    }
}
