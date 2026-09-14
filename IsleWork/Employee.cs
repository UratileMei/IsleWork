using System.Xml;

namespace IsleWork;

public class Employee
{
    private static int counter = 0;
    private int Id { get; set; }
    private string FirstName { get; set; }
    private string LastName { get; set; } 
    private string Email { get; set; }
    private string Role { get; set; }
    public Employee(int id, string firstName, string lastName, string email, string role)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Role = role;
        Console.WriteLine($"{Id++}: {FirstName} {LastName}, {Email} added");
    }

    
    public void Print()
    {
        Console.WriteLine($"Id: {Id}");
    }
}
 