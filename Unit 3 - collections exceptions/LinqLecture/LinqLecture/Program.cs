List<int> numbers = new List<int>()
{
    19,21,25,20,30
};

//Count method
//returns how many match the condition
int adultCount = numbers.Count(age => age >= 21);
Console.WriteLine($"There are {adultCount} adults");

//any method
//return true or false for the condition
bool adultCheck = numbers.Any(age => age >=21);
Console.WriteLine($"Is there an adult here? {adultCheck}");
//is anyone in the group 65 or older?
bool seniorCheck = numbers.Any(age => age >= 65);
Console.WriteLine($"Is there a senior here? {seniorCheck}");


List<double> Clothes = new List<double>()
{
    75,100,250,300,90,100,350,90,100 
};

//Where method
//Create a collection based on condition
List<double> expensive = Clothes.Where(c => c >= 100).ToList();
foreach(double e in expensive)
{
    Console.WriteLine(e);
}
//Bring back all prices that are equal to 100
List<double> hundred = Clothes.Where(c => c == 100).ToList();
foreach (double e in hundred)
{
    Console.WriteLine(e);
}