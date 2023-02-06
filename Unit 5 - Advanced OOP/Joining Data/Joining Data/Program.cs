using Joining_Data;

List<Order> orders = new List<Order>()
{
    new Order("Acme Hardware", "Mouse", 25.00m, 3),
    new Order("Acme Hardware", "Keyboard", 45.00m, 2),
    new Order("Falls Realty", "Macbook", 800.00m, 2),
    new Order("Julie's Morning Diner", "iPad", 525.00m, 1),
    new Order("Julie's Morning Diner", "Credit Card Reader", 45.00m, 1),
};


//ex1
//List<Order> DistinctCustomers = orders.GroupBy(o => o.CustomerName).Select(o => o.First()).ToList();

//foreach (Order Customer in DistinctCustomers)
//{
//    Console.WriteLine(Customer.CustomerName);
//    List<Order> myOrders = orders.Where(o => o.CustomerName == Customer.CustomerName).ToList();
//    Console.WriteLine(String.Format("{0,20} {1,15} {2,15} {3,15}", "Item", "Price", "Quantity", "Total"));
//    foreach (Order o in myOrders)
//    {
//        Console.WriteLine(String.Format("{0,20} {1,15} {2,15} {3,15}", o.Item, o.Price, o.Quantity, o.Price * o.Quantity));
//    }
//    Console.WriteLine();
//}

//alt version

Dictionary<string, List<Order>> DistinctOrders = orders.GroupBy(o => o.CustomerName).ToDictionary(o => o.Key, o => o.ToList());

foreach (KeyValuePair<string, List<Order>> kvp in DistinctOrders)
{
    Console.WriteLine(kvp.Key);
    Console.WriteLine(String.Format("{0,20} {1,15} {2,15} {3,15}", "Item", "Price", "Quantity", "Total"));
    foreach(Order o in kvp.Value)
    {
        Console.WriteLine(String.Format("{0,20} {1,15} {2,15} {3,15}", o.Item, o.Price, o.Quantity, o.Price * o.Quantity));
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine();
Console.WriteLine();
//Ex2
foreach (KeyValuePair<string, List<Order>> kvp in DistinctOrders)
{
    Console.WriteLine(kvp.Key);
    Console.WriteLine(String.Format("{0,20} {1,15} {2,15} {3,15}", "Item", "Price", "Quantity", "Total"));
    //decimal total = 0.0m;
    foreach (Order o in kvp.Value)
    {
        Console.WriteLine(String.Format("{0,20} {1,15} {2,15} {3,15}", o.Item, o.Price, o.Quantity, o.Price * o.Quantity));
        //total += o.Price * o.Quantity;
    }
    //Console.WriteLine($"Total: {total}");
    Console.WriteLine($"Total: {kvp.Value.Sum(o => o.Quantity * o.Price)}");
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

//ex3
Console.WriteLine(String.Format("{0,20} {1,20} {2,15} {3,15} {4,15}", "Customer Name" ,"Item", "Price", "Quantity", "Total"));
foreach (KeyValuePair<string, List<Order>> kvp in DistinctOrders)
{
    bool DisplayedFirst = false;
    
    foreach (Order o in kvp.Value)
    {
        if(DisplayedFirst == false)
        {
            Console.WriteLine(String.Format("{0,25} {1,20} {2,15} {3,15} {4,15}", o.CustomerName, o.Item, o.Price, o.Quantity, o.Price * o.Quantity));
            DisplayedFirst = true;
        }
        else
        {
            Console.WriteLine(String.Format("{0,25} {1,20} {2,15} {3,15} {4,15}", "", o.Item, o.Price, o.Quantity, o.Price * o.Quantity));
        }
        
    }

}