using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7.task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Machine machine = new Machine();

            dog.Eat();
            dog.Move();
            dog.Sound();

            machine.Sound();
            machine.Move();
        }
    }
}

