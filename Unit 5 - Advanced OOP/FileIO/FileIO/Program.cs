string filepath = "../../../file1.txt";

//writing
StreamWriter writer = new StreamWriter(filepath);
writer.Write("Word ");
writer.WriteLine("word 2");
writer.WriteLine("Egg");
writer.Close();//When you finish, always close

//Read
StreamReader reader = new StreamReader(filepath);

while (true)
{
    string line = reader.ReadLine();
    if(line == null)//if line is empty, stop looking
    {
        break;
    }
    else
    {
        Console.WriteLine(line);
    }
}

reader.Close();