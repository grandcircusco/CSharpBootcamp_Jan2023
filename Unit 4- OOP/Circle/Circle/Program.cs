using Circle;

Console.WriteLine("Welcome to the Circle Calculator.");

//Counter
//int circles = 0;
List<CircleObj> allCircles = new List<CircleObj>();

//program loop
bool runProgram = true;
while (runProgram)
{
    //getting user input
    //Console.WriteLine("Please enter a number.");
    double input = Validator.GetNumberInRangeDouble(0);

    //Create circle object
    CircleObj myCircle = new CircleObj(input);
    //circles++;
    allCircles.Add(myCircle);

    Console.WriteLine($"Circumference: {myCircle.CalculateFormattedCircumference()}");
    Console.WriteLine($"Area: {myCircle.CalculateFormattedArea()}");

    //ask for continue
    runProgram = Validator.GetContinue("Would you like to make more circles?","Yes", "No");
    
}

//Console.WriteLine($"You created {circles} circles.");
Console.WriteLine($"You created {allCircles.Count} circles.");

foreach(CircleObj c in allCircles)
{
    Console.WriteLine($"Radius: {c.Radius} Area: {c.CalculateFormattedArea()} Circumference {c.CalculateFormattedCircumference()}");
}