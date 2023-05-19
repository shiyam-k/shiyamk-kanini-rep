using System.ComponentModel.DataAnnotations;

namespace EmployeeExplorer_M_V_C.Models
{
    public class Clients
    {
        [Key]
        public string ClientId { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public string ClientCountry { get; set; } = string.Empty;
        public string ClientPhone { get; set; } = string.Empty;
        public string ClientPostalCode { get; set; } = string.Empty;

        public ICollection<Projects> Projects { get; set; }
    }
}
