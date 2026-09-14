namespace IsleWork;

public class TaskItem
{
    int Id { get; set; }
    String Title { get; set; }
    String Description { get; set; }
    String Status { get; set; }
    String AssignedEmployeeId { get; set; }
    String ProjectId { get; set; }

    public TaskItem(int Id, string title, string description, string status, string assignedEmployeeId, string projectId)
    {
        Id = Id;
        Title = title;
        Description = description;
        Status = status;
        AssignedEmployeeId = assignedEmployeeId;
        ProjectId = projectId;
    }
}