using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7.task2
{
    public class Dog : Animals, IMovable, ISound
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is eating!");
        }

        public void Move()
        {
            Console.WriteLine("Dog is moving by legs");
        }

        public void Sound()
        {
            Console.WriteLine("Dog is barking");
        }
    }

}
