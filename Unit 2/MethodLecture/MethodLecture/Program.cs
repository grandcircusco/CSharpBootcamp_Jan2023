//Method

//string result = ReturnHelloUser("Justin");
//Console.WriteLine(result);

//Console.WriteLine(ReturnHelloUser("Justin"));
//Console.WriteLine(ReturnHelloUser("Bustin"));
//Console.WriteLine(ReturnHelloUser("Dustin"));
//Console.WriteLine(ReturnHelloUser("Rustin"));
//Console.WriteLine(ReturnHelloUser("Tustin"));
//Console.WriteLine(ReturnHelloUser("Mustin"));
//string name = GetCleanInput();
//Console.WriteLine(ReturnHelloUser(name));
//Console.WriteLine(ReturnHelloUser(GetCleanInput()));

//Console.WriteLine(AddThreeNumbers(5,7,9));

////no WriteLine or saving because this is void return
//DisplayDate();

static string ReturnHelloUser(string user)
{
    string greeting = $"Hello, {user}!";
    return greeting;
}


static double AddThreeNumbers(int x, int y, int z)
{
    return x + y + z;
}

//No parameter means it doesn't need values from outside
static string GetCleanInput()
{
    Console.WriteLine("Please enter a name.");
    return Console.ReadLine().Trim().ToLower();
}

static void DisplayDate()
{
    DateTime date = new DateTime(2024,5,3,23,1,4);
    Console.WriteLine(date);
}

//Exercises
//https://docs.google.com/document/d/1A6JR4ShWuldhc4YwsK27kYt53E44whEPcwStl20ZZuw/edit

static int convertMinuteToSeconds(int minutes)
{
    return minutes * 60;
}

Console.WriteLine(convertMinuteToSeconds(2));

static double areaTriangle(double height, double length)
{
    return (length * height) / 2;
}

Console.WriteLine(areaTriangle(10,5));

static int convertNegative(int x)
{
    if (x > 0)
    {
        return -x;
    }
    return x;
}

Console.WriteLine(convertNegative(5));
Console.WriteLine(convertNegative(0));
Console.WriteLine(convertNegative(-5));

static int convertPositive(int x)
{
    if (x < 0)
    {
        return -x;
    }
    return x;
}

Console.WriteLine(convertPositive(5));
Console.WriteLine(convertPositive(0));
Console.WriteLine(convertPositive(-5));

static void greetUser()
{
    Console.WriteLine("What is your name?");
    string n = Console.ReadLine();

    Console.WriteLine($"Hello {n}");
}

greetUser();


//Extra topics
//Pass by reference
//pass in whole variable instead of value

static void SwapNumbers(ref int x, ref int y)
{
    //store x to not lose it
    int temp = x;
    x = y;
    //use temp to get x's original value
    y = temp;
}

int num1 = 5;
int num2 = 9;

Console.WriteLine($"num1 before swap {num1}. num2 before swap {num2}");
SwapNumbers(ref num1, ref num2);
Console.WriteLine($"num1 after swap {num1}. num2 after swap {num2}");


//Getting random numbers
static int GetRandom()
{
    Random r = new Random();
    //return r.Next(6); //0-5
    return r.Next(1,7); //1-6
}

static int GetRandom2(int max)
{
    Random r = new Random();
    return r.Next(1, max + 1);
}



Console.WriteLine(GetRandom());
Console.WriteLine(GetRandom());
Console.WriteLine(GetRandom());
Console.WriteLine(GetRandom2(9000));
Console.WriteLine(GetRandom2(9000));
Console.WriteLine(GetRandom2(9000));
Console.WriteLine(GetRandom2(9000));
