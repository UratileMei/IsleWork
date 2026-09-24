using IsleWork;

int option = 1;
int employeeId = 1;
String FirstName = null;
String LastName = null;
String Email = null;
String Role = null;

Console.WriteLine("Welcome to Isle Work!" + "\nPlease enter a value");

while (option <= 7)
{
    
    if (option == 1)
    {
        Console.WriteLine("Please enter the first name of the employee.");
        FirstName = Console.ReadLine();
        Console.WriteLine("Please enter the last name of the employee.");
        LastName = Console.ReadLine();
        Console.WriteLine("Please enter the email of the employee.");
        Email = Console.ReadLine();
        employeeId++;
        
    }
    option = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("ID: " + employeeId);
}

Employee employee = new Employee(employeeId, FirstName, LastName, Email, Role);

employee.Print();
