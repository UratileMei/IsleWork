namespace IsleWork;

public class Employee
{
    public int Id{ get; set; }
    public String EmployeeName{ get; set; }
    public String EmployeeSurname { get; set; }
    public String EmployeeEmail{ get; set; } 
    public String EmployeePhone{ get; set; }
    public String EmployeeRole{ get; set; }
    public int EmployeeAge{ get; set; }

    public Employee(int  id, string name, string surname, string email, string phone, string role, int age)
    {
        Id = id;
        EmployeeName = name;
        EmployeeSurname = surname;
        EmployeeEmail = email;
        EmployeePhone = phone;
        EmployeeRole = role;
        EmployeeAge = age;
    }
}