using Inheritance;

BankAccount bank = new BankAccount(1,200m, "Justin", "123 GC Street");
bank.Withdraw(250m);
Console.WriteLine(bank.GetBalance());
Console.WriteLine(Audit(bank));

CheckingAccount check = new CheckingAccount(2, 200m, "Josh", "321 GC Street", 4000m);
check.Withdraw(250m);
Console.WriteLine(check.GetBalance());
Console.WriteLine(Audit(check));

SavingsAccount saving = new SavingsAccount(3, 200m, "Billy", "222 GC Street", 0.06m);
saving.Withdraw(250m);
Console.WriteLine(saving.GetBalance());
Console.WriteLine(Audit(saving));


//Polymorphism
List<BankAccount> accounts = new List<BankAccount>();
accounts.Add(bank);
accounts.Add(check);
accounts.Add(saving);

Console.WriteLine();
foreach (BankAccount acc in accounts)
{
    acc.Withdraw(10000);
    Console.WriteLine(acc.GetBalance());
}

//Methods
static bool Audit(BankAccount acc)
{
    if(acc.AccountNumber >= 1 && acc.GetBalance() >= 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}