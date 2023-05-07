using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EF_Code_First_26_04_2023.Modals
{
    internal class Students
    {
        [Key]
        public int SId { get; set; }
        public string? SName { get; set; }
        public Course CId { get; set; }

        
    }
}
