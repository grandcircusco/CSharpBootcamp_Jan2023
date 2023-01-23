using OOPExercise;

List<Employee> staff = new List<Employee>()
{
    new Employee("Josh Carolin", 200000m, "Management"),
    new Employee("Justin Jones", 15000m, "Cleaning"),
    //Management, Cleaning, HR, Development, Marketing
    new Employee("Allison Jones", 85000m, "Development"),
    new Employee("Belle Baxley", 200000m, "HR"),
    new Employee("Mourad Alfadil",75000m,"Development"),
    new Employee("Michael Blackburn", 68000m, "HR"),
    new Employee("Wilfredo Pacheco", 50000m, "Development"),
    new Employee("Chris Washington", 200000000m, "HR"),
    new Employee("Junyoung Kim", 30000m, "HR"),
    new Employee("John Glandon", 60000m, "Development"),
    new Employee("Josh Strathres", 100000m, "Development"),
    new Employee("Carissa Cammarata", 20000, "Marketing"),
    new Employee("Jason Garrison", 20000m, "HR"),
    new Employee ("Tee Sotomi",25000m,"HR"),
    new Employee("Earle Fox",80000m, "Development")
};

Console.WriteLine("Welcome to GC Co.");

//loop program
bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("Please choose an option");
    Console.WriteLine("1. View All");
    Console.WriteLine("2. View by Department");
    Console.WriteLine("3. View by Salary");
    Console.WriteLine("4. Add new Employee");
    Console.WriteLine("5. Quit");

    int choice = int.Parse(Console.ReadLine());

    
    if (choice == 1) //view all
    {
        foreach (Employee e in staff)
        {
            Console.WriteLine(e.GetDetails());
        }
    }
    else if (choice == 2)//view by department
    {
        Console.WriteLine("Which department would you like to view? Management, Cleaning, HR, Development, Marketing");
        string department = Console.ReadLine().ToLower().Trim();
        // staff.Where(s => s.Department.ToLower() == department)  Create a new array of people only in the department
        foreach (Employee e in staff.Where(s => s.Department.ToLower() == department))
        {
            Console.WriteLine(e.GetDetails());
        }
    }
    else if (choice == 3)//view by salary
    {
        Console.WriteLine("What is the minimum salary you would like to see?");
        decimal salaryMin = decimal.Parse(Console.ReadLine());
        foreach(Employee e in staff.Where(s => s.Salary >= salaryMin))
        {
            Console.WriteLine(e.GetDetails());
        }
    }
    else if (choice == 4)//add new
    {
        Console.WriteLine("What is the new Employees name?");
        string name = Console.ReadLine();

        Console.WriteLine("What is the new Employees salary?");
        decimal salary = decimal.Parse(Console.ReadLine());

        Console.WriteLine("What is the new Employees department?");
        string department = Console.ReadLine();

        staff.Add(new Employee(name, salary, department));
        Console.WriteLine($"{name} has been added");
    }
    else if (choice == 5)//quit
    {
        runProgram = false;
        Console.WriteLine("Goodbye!");
    }
}


