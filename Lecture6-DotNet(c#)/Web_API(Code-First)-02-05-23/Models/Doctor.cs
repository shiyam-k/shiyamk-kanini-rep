using System;
using System.Collections.Generic;

namespace Web_API_Code_First__02_05_23.Models;

public partial class Doctor
{
    public int Did { get; set; }

    public string Dname { get; set; } = null!;

    public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
}
