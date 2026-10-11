namespace IsleWork;

public class Employee
{
    int Id{ get; set; }
    String EmployeeName{ get; set; }
    String EmployeeSurname { get; set; }
    String EmployeeEmail{ get; set; }
    String EmployeePhone{ get; set; }
    String EmployeeRole{ get; set; }

    public Employee(int id, string name, string surname, string email, string phone, string role)
    {
        Id = id;
        EmployeeName = name;
        EmployeeSurname = surname;
        EmployeeEmail = email;
        EmployeePhone = phone;
        EmployeeRole = role;
        
    }
}