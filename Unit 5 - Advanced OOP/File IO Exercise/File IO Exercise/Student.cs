using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_Exercise
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        //Constructor
        public Student(string _name, int _age, int _grade)
        {
            Name = _name;
            Age = _age;
            Grade = _grade;
        }
    }
}
