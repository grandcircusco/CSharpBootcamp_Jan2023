
using File_IO_Exercise;

//Leave this empty. Filled later
List<Student> students = new List<Student>();
string filePath = "../../../Students.txt";

//if file doesn't exist
if (File.Exists(filePath) == false)
{
    StreamWriter tempWriter = new StreamWriter(filePath);
    tempWriter.WriteLine("Justin Jones|25|12");
    tempWriter.WriteLine("Josh Carolin|3000|6");
    tempWriter.Close();
}



//Collecting all students in file
StreamReader reader = new StreamReader(filePath);

while (true)
{
    //Justin Jones|25|12
    string line = reader.ReadLine();
    if(line == null)//if line is empty
    {
        break;
    }
    else//if line is not empty
    {
        string[] parts = line.Split("|");
        //parts[0] Name
        //parts[1] Age
        //parts[2] Grade
        Student stu = new Student(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
        students.Add(stu);
    }
}

reader.Close();//Always close when done


//Display all
Console.WriteLine("Welcome, here are all the students");
foreach(Student s in students)
{
    Console.WriteLine($"{s.Name} Age: {s.Age} Grade: {s.Grade}");
}

Console.WriteLine();


//Create a new student
Console.WriteLine("Please add the new students name");
string name = Console.ReadLine();
Console.WriteLine("Please add the students age");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Please add the students grade");
int grade = int.Parse(Console.ReadLine());

Student newStudent = new Student(name, age, grade);
students.Add(newStudent);


//Adding it to the file
StreamWriter writer = new StreamWriter(filePath);//open
foreach(Student stu in students)
{
    //Justin Jones|25|12
    writer.WriteLine($"{stu.Name}|{stu.Age}|{stu.Grade}");
}
writer.Close();//always close