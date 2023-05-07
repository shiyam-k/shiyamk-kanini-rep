using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API_OnetoMany.Models;

public partial class Doctor
{
    [Key]
    public int Did { get; set; }

    public string Dname { get; set; } = null!;

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
