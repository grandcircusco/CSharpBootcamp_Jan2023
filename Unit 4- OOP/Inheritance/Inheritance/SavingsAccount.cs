using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }
        public SavingsAccount(int _accountNumber, decimal _balance, string _customerName, string _customerAddress, decimal _interestRate) 
            : base(_accountNumber, _balance, _customerName, _customerAddress)
        {
            InterestRate = _interestRate;
        }

        //methods
        public override void Withdraw(decimal amount)
        {
            //base.Withdraw(amount);
            if(Balance >= amount)
            {
                Balance -= amount;
            }
        }

        public override void Deposit(decimal amount)
        {
            //base.Deposit(amount);
            Balance += amount;
            Balance += Balance * InterestRate;
        }

    }
}
