using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise
{
    public class Employee
    {
        //Properties
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        //Constructor
        public Employee(string _name, decimal _salary, string _department)
        {
            Name = _name;
            Salary = _salary;
            Department = _department;
        }
        public Employee()//default
        {
            Name = "Justin";
            Salary = 5;
            Department = "Head of the Back alley";
        }

        //methods
        public string GetDetails()
        {
            return $"{Name} Department:{Department} Salary: ${Salary}";
        }

        
    }
}
