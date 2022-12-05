using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7.task3
{
    public abstract class Technique
    {
        public string? modelName;
        public decimal price;

        public void TurnOn()
        {
            Console.WriteLine("Press button at the top");
        }

        public void TunrnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }
        public abstract string Description();
    }
}




