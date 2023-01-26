using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    public class Cat : Animal
    {
        public bool Angry { get; set; }
        public string Color { get; set; }
        public Cat(string _name, int _weight, int _maxAge, bool _angry, string _color) : base(_name, _weight, _maxAge)
        {
            Angry = _angry;
            Color = _color;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} walks up to a food bowl and eats.");
        }

        public override void Move()
        {
            Console.WriteLine($"You see a {Color} blob named {Name} run around.");
        }

        public override void Speak()
        {
            if (Angry)
            {
                Console.WriteLine($"{Name} yells at you.");
            }
            else
            {
                Console.WriteLine($"{Name} meows nicely");
            }
        }
    }
}
