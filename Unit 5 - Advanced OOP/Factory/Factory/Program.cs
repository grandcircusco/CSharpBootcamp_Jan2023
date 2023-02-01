using Factory;

Console.WriteLine("What shape would you like to draw?");
string choice = Console.ReadLine();
iShape result = ShapeFactory.getShape(choice);
result.draw();