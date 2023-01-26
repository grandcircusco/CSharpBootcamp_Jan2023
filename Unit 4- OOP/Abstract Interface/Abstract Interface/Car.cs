using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    public class Car
    {
        //Properties
        public string Type { get; set; }
        public int MaxSpeed { get; set; }
        public iTurbo Turbo { get; set; }

        //Constructor
        public Car(string _type, int _maxSpeed)
        {
            Type = _type;
            MaxSpeed = _maxSpeed;
        }

        //methods
        public void Drive()
        {
            Console.WriteLine($"{Type} drives at {MaxSpeed} mph");
            if (Turbo != null)
            {
                Turbo.UseTurbo(MaxSpeed);
            }
        }
    }
}
