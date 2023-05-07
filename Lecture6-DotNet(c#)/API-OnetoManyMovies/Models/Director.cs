using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace API_OnetoManyMovies.Models
{
    public class Director
    {
        [Key] public int DId { get; set; }
        public string DName { get; set; }

        public ICollection<Movies> Movies { get; set; }
    }
}
