using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_To_OOP
{
    public class BankAccount
    {
        //properties
        public decimal Balance { get; set; }
        //Private prevents usage from outside
        private decimal InterestRate { get; set; }

        //Constructor
        public BankAccount(decimal _balance)
        {
            Balance = _balance;
            if(Balance >= 50000)
            {
                InterestRate = 0.1m;
            }
            else
            {
                InterestRate = 0.06m;
            }
        }

        //methods
        public decimal GetInterestRate()
        {
            return InterestRate;
        }

    }
}
