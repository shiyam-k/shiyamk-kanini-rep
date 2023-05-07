using System;
using System.Collections.Generic;

namespace Web_API_Code_First__02_05_23.Models;

public partial class Patient
{
    public int Pid { get; set; }

    public string Pname { get; set; } = null!;

    public int DoctorsDid { get; set; }

    public virtual Doctor DoctorsD { get; set; } = null!;
}
