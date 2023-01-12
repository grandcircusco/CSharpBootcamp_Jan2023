Console.WriteLine("Welcome to the number Analyzer.");

//Get user name
Console.WriteLine("Please enter your name.");
string name = Console.ReadLine();

//Looping Program
bool runProgram = true;

while (runProgram)
{
    //Get user input
    int value = 0;
    while (value <= 0 || value > 100)
    {
        Console.WriteLine(name + ", please enter a number 1-100");
        value = int.Parse(Console.ReadLine());
    }

    //If the integer entered is odd and less than 60, print the number entered and “Odd and less than 60.”
    if (value % 2 == 1 && value < 60)
    {
        Console.WriteLine(name + " you got: " + value + " Odd and less than 60");
    }
    //If the integer entered is odd and greater than 60, print the number entered and “Odd and greater than 60.”
    else if (value % 2 == 1 && value > 60)
    {
        Console.WriteLine(name + " you got: " + value + " Odd and greater than 60");
    }
    //If the integer entered is even and in the inclusive range of 2 to 24, print “Even and less than 25.”
    else if (value % 2 == 0 && value >= 2 && value <= 24)
    {
        Console.WriteLine(name + " you got: " + "Even and less than 25.");
    }
    //If the integer entered is even and in the inclusive range of 26 to 60, print “Even and between 26 and 60 inclusive.”
    else if (value % 2 == 0 && value >= 26 && value <= 60)
    {
        Console.WriteLine(name + " you got: " + "Even and between 26 and 60 inclusive.");
    }
    //If the integer entered is even and greater than 60, print the number entered and “Even and greater than 60.”
    else if (value % 2 == 0 && value > 60)
    {
        Console.WriteLine(name + " you got: " + value + " Even and greater than 60.");
    }


    //ask if they want to continue
    while (true)
    {
        Console.WriteLine("Do you want to continue? y/n");
        string choice = Console.ReadLine().Trim().ToLower();

        if (choice == "y")
        {
            runProgram = true;
            break;
        }
        else if (choice == "n")
        {
            runProgram = false;
            break;
        }
    }

}





