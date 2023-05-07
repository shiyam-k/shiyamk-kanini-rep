using System;
using System.Collections.Generic;

namespace DBfirst.Models;

public partial class Patient
{
    public int Pid { get; set; }

    public string Pname { get; set; } = null!;

    public int DoctorsDid { get; set; }

    public virtual Doctor DoctorsD { get; set; } = null!;
}
