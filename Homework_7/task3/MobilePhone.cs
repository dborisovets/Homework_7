using Homework_7.task3;
using System.Diagnostics;

namespace Homework_7.task3
{
    public class MobilePhone : Technique, IPhotable
    {
        private double numberOfPixelsInCamera;

        public MobilePhone(double numberOfPixelsInCamera, string? modelName, decimal price)
        {
            this.numberOfPixelsInCamera = numberOfPixelsInCamera;
            this.modelName = modelName;
            this.price = price;
        }

        public void TakePhoto()
        {
            Console.WriteLine("Press button on the screen and photo is ready");
        }

        public override string Description()
        {
            return $"Price: {price}, model:{modelName}, number of pixels in camera: {numberOfPixelsInCamera}";
        }
    }
}
