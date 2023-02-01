using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ShapeFactory
    {
        public static iShape getShape(string choice)
        {
            if(choice == "square")
            {
                return new Square();
            }
            else if(choice == "circle")
            {
                return new Circle();
            }
            else if(choice == "triangle")
            {
                return new triangle();
            }
            else
            {
                return null;
            }
        }
    }
}
