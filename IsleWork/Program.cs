// See https://aka.ms/new-console-template for more information
using IsleWork;
int id = 0;
List<Employee> employList = new List<Employee>();
String Title = "******************************-Employee Registration-******************************";
Console.WriteLine(Title);
while (true)
{
    Console.WriteLine("\nPlease enter your name or type 'exit'");
    
    string inputName = Console.ReadLine();

    if (inputName.Equals("exit", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }
    Console.WriteLine("Please enter the employee Surname:");
    string inputSurname = Console.ReadLine();
    Console.WriteLine("Please enter the employee Email:");
    string inputEmail = Console.ReadLine();
    Console.WriteLine("Please enter the employee Role:");
    string inputRole = Console.ReadLine();
    Console.WriteLine("Please enter the employee Cellphone:");
    string inputCellphone = Console.ReadLine();
    Console.WriteLine("Please enter the employee Age:");
    int inputAge;
    while (!int.TryParse(Console.ReadLine(), out inputAge) || inputAge < 0)
    {
        Console.Write("Invalid age. Please enter a valid number: ");
    }
    Employee newEmployee = new Employee(id , inputName, inputSurname, inputEmail, inputCellphone, inputRole, inputAge);
    employList.Add(newEmployee);
    id++;
    Console.WriteLine($"{newEmployee.EmployeeName} added successfully");
}
foreach (Employee e in employList)
{
    
    Console.WriteLine($"Employee ID: {e.Id} \nEmployee Name: {e.EmployeeName} \nEmployee Surname: {e.EmployeeSurname} \nEmployee Email: {e.EmployeeEmail} \nEmployee Phone: {e.EmployeeAge}");
}

