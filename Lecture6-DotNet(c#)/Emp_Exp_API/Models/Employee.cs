using System;
using System.Collections.Generic;

namespace Emp_Exp_API.Models;

public partial class Employee
{
    public string EmployeeId { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string DateOfJoin { get; set; } = null!;

    public string DateOfBirth { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int Salary { get; set; }

    public string EmployeeStatus { get; set; } = null!;

    public virtual ICollection<EmployeeRole> EmployeeRoles { get; set; } = new List<EmployeeRole>();

    public virtual ICollection<EngineerProject> EngineerProjects { get; set; } = new List<EngineerProject>();

    public virtual ICollection<ManagerProject> ManagerProjects { get; set; } = new List<ManagerProject>();
}
