//Object without constructor
using Intro_To_OOP;

Pen myPen = new Pen();
myPen.Color = "Black";
myPen.Brand = "Bick";
myPen.InkType = "Ballpoint";
myPen.price = 0.50m;
myPen.length = 5.3m;

Pen myPen2 = new Pen()
{
    Brand = "Pilot",
    Color = "Blue",
    InkType = "Gel",
    price = 1.50m,
    length = 5
};
//Each instance retains its value
Console.WriteLine(myPen.Brand);
Console.WriteLine(myPen2.Brand);
Console.WriteLine(myPen.draw("Sun"));
Console.WriteLine(myPen2.draw("Cat"));

//Storing in collections
List<Pen> Pens = new List<Pen>();
Pens.Add(myPen);
Pens.Add(myPen2);
Pens.Add(new Pen()
{
    Brand= "Bick",
    Color = "Blue",
    InkType = "Ballpoint",
    price = 0.50m, 
    length = 5.3m
});

//foreach 
foreach (Pen p in Pens)
{
    Console.WriteLine($"{p.InkType} {p.Color} {p.Brand} ${p.price} {p.length} inches");
}

Console.WriteLine();
DisplayPen(myPen);

//methods
static void DisplayPen(Pen p)
{
    Console.WriteLine($"{p.InkType} {p.Color} {p.Brand} ${p.price} {p.length} inches");
}


//Creating Objects with Constructors
BankAccount bank = new BankAccount(200000);
Console.WriteLine(bank.Balance);
Console.WriteLine(bank.GetInterestRate());