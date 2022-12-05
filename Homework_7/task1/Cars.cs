using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7.task1
{
    public class Cars : Transport
    {
        public bool IsNewCar;
        public int doorsNumber;

        public Cars(bool isNewCar, int price, int doorsNumber)
        {
            IsNewCar = isNewCar;
            Price = price;
            this.doorsNumber = doorsNumber;
        }

        public override string Summary()
        {
            return "";
        }

        public int Price { get; set; }

        public override double BuyModel(double sum)
        {
            if (IsNewCar)
            {
                return sum * 1.2;
            }
            else
            {
                return sum * 1.1;
            }
        }

        public void ShowDoorsNumber()
        {
            Console.WriteLine($"Doors number is {doorsNumber}");
        }

    }
}

