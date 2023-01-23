using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_To_OOP
{
    public class Pen
    {
        //properties
        public string Brand { get; set; }
        public string Color { get; set; }
        public string InkType { get; set; }
        public decimal length { get; set; }
        public decimal price { get; set; }

        //Methods
        public string draw()
        {
            return $"The {Color} {Brand} pen drew a nice flower.";
        }

        //overloaded method
        public string draw(string drawing)
        {
            return $"The {Color} {Brand} pen drew a nice {drawing}.";
        }

    }
}
