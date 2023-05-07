using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EF_Code_First_26_04_2023.Modals
{
    internal class Course
    {
        [Key]
        public int CId { get; set; }

        public string CName { get; set; }  

        public int CDuration { get; set; }
                      
    }
}
