using System;
using System.Collections.Generic;

namespace Emp_Exp_API.Models;

public partial class EngineerProject
{
    public string EngineerProjectId { get; set; } = null!;

    public string? EngineerEmployeeId { get; set; }

    public string ProjectsProjectId { get; set; } = null!;

    public string ManagerProjectId { get; set; } = null!;

    public virtual Employee? EngineerEmployee { get; set; }

    public virtual ManagerProject ManagerProject { get; set; } = null!;

    public virtual Project ProjectsProject { get; set; } = null!;
}
