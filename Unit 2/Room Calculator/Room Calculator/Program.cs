//Justin

Console.WriteLine("Welcome to the room calculator.");

//User input
Console.WriteLine("Please enter a length.");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter a width.");
double width = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter a height.");
double height = double.Parse(Console.ReadLine());

//Calculations
double area = length * width;
double perimeter = 2 * (length + width);
double volume = width * length * height;
double surfaceArea = 2*((width * length) + (height * length) + (height * width));

//Display
Console.WriteLine("Area: " + area);
Console.WriteLine("Perimeter: " + perimeter);
Console.WriteLine("Volume: " + volume);
Console.WriteLine("Surface Area: " + surfaceArea);

//Room size
if(area <= 250)
{
    Console.WriteLine("This room is small.");
}
else if(area > 250 && area < 650)
{
    Console.WriteLine("This room is medium.");
}
//both cover all other possibilities
//else if(area >= 650)
else
{
    Console.WriteLine("This room is large.");
}

