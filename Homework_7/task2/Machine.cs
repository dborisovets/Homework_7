using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7.task2
{
    public class Machine : IMovable, ISound
    {
        public void Move()
        {
            Console.WriteLine("Machine is moving by wheels");
        }
        public void Sound()
        {
            Console.WriteLine("Machine is bee bee");
        }
    }

}
