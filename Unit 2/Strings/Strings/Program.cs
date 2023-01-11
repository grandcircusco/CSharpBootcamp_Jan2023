string word1 = "Hello";
string word2 = "Hi";

//combine strings
string word3 = word1 + word2;
string word4 = string.Concat(word1, word2);

Console.WriteLine(word3);
Console.WriteLine(word4);

//Comparing strings
Console.WriteLine(word3 == word4);
Console.WriteLine(word3.Contains("ello")); //Searches string for supplied smaller string
Console.WriteLine(String.Compare(word1, "hello", true)); //the true tells it to ignore casing

//Useful methods
//Finds location of given string
string value = "Character";
Console.WriteLine(value.IndexOf("a"));
//Or last location
Console.WriteLine(value.LastIndexOf("a"));

//Does string end with specific suffix
string id = "4234658AB";
string id2 = "4537579AC";
Console.WriteLine(id.EndsWith("AB"));
Console.WriteLine(id2.EndsWith("AB"));

//Replace old character with new character
string stringInDb = "Return_books_by_Jan_15";
string result = stringInDb.Replace('_', ' ');
//string result = stringInDb.Replace("books", "dvds");
//string result = stringInDb.Replace("_", ":)").Replace("books","movies");
Console.WriteLine(result);

//Split string into array
//Leave empty to split every char, or supply a string and split when it finds it
string[] words = stringInDb.Split("_");

foreach(string w in words)
{
    Console.WriteLine(w);
}

//combine string array into 1 string
string combined = String.Join(" ",words);
Console.WriteLine(combined);

//allows you to cut the word based on 0 based index
string word = "Riptide";
//cut first letter off
Console.WriteLine(word.Substring(1));
//only give last letter
Console.WriteLine(word.Substring(word.Length - 1));
//Returns first letter
//Substring(starting Index, length of returned string)
Console.WriteLine(word.Substring(0,1));

//Uppercase/Lowercase
string x = "apple";
string y = "APPLE";

Console.WriteLine(x == y);
Console.WriteLine(x.ToLower() == y.ToLower());
Console.WriteLine(x.ToUpper() == y.ToUpper());

//Trim, Remove extra spaces ON OUTSIDE OF WORDS
string messy = "              JusTIN                             ";
Console.WriteLine(messy);
Console.WriteLine(messy.Trim());
string example = "   x   x   ";
Console.WriteLine(example);
Console.WriteLine(example.Trim());

//Ultimate combo
Console.WriteLine(messy.Trim().ToLower());


//Allison First letter challenge
//string cleaned = Console.ReadLine().Trim().ToLower();
//string normalCasing = cleaned.Substring(0,1).ToUpper() + cleaned.Substring(1);
Console.WriteLine(FixUserInput());

//Secret Sneak peak. Dont look
static string FixUserInput()
{
    string cleaned = Console.ReadLine().Trim().ToLower();
    string normalCasing = cleaned.Substring(0, 1).ToUpper() + cleaned.Substring(1);
    return normalCasing;
}