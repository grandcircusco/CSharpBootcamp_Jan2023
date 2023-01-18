// See https://aka.ms/new-console-template for more information
using System.Collections;

//Generics
//List
//Once a list is created and has values, it works just like an array
List<int> nums = new List<int>();
nums.Add(5);
nums.Add(10);
nums.Add(9);
nums.Add(11);
Console.WriteLine(nums[1]);
foreach(int i in nums)
{
    Console.WriteLine(i);
}
//List methods
nums.Remove(9);//takes in object
nums.RemoveAt(0);//takes in index
Console.WriteLine($"there are {nums.Count} elements");//.Count returns how many elements
foreach (int i in nums)
{
    Console.WriteLine(i);
}

//List with starting values
List<string> names = new List<string>()
{
    "Justin",
    "Josh",
    "Billy"
};


//Dictionary
//<key, value>
Dictionary<string, int> phonebook = new Dictionary<string, int>();
phonebook.Add("Purple Giraffe Real Estate", 0123456789);
phonebook.Add("Cuzzo’s Candy Shop", 1116543210);
phonebook.Add("Michaels Cat Cafe", 1223334444);

Console.WriteLine(phonebook["Purple Giraffe Real Estate"]);

foreach (KeyValuePair<string, int> kvp in phonebook)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

//Exercises
//47
List<string> ex47 = new List<string>();
while (true)
{
    Console.WriteLine("Enter text");
    string input = Console.ReadLine();
    ex47.Add(input);
    string result = "";
    foreach(string s in ex47)
    {
        result += s + " ";
    }
    Console.WriteLine(result);
    Console.WriteLine("do you want to continue? y/n");
    string choice = Console.ReadLine();
    if(choice == "n")
    {
        break;
    }
}

//48
List<int> ex48 = new List<int>();
while (true)
{
    Console.WriteLine("Please enter a number. (q to quit)");
    string input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    else
    {
        int result = int.Parse(input);
        ex48.Add(result);
    }
}
string finalMath = "";
foreach(int i in ex48)
{
    finalMath += i + "+";
}
finalMath = finalMath.Substring(0,finalMath.Length-1);
Console.WriteLine($"{finalMath}={ex48.Sum()}");

//51
Dictionary<string, string> translation = new Dictionary<string, string>();
translation.Add("hello", "hola");
translation.Add("food", "comida");
translation.Add("world", "mundo");
translation.Add("computer", "computadora");
translation.Add("exercise", "ejercicio");

Console.WriteLine("Enter a word in English:");
string english = Console.ReadLine();
string spanish = translation[english];

Console.WriteLine($"{english} in spanish is {spanish}");














//-------------------------------------------------------------------------------------------------
//NON GENERICS
//DO NOT USE OR JUSTIN WILL FIGHT YOU
//Arraylist
//ArrayList numbers = new ArrayList();
//numbers.Add(5);
//numbers.Add(10);
//numbers.Add("justin");
//numbers.Add(new ArrayList());
//foreach (var i in numbers)
//{
//    Console.WriteLine(i);
//}

////Hashtable
//Hashtable ht = new Hashtable();
//ht.Add("Earle's Pizza Palace", 1234567890);
//ht.Add("Belle's Noodle and Company", 0987654321);
//ht.Add("Justin's Taco Bell", 1112223333);
//ht.Add(true, "Josh's secret lab");

//Console.WriteLine(ht["Earle's Pizza Palace"]);