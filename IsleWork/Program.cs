// See https://aka.ms/new-console-template for more information
using IsleWork;

String Title = "******************************-Employee Registration-******************************";
Console.WriteLine(Title);
bool emailUpdated = false;
int id = 0;
List<Employee> employList = new List<Employee>();

void RegisterEmployee()
{
    
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
        int inputAge = int.Parse(Console.ReadLine());
        ReadValidAge(inputAge);
        
       
        
    
        //Add data to list
        Employee newEmployee = new Employee(id , inputName, inputSurname, inputEmail, inputCellphone, inputRole, inputAge);
        employList.Add(newEmployee);
        id++;
        Console.WriteLine($"{newEmployee.EmployeeName} added successfully");
    }

}

static int ReadValidAge(int inputAge)
{
    while (!int.TryParse(Console.ReadLine(), out inputAge) || inputAge <= 0)
    {
        Console.Write("Invalid age. Please enter a valid number: ");
    } 
    return inputAge;
}


// Select an existing employee
Employee nEmployee = employList[0];
//update email 
while (!emailUpdated)
{
    Console.WriteLine("Please enter the new email:");
    string newEmail = Console.ReadLine();

    try
    {
        nEmployee.ChangeEmail(newEmail);

        emailUpdated = true;
        Console.WriteLine($"{nEmployee.EmployeeName} updated successfully");
    }
    catch (ArgumentException exception)
    {
        Console.WriteLine(exception.Message);
    }
}
//Display data
foreach (Employee e in employList)
{
    
    Console.WriteLine($"Employee ID: {e.Id} \nEmployee Name: {e.EmployeeName} \nEmployee Surname: {e.EmployeeSurname} \nEmployee Email: {e.EmployeeEmail} \nEmployee Phone: {e.EmployeePhone}");
}

