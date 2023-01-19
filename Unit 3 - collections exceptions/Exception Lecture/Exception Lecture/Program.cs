////Try Catch
//using System.Text.RegularExpressions;

//double subtotal = 0;

//while (true)
//{
//    try //any code that can break goes into try
//    {
//        Console.WriteLine("Enter subtotal:");
//        subtotal = double.Parse(Console.ReadLine());
//        if (subtotal < 0)
//        {
//            throw new Exception("Total cannot be lower than 0");
//        }
//        else
//        {
//            break;//successful
//        }
//    }
//    catch (FormatException e)//Only runs if code breaks in try
//    {
//        Console.WriteLine("Error! Invalid number");
//    }
//    catch (Exception e)//Can have multiple. Exception catchs all
//    {
//        Console.WriteLine(e.Message);
//    }
//}

//Console.WriteLine($"Your total is: {subtotal}");

////TryParse
//Console.WriteLine("Please enter your age");
//string input = Console.ReadLine();
//int age = 0; //This value will be overwritten when successful
////TryParse(value to be parsed, where parsed number will go)
//if (int.TryParse(input, out age))
//{
//    Console.WriteLine($"Your age is {age}");
//}
//else
//{
//    Console.WriteLine("That was not valid");
//}

////TryParse example
//Console.WriteLine("Please type a number");

//int number = 0;
//while (int.TryParse(Console.ReadLine(), out number) == false)
//{
//    Console.WriteLine("Not a number. Try again");
//}

//Console.WriteLine(number);

////Regex
//if (Regex.IsMatch("555-1212", "^\\d\\d\\d-\\d\\d\\d\\d$"))
//{
//    Console.WriteLine("Valid Number");
//}
//else
//{
//    Console.WriteLine("Invalid");
//}


//Software demo
string[] names = { "Justin Jones", "Ethan Thomas", "Belle Baxley", "Allison Jones", "John Glandon", "Michael Blackburn", "Christopher Washington", "Earle Fox", "Joshua Carolin", "Mourad Alfadil", "Tee Sotomi", "Wilfredo Pacheco", "Jun Kim", "Jason Garrison", "Cam Dixon", "Josh Strathres" };
Console.WriteLine($"Please enter a student's number 0-{names.Length -1}");
int index = 0;
//validation loop
while (true)
{
    while (int.TryParse(Console.ReadLine(), out index) == false)
    {
        Console.WriteLine("Invalid");
    }
    if (index < 0 || index >= names.Length)
    {
        Console.WriteLine("Not a valid number"); 
    }
    else
    {
        Console.WriteLine(names[index]);
        break;
    }
}
