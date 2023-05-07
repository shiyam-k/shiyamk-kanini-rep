using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_first_28_04_2023.Models
{
    internal class Doctors
    {
        [Key]
        public int DId { get; set; }
        public string DName { get; set; }
        public virtual ICollection<Patients> Patients { get; set; } = new List<Patients>();
    }
}
