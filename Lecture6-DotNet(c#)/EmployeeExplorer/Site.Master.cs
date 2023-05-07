using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace EmployeeExplorer
{
    public partial class SiteMaster : MasterPage
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            //var builder = WebApplication.CreateBuilder(args);
        }

    }
}