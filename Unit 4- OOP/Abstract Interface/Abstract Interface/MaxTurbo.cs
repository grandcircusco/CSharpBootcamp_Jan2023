using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    public class MaxTurbo : iTurbo
    {
        public void UseTurbo(int speed)
        {
            Console.WriteLine($"Turn on MAXTURBO and go {speed * 5} mph");
        }
    }

    public class BasicTurbo : iTurbo
    {
        public void UseTurbo(int speed)
        {
            Console.WriteLine($"Turn on basic turbo and go {speed * 2}");
        }
    }
}
