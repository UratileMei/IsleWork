namespace IsleWork;

public class Project
{
    int Id { get; set; }
    String Name { get; set; }
    String Description { get; set; }
    DateTime StartDate { get; set; }
    String Status { get; set; }

    public Project(int id, string name, string description, DateTime startDate, string status)
    {
        Id = id;
        Name = name;
        Description = description;
        StartDate = startDate;
        Status = status;
    }
}