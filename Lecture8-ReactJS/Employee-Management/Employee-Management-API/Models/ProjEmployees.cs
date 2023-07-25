using System.ComponentModel.DataAnnotations;

namespace Employee_Management_API.Models
{
    public class ProjEmployees
    {
        [Key]
        public string? PEID { get; set; }
        public ProjTL? ProjectsTL { get; set; }
        public EmployeeData? ProjectEmployee { get; set; }
    }
}
