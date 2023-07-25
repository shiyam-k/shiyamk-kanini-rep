using System.ComponentModel.DataAnnotations;

namespace azureapi.Models
{
    public class TestBoovie
    {
        [Key]
        public int BId { get; set; }
        public string? BName { get; set; }
        public int BooCount { get; set; }
    }
}
