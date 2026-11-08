namespace IsleWork;

public class Employee
{
    public int Id{ get; private set; }
    public String EmployeeName{ get; private set; }
    public String EmployeeSurname { get; private set; }
    public String EmployeeEmail{ get; private set; } 
    public String EmployeePhone{ get; private set; }
    public String EmployeeRole{ get; private set; }
    public int EmployeeAge{ get; private set; }

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

    public void changeEmail(string newEmail)
    {
        EmployeeEmail = newEmail;
    }
}