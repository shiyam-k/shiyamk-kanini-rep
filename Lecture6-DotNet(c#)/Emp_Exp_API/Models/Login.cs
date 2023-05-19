using System;
using System.Collections.Generic;

namespace Emp_Exp_API.Models;

public partial class Login
{
    public string SessionId { get; set; } = null!;

    public string? LoginEmployeeId { get; set; }

    public string? EmployeeCredentialsEmployeeId { get; set; }

    public string? Password { get; set; }

    public string? Status { get; set; }

    public virtual EmployeeCredential? EmployeeCredentialsEmployee { get; set; }
}
