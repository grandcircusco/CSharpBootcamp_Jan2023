using EFLecture.Models;

CarDBContext dbContext = new CarDBContext();


Car c = new Car();
//Do not adjust id. EF will do that
Console.WriteLine("Car make:");
c.Make = Console.ReadLine();

Console.WriteLine("Car Model:");
c.Model = Console.ReadLine();

Console.WriteLine("Car Color:");
c.Color = Console.ReadLine();

//starting a transaction
dbContext.Cars.Add(c);

//Transactions wait to happen until save
dbContext.SaveChanges();




//Read from the DB
Console.WriteLine("All cars in DB");
foreach (Car car in dbContext.Cars)
{
    Console.WriteLine($"{car.Id}. {car.Make} {car.Model} {car.Color}");
}

//Use Linq With DB
List<Car> WhiteCars = dbContext.Cars.Where(c => c.Color == "White").ToList();
Console.WriteLine();
Console.WriteLine("All white cars:");
foreach(Car wc in WhiteCars)
{
    Console.WriteLine($"{wc.Make} {wc.Model} {wc.Color}");
}


//Delete
Console.WriteLine("What id would you like to buy?");
int input = int.Parse(Console.ReadLine());

Car purchased = dbContext.Cars.First(c => c.Id == input);
dbContext.Cars.Remove(purchased);//Started a transaction
dbContext.SaveChanges();//Finishing transaction

Console.WriteLine($"You bought a {purchased.Make} {purchased.Model} {purchased.Color} And drove it off.");



//addMovies();

static void addMovies()
{
    //starting a transaction
    dbContext.Cars.Add(c);

    //Transactions wait to happen until save
    dbContext.SaveChanges();
}