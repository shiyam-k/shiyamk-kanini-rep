using System.ComponentModel.DataAnnotations;

namespace IRepository_Hospital_5_5_23.Models
{
    public class Doctor
    {
        [Key]
        public int Did { get; set; }

        public string Dname { get; set; } = null!;

        public virtual ICollection<Patient> Patients { get; set; } = new List<Patient>();
    }
}
