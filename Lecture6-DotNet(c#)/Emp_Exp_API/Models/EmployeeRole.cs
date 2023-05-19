using System;
using System.Collections.Generic;

namespace Emp_Exp_API.Models;

public partial class EmployeeRole
{
    public string Erid { get; set; } = null!;

    public string EmployeeId { get; set; } = null!;

    public string? RoleId { get; set; }

    public string Designation { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual Role? Role { get; set; }
}
