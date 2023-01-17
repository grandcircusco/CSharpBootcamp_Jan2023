//Creating arrays
int[] nums = new int[10]; //array of ints that can hold 10 ints
int classSize = 17;
string[] students = new string[classSize];//array of strings that is the size of the variable

int[] nums2 = { 10, 5, 6 }; //array of 3 hard coded ints
string sentence = "The cat in the hat";
string[] words = sentence.Split(" "); //array of strings returned by method

//accessing values
Console.WriteLine(nums2[0]);
Console.WriteLine(nums2[1]);
Console.WriteLine(nums2[2]);
//Console.WriteLine(nums2[3]);

//Once you pull the element out, it acts like a normal variable
int value = nums2[1] + nums2[2];
Console.WriteLine(value);

//Changing values
Console.WriteLine(nums[0]);
nums[0] = 9;
Console.WriteLine(nums[0]);

//displaying all elements
Console.WriteLine(nums); //displays object name
foreach (int n in nums)
{
    Console.WriteLine(n);
}

for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}

//Average price example
double[] prices = { 1.99, 2.50, 3, 0.75, 5, 1.25};
double total = 0;
foreach(double p in prices)
{
    total += p;
}
double avg = total / prices.Length;
Console.WriteLine(avg);
Console.WriteLine(prices.Average());

//Finding max value
double max = double.MinValue;//absolute lowest value

foreach (double p in prices)
{
    if(p > max)
    {
        max = p;
    }
}
Console.WriteLine(max);


Console.WriteLine(prices.Max());

//Find min value

double min = double.MaxValue;

foreach(double p in prices)
{
    if(p < min)
    {
        min = p;
    }
}

Console.WriteLine(min);
Console.WriteLine(prices.Min());

//Array methods
//Array.Sort(prices);
//Array.Reverse(prices);
//Array.Clear(prices,0,1);
//foreach(double p in prices)
//{
//    Console.WriteLine(p);
//}

//Make a copy
int[] original = { 1, 2, 3 };
//int[] copy = original; //copies memory location
int[] copy = new int[3]; //make a new array
original.CopyTo(copy,0); //copy all values over to it. Starting index 0
copy[0] = 9;
Console.WriteLine(original[0]);



//Multidimensional array
//rectangle array
int[,] rect = new int[5,10];
Console.WriteLine(rect[1,5]);

//jagged array
int[][] jag = new int[3][];
jag[0] = new int[5];
jag[1] = new int[2];
jag[2] = new int[10];
Console.WriteLine(jag[2][6]);


//EXERCISES
//31
int[] ex31 = { 2, 8, 0, 24, 51 };
Console.WriteLine("Please enter an index. 0-" + (ex31.Length - 1));
int index31 = int.Parse(Console.ReadLine());

Console.WriteLine(ex31[index31]);

//32
int[] ex32 = { 2, 8, 0, 24, 51 };

Console.WriteLine("Please enter a number");
int choice = int.Parse(Console.ReadLine());
int index32 = -1;
for(int i = 0; i < ex32.Length; i++)
{
    if(choice == ex32[i])
    {
        index32 = i;
    }
}
Console.WriteLine(index32);
Console.WriteLine(Array.IndexOf(ex32, choice));

//33
int[] ex33 = { 2, 8, 0, 24, 51 };
Console.WriteLine("Please enter an index. 0-" + (ex33.Length - 1));
int choice33 = int.Parse(Console.ReadLine());
Console.WriteLine("Current Value= " + ex33[choice33]);
Console.WriteLine("Please type a new value");
int value33 = int.Parse(Console.ReadLine());
ex33[choice33] = value33;
Console.WriteLine("Updated Value= " + ex33[choice33]);

//34
int[] ex34 = { 16,32,64,128,256 };
Console.WriteLine("half or double?");
string choice34 = Console.ReadLine();

for (int i = 0; i<ex34.Length; i++)
{
    if(choice34 == "half")
    {
        ex34[i] /= 2;
    }
    else if(choice34 == "double")
    {
        ex34[i] *= 2;
    }
}

foreach(int i in ex34)
{
    Console.WriteLine(i);
}

//35
string[] ex35 = { "cow", "elephant", "jaguar", "horse", "crow" };
Console.WriteLine("Please enter 2 indexes, seperated by a space"); // 1 5
string choice35 = Console.ReadLine();
string[] values35 = choice35.Split(" "); //{ "1","5"}
int i1 = int.Parse(values35[0]);//"1" -> 1
int i2 = int.Parse(values35[1]);//"5" -> 5
Console.WriteLine(ex35[i1]);//index 1 of ex35 = "elephant"
Console.WriteLine(ex35[i1].Substring(i2,1));//index 1 of ex35 = "elephant"/ index 5 of "elephant" = "a"


string[] names = { "Justin Jones", "Ethan Thomas", "Belle Baxley", "Allison Jones", "John Glandon", "Michael Blackburn", "Christopher Washington", "Earle Fox", "Joshua Carolin", "Mourad Alfadil", "Tee Sotomi", "Wilfredo Pacheco", "Jun Kim", "Jason Garrison", "Cam Dixon", "Josh Strathres" };
string[] towns = { "Columbus", "Urbana", "Haleiwa", "Grand Rapids", "Detroit", "Warren", "Detroit", "Saline", "Westland", "Detroit", "Chicago", "Canton", "Lubbock", "Chelsea", "South Lyon", "Oxford" };
string[] foods = { "Baja Blast", "Hot Wings", "french fries", "Pad Ke Mao", "Stir fry", "Anpan", "Egg roll", "Pizza", "Naleśniki", "Fried Rice", "Pasta", "Quesadilla", "noodles", "Chewing Tobacco", "Coney Dogs", "Pizza" };