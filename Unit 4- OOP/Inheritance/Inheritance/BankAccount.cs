using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BankAccount //Parent
    {
        //Properties
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        //Constructor
        public BankAccount(int _accountNumber, decimal _balance, string _customerName, string _customerAddress)
        {
            AccountNumber = _accountNumber;
            Balance = _balance;
            CustomerName = _customerName;
            CustomerAddress = _customerAddress;
        }
        //Methods
        //Virtual allows children to override the method
        public virtual void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        //Non virtual methods do not need to be overriden
        public decimal GetBalance()
        {
            return Balance;
        }
    }
}
