using System;
using System.Collections.Generic;

namespace Emp_Exp_API.Models;

public partial class Client
{
    public string ClientId { get; set; } = null!;

    public string ClientName { get; set; } = null!;

    public string ClientCountry { get; set; } = null!;

    public string ClientPhone { get; set; } = null!;

    public string ClientPostalCode { get; set; } = null!;

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
