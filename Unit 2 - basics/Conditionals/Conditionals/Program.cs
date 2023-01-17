//If examples

string name = "JUSTIN";
int age = 25;
bool isTired = false;
int petCount = 14;

//Comparing strings
if(name.ToLower() == "justin")
{
    Console.WriteLine("Hello Teacher.");
}
else if(name.ToLower() == "josh")
{
    Console.WriteLine("Hello Teaching Assistant.");
}
else if (name.ToLower() == "ethan")
{
    Console.WriteLine("Hello Owner.");
}
else
{
    Console.WriteLine("Get off my computer");
}

//comparing numbers
if(age >= 16)
{
    Console.WriteLine("You can drive.");
}

if(age >= 18)
{
    Console.WriteLine("You can vote.");
}

if(age >= 21)
{
    Console.WriteLine("You can drink.");
}


//comparing bools
if(isTired) //if(isTired == true)
{
    Console.WriteLine("Maybe don't go to bed at 1 am and wake up at 6 am");
}
else
{
    Console.WriteLine("Good job getting enough sleep. Too bad you missed real fun hours.");
}

//use an if statement to determine if you have the right amount of pets,
//a lot of pets, or way too many pets.

if(petCount <= 2)
{
    Console.WriteLine("Right amount of pets.");
}
else if (petCount <= 4)
{
    Console.WriteLine("A lot of pets.");
}
else
{
    Console.WriteLine("Buddy... That's way too many pets");
}

//combined expressions
if(age >= 25 && petCount >= 5) //&& is and. Both must equal true
{
    Console.WriteLine("Sorry, you are now a crazy cat person.");
}

if(age <= 18 || !isTired) // !isTired is the same as isTired == false
{
    Console.WriteLine("How do you have that much energy?");
}


//Switch 
int menuChoice = 5;

switch (menuChoice)
{
    case 1:
        Console.WriteLine("Connecting to HR. You are spot 9000 in the queue.");
        break;
    case 2:
        Console.WriteLine("Connecting to Refund team. You are spot 43678 in the queue.");
        break;
    case 3:
        Console.WriteLine("Connecting to Offices. You are spot 152341 in the queue.");
        break;
    //all other possibilites
    default:
        Console.WriteLine("Connecting to a real human. You are spot 2165465435468435546814981 in the queue.");
        break;
}

//Ternary
//result variable = condition ? true result : false result
string adultResult = age >= 18 ? "Adult" : "Child";
Console.WriteLine("You are a " + adultResult);

//-----------------------------------------------------------------------------------------
//LOOPS

//While

bool runWhile = true;

while (runWhile == true)
{
    //pretend this is the main code
    Console.WriteLine("While Loop running");

    //end of program
    Console.WriteLine("Do you wanna stop? y/n");
    string choice = Console.ReadLine();
    if (choice == "y")
    {
        runWhile = false;
    }
    //string choice = Console.ReadLine().ToLower();
    //runWhile = choice == "y" || choice == "yes" ? false : true;
}

//do while

bool runDoWhile = false;

do
{
    Console.WriteLine("This will always run at least once");
} while (runDoWhile == true);


//For loop
//for loop requires 3 steps
//1 creating your counter variable - int i = 1
//2 condtion - i <= 10
//3 what do you want to happen to your counter every loop - i++
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

//Create a for loop that starts at 10 and counts down to 1. Print the numbers to the console.
for(int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}

//Foreach
//This is an array
string[] students = { "Ethan", "Jason", "Earle", "Allison" };

foreach (string stu in students)
{
    Console.WriteLine(stu);
}

double[] prices = { 1.99, 2.50, 3.00, 1.25 };
double total = 0;
foreach(double p in prices)
{
    total += p;
}
Console.WriteLine(total);
Console.WriteLine(prices.Sum());

//BREAK
while (true)
{
    Console.WriteLine("Do you want to end the infinite loop? y/n");
    string choice = Console.ReadLine();
    if(choice == "y")
    {
        //Get you out of any loop early
        break;
    }
}
