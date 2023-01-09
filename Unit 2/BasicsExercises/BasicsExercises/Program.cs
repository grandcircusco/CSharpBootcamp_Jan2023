//Ex 1
Console.WriteLine("Enter some text:");
string value = Console.ReadLine();
Console.WriteLine(value);

//Ex 2
Console.WriteLine("Enter a number");
int num = int.Parse(Console.ReadLine());
num++;
Console.WriteLine(num);

//Ex 3
Console.WriteLine("Enter a number");
double num2 = double.Parse(Console.ReadLine());
num2 +=  0.5;
Console.WriteLine(num2);

//Ex 4
Console.WriteLine("Please enter a number");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter a second number");
double y = double.Parse(Console.ReadLine());
double z = x + y;
Console.WriteLine("The sum is " + z);
Console.WriteLine(z);

//Ex 5
Console.WriteLine("Please enter a number");
double value1 = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter a second number");
double value2 = double.Parse(Console.ReadLine());
Console.WriteLine("The product is " + value1 * value2);