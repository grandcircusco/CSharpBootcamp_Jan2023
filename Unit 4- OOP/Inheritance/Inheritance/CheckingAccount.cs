using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class CheckingAccount : BankAccount
    {
        //properties
        public decimal OverdraftFee { get; set; }
        //constructor
        public CheckingAccount(int _accountNumber, decimal _balance, string _customerName, string _customerAddress, decimal _overdraftFee)
            : base(_accountNumber, _balance, _customerName, _customerAddress) //Parents constructor
        { 
            OverdraftFee = _overdraftFee;//only assign new properties
        }
        //methods
        public override void Withdraw(decimal amount)
        {
            //base.Withdraw(amount); //base.Withdraw will call parents version of the method
            Balance -= amount;
            if(Balance < 0)
            {
                Balance -= OverdraftFee;
            }
        }
    }
}
