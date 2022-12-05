using Homework_7.task3;
using System.Diagnostics;

namespace Homework_7.task3
{
    public class Polaroid : TechniqueSize, IPrintable, IPhotable
    {
        private double numberOfPixelsInCamera;

        public Polaroid(int paperWidth, int paperHeight, double numberOfPixelsInCamera, string? modelName, decimal price)
        {
            this.paperWidth = paperWidth;
            this.paperHeight = paperHeight;
            this.numberOfPixelsInCamera = numberOfPixelsInCamera;
            this.modelName = modelName;
            this.price = price;
        }

        public override string Description()
        {
            return $"Price: {price}, model:{modelName}, number of pixels in camera: {numberOfPixelsInCamera}";
        }

        public void TakePhoto()
        {
            Console.WriteLine("Press black button at the top and photo is ready");
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }
    }
}
