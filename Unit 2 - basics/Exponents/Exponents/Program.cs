// See https://aka.ms/new-console-template for more information
Console.WriteLine("Learn your squares and cubes!");

//Program loop
bool runProgram = true;
while (runProgram)
{
    //getting number
    int value = -1;
    while (value <= 0 || value > 1290)
    {
        Console.WriteLine("Please enter a number. 1-1290");
        value = int.Parse(Console.ReadLine());
    }
    


    //Display the table
    //Console.WriteLine("Number\tSquared\tCubed");
    //Console.WriteLine("======\t=======\t======");
    Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", "Number", "Squared", "Cubed"));
    Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", "=====", "=====", "====="));

    for (int i = 1; i <= value; i++)
    {
        Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", i, SquareNumber(i), CubeNumber(i)));
        //Console.WriteLine($"{i}\t{SquareNumber(i)}\t{CubeNumber(i)}");
    }

    //End the loop
    while (true)
    {
        Console.WriteLine("Would you like to continue? y/n");
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



//Methods
static int SquareNumber(int x)
{
    return x * x;
}

static int CubeNumber(int x)
{
    return x * x * x;
}