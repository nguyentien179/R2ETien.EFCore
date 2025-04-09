using System;

namespace R2ETien.EFCore.Domain.Entities;

public class ProjectEmployee
{
    public Guid ProjectId { get; set; }
    public Guid EmployeeId { get; set; }
    public bool Enable { get; set; }

    public Project? Project { get; set; }
    public Employee? Employee { get; set; }
}
