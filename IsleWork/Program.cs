using IsleWork;

int option = 0;
int employeeId = 1;
String FirstName = null;
String LastName = null;
String Email = null;
String Role = null;
if (option == 0)
{
    employeeId = employeeId++;
    Console.WriteLine("Please enter the first name of the employee.");
    FirstName = Console.ReadLine();
    Console.WriteLine("Please enter the last name of the employee.");
    LastName = Console.ReadLine();
    Console.WriteLine("Please enter the email of the employee.");
    Email = Console.ReadLine();
    
}
Employee employee = new Employee(employeeId, FirstName, LastName, Email, Role);

employee.Print();
