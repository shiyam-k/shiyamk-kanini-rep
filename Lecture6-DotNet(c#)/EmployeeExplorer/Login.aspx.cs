using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace EmployeeExplorer
{
    public partial class Login : System.Web.UI.Page
    {
        SupportClass support = new SupportClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginSubmit_Click(object sender, EventArgs e)
        {
            string email = loginEmail.Text;
            string password = loginPassword.Text;
            Response.Write($"<script>alert('{email}')</script>");
        }
    }
}