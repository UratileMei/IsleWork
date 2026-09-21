using IsleWork;
int id = 1;
String FirstName = null;
String LastName = null;
String Email = null;
String Role = null;
Console.WriteLine($"Please enter the first name of the employee.");
FirstName = Console.ReadLine();
Console.WriteLine($"Please enter the last name of the employee.");
LastName = Console.ReadLine();
Console.WriteLine($"Please enter the email of the employee.");
Email = Console.ReadLine();
Employee employee = new Employee(id, FirstName, LastName, Email, Role);



employee.Print();
