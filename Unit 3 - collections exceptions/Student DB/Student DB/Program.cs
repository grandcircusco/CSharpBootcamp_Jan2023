string[] names = { "Justin Jones", "Ethan Thomas", "Belle Baxley", "Allison Jones", "John Glandon", "Michael Blackburn", "Christopher Washington", "Earle Fox", "Joshua Carolin", "Mourad Alfadil", "Tee Sotomi", "Wilfredo Pacheco", "Jun Kim", "Jason Garrison", "Cam Dixon", "Josh Strathres" };

string[] towns = { "Columbus", "Urbana", "Haleiwa", "Grand Rapids", "Detroit", "Warren", "Detroit", "Saline", "Westland", "Detroit", "Chicago", "Canton", "Lubbock", "Chelsea", "South Lyon", "Oxford" };

string[] foods = { "Baja Blast", "Hot Wings", "french fries", "Pad Ke Mao", "Stir fry", "Anpan", "Egg roll", "Pizza", "Naleśniki", "Fried Rice", "Pasta", "Quesadilla", "noodles", "Chewing Tobacco", "Coney Dogs", "Pizza" };

//program loop
bool runProgram = true;
while (runProgram)
{

    //getting index from user
    int index = -1;
    while (index <= 0 || index > names.Length) //continue until number is valid
    {
        Console.WriteLine($"Please choose a student. 1-{names.Length}, type the students name or type 'list' to see a list of students");
        string indexChoice = Console.ReadLine();
        if (indexChoice == "list")
        {
            //display all students
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {names[i]}");
            }
        }
        else if (names.Contains(indexChoice))
        {
            for(int i = 0; i < names.Length; i++)
            {
                if (names[i] == indexChoice)
                {
                    index = i + 1; //Adding one because loop requires it
                }
            }
        }
        else
        {
            index = int.Parse(indexChoice);
        }
            
    }
    index--; //set input to 0 based index

    //Printing name
    Console.WriteLine($"You picked {names[index]}");

    //Get Category
    while (true)
    {
        Console.WriteLine("Please enter a category. hometown/favorite food");
        string category = Console.ReadLine().ToLower().Trim();//food
        string hometown = "hometown";
        string favFood = "favorite food";
        //if (category == "hometown")
        if(hometown.Contains(category))
        {
            Console.WriteLine($"{names[index]}'s hometown is {towns[index]}.");
            break;
        }
        //else if (category == "favorite food")
        else if(favFood.Contains(category))
        {
            Console.WriteLine($"{names[index]}'s favorite food is {foods[index]}.");
            break;
        }
        else
        {
            Console.WriteLine($"{category} is not a category. Try again.");
        }
    }

    //Ask if continue
    while (true)
    {
        Console.WriteLine("Would you like to continue? y/n");
        string choice = Console.ReadLine();
        if(choice == "y")
        {
            runProgram = true;
            break;
        }
        else if(choice == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("That was not valid. Try again.");
        }
    }
}
