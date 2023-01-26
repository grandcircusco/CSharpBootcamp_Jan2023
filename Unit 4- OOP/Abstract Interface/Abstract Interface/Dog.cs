using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    internal class Dog : Animal
    {
        public string size { get; set; }
        public bool GoodDog { get; set; }
        public Dog(string _name, int _weight, int _maxAge, string _size, bool _goodDog) : base(_name, _weight, _maxAge)
        {
            size = _size;
            GoodDog = _goodDog;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} devours some leftover chicken.");
        }

        public override void Move()
        {
            if(size == "small")
            {
                Console.WriteLine($"{Name} sneaks up on you and bites your leg.");
            }
            else if(size == "medium")
            {
                Console.WriteLine($"{Name} runs around the house straight into the wall.");
            }
            else if(size == "large")
            {
                Console.WriteLine($"{Name} walks up to your lap and falls asleep.");
            }
        }

        public override void Speak()
        {
            if (GoodDog)
            {
                Console.WriteLine("Bark once then lick you.");
            }
            else
            {
                Console.WriteLine("All dogs are good dogs.");
            }
        }
    }
}
