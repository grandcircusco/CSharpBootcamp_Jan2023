using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Square : iShape
    {
        public void draw()
        {
            Console.WriteLine("You draw a square. All sides even.");
        }
    }
}
