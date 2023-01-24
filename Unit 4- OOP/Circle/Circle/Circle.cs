using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class CircleObj//Renamed class so c# can tell difference
    {
        //properties
        public double Radius { get; set; }
        //constructor
        public CircleObj(double _radius)
        {
            Radius = _radius;
        }

        //methods
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius,2);
        }

        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }

        private string FormatNumber(double x)
        {
            return Math.Round(x,2).ToString();
        }

    }
}
