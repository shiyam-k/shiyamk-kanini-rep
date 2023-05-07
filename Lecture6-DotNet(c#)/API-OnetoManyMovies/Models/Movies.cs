using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace API_OnetoManyMovies.Models
{
    public class Movies
    {
        [Key]
        public int MId { get; set; }
        public string MName { get; set; }
        
        public int DirectorId { get; set; }
        public Director Director { get; set; } 
    }
}
