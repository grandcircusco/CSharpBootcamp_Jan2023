Console.WriteLine("Welcome to Pig Latin Translator!");

//Loop program
bool runProgram = true;
while (runProgram)
{
    //getting the word
    string input = "";
    while (input == "")
    {
        Console.WriteLine("Please enter a word.");
        input = Console.ReadLine();
    }

    string[] words = input.Split(" ");
    string sentence = "";
    foreach (string w in words)
    {
        //Translating
        //vowel
        string firstLetter = w.Substring(0, 1).ToLower();


        string result = "";
        if (ContainsSymbolsNumbers(w))
        {
            result = w;
        }
        //if (firstLetter == "a" || firstLetter == "e" || firstLetter == "i" || firstLetter == "o" || firstLetter == "u")
        else if (IsVowel(firstLetter))
        {
            result = w + "way";
        }
        //cons
        else
        {
            int vowelLocation = 0;
            for (int i = 0; i < w.Length; i++)
            {
                string currentLetter = w.Substring(i, 1).ToLower();
                if (IsVowel(currentLetter))
                {
                    vowelLocation = i; //save vowel's index
                    break;
                }
            }

            //resamble word
            result = w.Substring(vowelLocation) + w.Substring(0, vowelLocation) + "ay";
        }

        sentence += result + " ";
    }


    

    //Display result
    Console.WriteLine(sentence);

    //ask if end
    while (true)
    {
        Console.WriteLine("Would you like to translate another word? y/n");
        string choice = Console.ReadLine().ToLower();
        if (choice == "y")
        {
            runProgram = true;
            break;
        }
        else if (choice == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
    
}




//Methods
static bool IsVowel(string letter)
{
    string vowels = "aeiou";
    return vowels.Contains(letter);
}

static bool ContainsSymbolsNumbers(string x)
{
    string symbols = "@#$%^&*()-_/*-+[]{};:<>\\|";
    string numbers = "0123456789";

    for (int i = 0; i < x.Length; i++)
    {
        string letter = x.Substring(i, 1);
        if(symbols.Contains(letter) || numbers.Contains(letter))
        {
            return true;
        }
    }
    return false;
}