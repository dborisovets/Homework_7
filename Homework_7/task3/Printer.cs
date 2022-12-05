using Homework_7.task3;
using System.Diagnostics;

namespace Homework_7.task3
{
    public class Printer : TechniqueSize, IPrintable
    {
        public Printer(string? modelName, decimal price, int paperWidth, int paperHeight)
        {
            this.modelName = modelName;
            this.price = price;
            this.paperWidth = paperWidth;
            this.paperHeight = paperHeight;
        }

        public override string Description()
        {
            return $"Price: {price}, model:{modelName}";
        }


        public void Print()
        {
            Console.WriteLine("Printing...");
        }
    }
}
