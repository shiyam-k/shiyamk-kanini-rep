using System;
using System.Collections.Generic;

namespace Emp_Exp_API.Models;

public partial class Project
{
    public string ProjectId { get; set; } = null!;

    public string ProjectTitle { get; set; } = null!;

    public string ProjectDescription { get; set; } = null!;

    public string ProjectCategory { get; set; } = null!;

    public string ProjectStartDate { get; set; } = null!;

    public string ProjectEndDate { get; set; } = null!;

    public string? ClientsClientId { get; set; }

    public virtual Client? ClientsClient { get; set; }

    public virtual ICollection<EngineerProject> EngineerProjects { get; set; } = new List<EngineerProject>();

    public virtual ICollection<ManagerProject> ManagerProjects { get; set; } = new List<ManagerProject>();
}
