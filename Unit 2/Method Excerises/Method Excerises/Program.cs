using System.Security.Cryptography.X509Certificates;

static bool IsEnoughMoney(double cost, double payment)
{
    if(payment >= cost)
    {
        return true;
    }
    else 
    {
        return false;
    }
}

Console.WriteLine(IsEnoughMoney(15, 20));
Console.WriteLine(IsEnoughMoney(15, 10));

//60k or less, get an apartment
//80k or less, you can get a 1 br house
//100k or less, it will be a 2 br house
//anything greater will be a 3 br house
//pass in a double salary as a parameter
//return back a string with the house they can afford

static string getHouse(double salary)
{
    if(salary <= 60000)
    {
        return "Apartment";
    }
    else if(salary <= 80000)
    {
        return "1 br house";
    }
    else if(salary <= 100000)
    {
        return "2 br house";
    }
    else
    {
        return "3 br house";
    }
}

Console.WriteLine(getHouse(30000));
Console.WriteLine(getHouse(70000));
Console.WriteLine(getHouse(90000));
Console.WriteLine(getHouse(10000000));

static double GetAreaCircle(double radius)
{
    return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
}
Console.WriteLine(GetAreaCircle(5));

//Method name:CombineList
//Take in 3 different strings as parameters
//return a single string
//combine all 3 parameters into 1 string that is seperated by ,s
//apple orange banana => apple,orange,banana

static string CombineList(string x, string y, string z)
{
    //return x + "," + y + "," + z;
    return $"{x},{y},{z}";
}
Console.WriteLine(CombineList("apple", "orange", "banana"));

//Method name: JFinder
//take 1 string as a parameter
//return an int
//loop through each letter in the word and count how many j's appear

static int JFinder(string x)
{
    int counter = 0;
    foreach (char l in x.ToLower())
    {
        if(l == 'j')
        {
            counter++;
        }
    }

    return counter;
}

Console.WriteLine(JFinder("cajun"));
Console.WriteLine(JFinder("jumanji"));

//name: IsEvenDivisable
//take in 2 doubles as a parameter
//return back a bool
//returns true or false based on if the first double is divided evenly ( no remainder (%) ) by the second double parameter

static bool IsEvenDivisable(double x, double y)
{
    //if(x % y == 0)
    //{
    //    return true;
    //}
    //else
    //{
    //    return false;
    //}
    return x % y == 0;
}

Console.WriteLine(IsEvenDivisable(4,2));
Console.WriteLine(IsEvenDivisable(4,3));

//name: GetWordCount
//take in a string as a parameter (assume its a sentence) "He walked to the store"
//return back an int
//takes in a sentence as a string and returns the amount of words in that sentence
//hint: split string by spaces
static int GetWordCount(string sentence)
{
    return sentence.Split(" ").Length;
    //int counter = 0;
    //string[] words = sentence.Split(" ");
    //for(int i = 0; i < words.Length; i++)
    //{
    //    counter++;
    //}
    //return counter;

    //int counter = 0;
    //string[] words = sentence.Split(" ");
    //foreach(string w in words)
    //{
    //    counter++;
    //}
    //return counter;
}
Console.WriteLine(GetWordCount("He walked to the store"));


//UNRELATED MULTIPLE INPUTS
Console.WriteLine("Please enter 3 words, seperated by a ,");
string result = Console.ReadLine(); //apple,orange,banana
string[] words = result.Split(","); //[apple] [orange] [banana]
Console.WriteLine(words[0]);
Console.WriteLine(words[1]);
Console.WriteLine(words[2]);

foreach (string w in words)
{
    Console.WriteLine(w);
}