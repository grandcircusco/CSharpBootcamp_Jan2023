// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//This is a comment
//Console.WriteLine("I am active");

/* Author: Justin Jones
  Date: 1/9/2023
   hfdskjalhdasfjklhdkajfslhbiuydfeasghiu
 */

//x is being declared
int x;
//x is being intialized
x = 10;

//combined
int y = 5;

//constant
const double TAXRATE = 0.06;
//TAXRATE = 1; cannot change a constant

//example

Console.WriteLine("Please enter a radius");
//string result = Console.ReadLine();
//double num = double.Parse(result);
double num = double.Parse(Console.ReadLine());
double area = num * num * Math.PI;
Console.WriteLine(area);

short z = short.Parse(Console.ReadLine());
//NULL
string myName = null;
Console.WriteLine(myName);
string friend = "Josh Carolin";

if(friend == "Family")
{
    myName = "Justin Jones";
}
else if (friend == "Josh Carolin")
{
    myName = "Jeo";
}
Console.WriteLine(myName);

