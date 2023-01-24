using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access
{
    public class Government
    {
        //properties
        public string Leader { get; set; }
        public List<string> employees { get; set; }
        //private prevents usuage from outside
        private List<string> SecretAgents { get; set; }

        //constructor
        public Government()
        {
            Leader = "Mourad";
            employees = new List<string>();
            employees.Add("Belle");
            employees.Add("Earle");
            SecretAgents = new List<string>();
            SecretAgents.Add("Ethan");
            SecretAgents.Add("Carissa");
        }

        //methods

        public void DisplayAllStaff()
        {
            Console.WriteLine($"Leader: {Leader}");
            foreach(string e in employees)
            {
                Console.WriteLine($"Employee: {e}");
            }
        }

        public bool IsSecretAgent(string name)
        {
            return SecretAgents.Contains(name);
        }
    }
}
