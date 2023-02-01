using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class triangle : iShape
    {
        public void draw()
        {
            Console.WriteLine("You draw a triangle. It has 3 sides!");
        }
    }
}
