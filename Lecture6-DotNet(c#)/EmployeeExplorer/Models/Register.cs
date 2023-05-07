using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace EmployeeExplorer.Models
{
    public class Register
    {
        [Key] public int UserId { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string userName { get; set; }
    }
}