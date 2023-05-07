using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API_OnetoMany.Models;

public partial class Patient
{
    [Key]
    public int Pid { get; set; }

    public string Pname { get; set; } = null!;

    public int DoctorsDid { get; set; }

    public virtual Doctor DoctorsD { get; set; } = null!;
}
