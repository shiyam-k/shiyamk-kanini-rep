using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_first_28_04_2023.Models
{
    internal class Patients
    {
        [Key]
        public int PId { get; set; }
        public string PName { get; set; }

        public virtual Doctors DoctorsDid { get; set; } = null!;
    }
}
