using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace test_api_form_integration.Controllers
{
    public class FirstContext : DbContext
    {
        private readonly string connection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        public FirstContext() { }


    }
}