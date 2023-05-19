using System;
using System.Collections.Generic;

namespace Emp_Exp_API.Models;

public partial class EmployeeCredential
{
    public string EmployeeId { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Login> Logins { get; set; } = new List<Login>();
}
