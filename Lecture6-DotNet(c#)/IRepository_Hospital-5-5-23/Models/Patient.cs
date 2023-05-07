using System.ComponentModel.DataAnnotations;

namespace IRepository_Hospital_5_5_23.Models
{
    public class Patient
    {
        [Key]
        public int Pid { get; set; }

        public string Pname { get; set; } = null!;

        public int DoctorsDid { get; set; }

        public virtual Doctor DoctorsD { get; set; } = null!;
    }
}
