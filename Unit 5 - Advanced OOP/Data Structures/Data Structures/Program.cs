Console.WriteLine("Welcome to string reverse. Please enter a value.");


string input = "";
while (true)
{
    input = Console.ReadLine();
    if (input.Any(c => Char.IsDigit(c) || Char.IsSymbol(c) ))
    {
        Console.WriteLine("Contains a number or symbol. Try again.");
    }
    else if(input == "")
    {
        Console.WriteLine("Nothing typed. Try again");
    }
    else
    {
        break;
    }
}
    


string sentence = "";

foreach (string word in input.Split(" "))
{
    sentence += Reverse(word) + " ";

}


//string output = Reverse(input);
Console.WriteLine(sentence);



//Methods
static string Reverse(string value)
{
    Stack<char> myStack = new Stack<char>();
    foreach (char c in value)
    {
        myStack.Push(c);
    }

    string result = "";
    for (int i = 0; i < value.Length; i++)
    {
        result += myStack.Pop();
    }

    //foreach (char c in myStack)
    //{
    //    result += c;
    //}

    //while (myStack.Count > 0)
    //{
    //    result += myStack.Pop();
    //}
    return result;
}