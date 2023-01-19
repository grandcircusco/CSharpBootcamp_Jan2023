Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
menu.Add("Soft Taco", 1.69m);
menu.Add("Soft Taco Supreme", 2.49m);
menu.Add("Doritos Taco", 2.39m);
menu.Add("Mexican Pizza", 4.69m);
menu.Add("Chalupa", 3.99m);
menu.Add("Crunchwrap", 4.69m);
menu.Add("Gordita Crunch", 4.59m);
menu.Add("Quesarito", 4.49m);
menu.Add("Baja Blast", 2.29m);

List<string> cart = new List<string>();

Console.WriteLine("Welcome to your local 2.5 star taco bell");

Console.WriteLine();
//looping purchases
bool buying = true;
while (buying)
{
    //display menu
    int i = 0;
    foreach (KeyValuePair<string, decimal> kvp in menu.OrderByDescending(i => i.Value))
    {
        Console.WriteLine($"{i}.{kvp.Key}: ${kvp.Value}");
        i++;
    }

    Console.WriteLine();
    //Getting input from user
    Console.WriteLine("Please choose an item");
    string choice = Console.ReadLine();
    int index = -1;
    if (menu.ContainsKey(choice))
    {
        //item existing
        cart.Add(choice);
        Console.WriteLine($"{choice} was added to cart.");
    }
    //tryParse returns true/false. ALSO out keyword returns back the parsed number if successful
    else if (int.TryParse(choice, out index))
    {
        Console.WriteLine($"{menu.OrderByDescending(i => i.Value).ElementAt(index).Key} was added to cart.");
        cart.Add(menu.OrderByDescending(i => i.Value).ElementAt(index).Key);
    }
    else
    {
        //item doesn't exist
        Console.WriteLine($"{choice} is not on the menu.");
    }

    //Asking to buy more
    while (true)
    {
        Console.WriteLine("Would you like to buy another item? y/n");
        string continueChoice = Console.ReadLine();
        if (continueChoice == "y")
        {
            Console.Clear();
            buying = true;
            break;
        }
        else if (continueChoice == "n")
        {
            buying = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
   
}

//Display the receipt
Console.Clear();
Console.WriteLine("Thank you for ordering. Here is your receipt");
decimal total = 0m;
string maxItem = "";
decimal maxPrice = decimal.MinValue;
string minItem = "";
decimal minPrice = decimal.MaxValue;

foreach(string item in cart.OrderByDescending(i => menu[i]))
{
    Console.WriteLine($"{item} ${menu[item]}");
    total += menu[item];

    if (menu[item] > maxPrice)
    {
        maxPrice = menu[item];
        maxItem = item;
    }
    if (menu[item] < minPrice)
    {
        minPrice = menu[item];
        minItem = item;
    }
}
Console.WriteLine($"Total: ${total}");
Console.WriteLine($"Most expensive item: {maxItem}: ${maxPrice}");
Console.WriteLine($"Least expensive item: {minItem}: ${minPrice}");