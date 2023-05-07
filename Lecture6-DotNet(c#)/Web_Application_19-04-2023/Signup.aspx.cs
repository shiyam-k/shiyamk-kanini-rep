using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_19_04_2023
{
    public partial class Signup : System.Web.UI.Page
    {
        static string connectionSource = "Data Source=LAPTOP-OJCNGD2Q\\SQLEXPRESS;Initial Catalog=bingersbible;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionSource);
        public void Page_Load(object sender, EventArgs e)
        {
        }


        protected void SignupButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($@"insert into user_credentials(email, password, user_name, user_type) values('{EmailTextBox.Text}', '{PasswordTextBox.Text}', '{UsernameTextBox.Text}', 'user')", connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                WarningLabel.Text = ex.Message;
                Console.WriteLine(ex);
                
            }
            finally
            {
                string email = EmailTextBox.Text;
                Session["email"] = email;
                EmailTextBox.Text = null;
                UsernameTextBox.Text = null;
            }
            Response.Redirect("SuccessPage.aspx");
        }


    }
}