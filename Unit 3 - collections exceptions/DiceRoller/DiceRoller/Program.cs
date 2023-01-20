//This tests all dice combos. Uncomment to test
//Tester();

Console.WriteLine("Welcome to the dice roller.");

//getting user input
Console.WriteLine("Please enter how many sides the dice will have.");
int sides = -1;

while(sides <= 0)//Range check
{
    while (int.TryParse(Console.ReadLine(), out sides) == false)//validate input
    {
        Console.WriteLine("Invalid input");
    }
    if(sides <= 0)
    {
        Console.WriteLine("Number too low.");
    }
}

//Rerolling Dice
bool RollingDice = true;
while (RollingDice)
{
    //Random numbers
    int r1 = getRandom(sides);
    int r2 = getRandom(sides);
    int total = r1 + r2;

    //Display
    Console.WriteLine($"Dice 1: {r1}\nDice 2: {r2}\nTotal: {total}");
    if (sides == 6)
    {
        Console.WriteLine(getCombos(r1, r2));
        Console.WriteLine(getTotals(total));
    }
    else if(sides == 20)
    {
        Console.WriteLine(getDNDCombos(r1,r2));
    }

    //Ask to roll again
    while (true)
    {
        Console.WriteLine("Do you want to roll again? y/n");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "y")
        {
            RollingDice = true;
            break;
        }
        else if (choice == "n")
        {
            RollingDice = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
    
}




//Methods
static int getRandom(int s)
{
    Random random = new Random();
    return random.Next(1, s + 1);//should be 1 - sides
}

static string getCombos(int d1, int d2)
{
    if(d1 == 1 && d2 == 1)
    {
        return "Snake Eyes";
    }
    else if((d1 == 1 && d2 == 2) || (d1 == 2 && d2 == 1))
    {
        return "Ace Deuce";
    }
    else if(d1 == 6 && d2 == 6)
    {
        return "Box Cars";
    }
    else //no match
    {
        return "";
    }
}

static string getTotals(int total)
{
    if(total == 7 || total == 11)
    {
        return "Win";
    }
    else if(total == 2 || total == 3 || total == 12)
    {
        return "Craps";
    }
    else
    {
        return "";
    }
}

static string getDNDCombos(int d1, int d2)
{
    if(d1 == 20 && d2 == 20)//both 20s
    {
        return "Super Crit";
    }
    else if(d1 == 20 || d2 == 20)//at least 1 20
    {
        return "Crit";
    }
    else if(d1 == 1 && d2 == 1)
    {
        return "Super Failure";
    }
    else if(d1 ==1 || d2==1)
    {
        return "Failure";
    }
    else
    {
        return "";
    }
}

static void Tester()
{
    Console.WriteLine(getCombos(1,1)); //snake eyes
    Console.WriteLine(getCombos(1,2)); //Ace Deuce
    Console.WriteLine(getCombos(2, 1)); //Ace Deuce
    Console.WriteLine(getCombos(6,6)); //box cars
    Console.WriteLine(getTotals(7)); //win
    Console.WriteLine(getTotals(11)); //win
    Console.WriteLine(getTotals(2)); //craps
    Console.WriteLine(getTotals(3)); //craps
    Console.WriteLine(getTotals(12)); //craps
    //DND
    Console.WriteLine(getDNDCombos(20,20));//Super crit
    Console.WriteLine(getDNDCombos(20,5));//crit
    Console.WriteLine(getDNDCombos(5,20));//crit
    Console.WriteLine(getDNDCombos(1,1));//super fail
    Console.WriteLine(getDNDCombos(1,5));//fail
    Console.WriteLine(getDNDCombos(5,1));//fail
}