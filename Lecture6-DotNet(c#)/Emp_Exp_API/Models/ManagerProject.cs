using System;
using System.Collections.Generic;

namespace Emp_Exp_API.Models;

public partial class ManagerProject
{
    public string ManagerProjectId { get; set; } = null!;

    public string? ManagerEmployeeId { get; set; }

    public string? ProjectsProjectId { get; set; }

    public virtual ICollection<EngineerProject> EngineerProjects { get; set; } = new List<EngineerProject>();

    public virtual Employee? ManagerEmployee { get; set; }

    public virtual Project? ProjectsProject { get; set; }
}
