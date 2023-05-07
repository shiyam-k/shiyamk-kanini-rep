using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_19_04_2023
{
    public partial class SuccessPage : System.Web.UI.Page
    {
        static string connectionSource = "Data Source=LAPTOP-OJCNGD2Q\\SQLEXPRESS;Initial Catalog=bingersbible;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionSource);
        string email;
        string userName;
        string password;
        List<string> profile = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            email = (string)Session["email"];
            profile.Add(email);
        }

        protected void ViewProfileButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($@"select user_name from user_credentials where email = '{email}'", connection);

                SqlDataAdapter reader = new SqlDataAdapter(command);
                DataTable profileTable = new DataTable();
                reader.Fill(profileTable);
                foreach (DataRow row in profileTable.Rows)
                {
                    foreach (DataColumn col in profileTable.Columns)
                    {
                        if (col.ColumnName.ToString().Equals("user_name"))
                        {
                            userName = row.ItemArray[0].ToString();
                            profile.Add(userName);
                        }
                        if (col.ColumnName.ToString().Equals("password"))
                        {
                            password = row.ItemArray[2].ToString();
                            profile.Add(password);
                        }
                    }
                }
            }
            catch (Exception ex) { 
                WarningLabel.Text = ex.ToString();
            }
            finally { 
                connection.Close();
                WarningLabel.Text += "Email :" + profile[0]+ " ";
                WarningLabel.Text += "User Name :" + profile[1];

            }
        }
    }
}