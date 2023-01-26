using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    //cannot create instance of it
    public abstract class Animal
    {
        //properties
        public string Name { get; set; }
        public int Weight { get; set; }
        public int MaxAge { get; set; }
        //constructor
        public Animal(string _name, int _weight, int _maxAge)
        {
            Name = _name;
            Weight = _weight;
            MaxAge = _maxAge;
        }

        //methods
        public abstract void Eat();
        public abstract void Move();
        public abstract void Speak();

        public string GetDetails()
        {
            return $"{Name} Weight: {Weight} Max Age: {MaxAge}";
        }
    }
}
