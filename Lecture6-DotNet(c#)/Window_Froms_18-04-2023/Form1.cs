using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Window_Froms_18_04_2023
{
    public partial class Form1 : Form
    {
        DateTime currDate = DateTime.Now;
        static string connectionSource = "Data Source=LAPTOP-OJCNGD2Q\\SQLEXPRESS;Initial Catalog=bingersbible;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionSource);
        SupportClass support = new SupportClass();
        Random random = new Random();
        string email;
        string password;
        string userName;
        string sessionId;
        bool viewProfileClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        /*Login*/
        private void loginButton_Click(object sender, EventArgs e)
        {
            email = loginEmail.Text;
            string pwd = "";
            password = loginPassword.Text;
            if (LoginRegisterCheck(email, password))
            {

            }
            else
            {
                entryOp.Text = "check email or password ";
                return;
            }
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($@"select password from user_credentials where email = '{email}'", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    pwd = reader["password"].ToString();
                }
                
                reader.Close();
                command = new SqlCommand($@"select user_name from user_credentials where email = '{email}'", connection);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    userName = reader["user_name"].ToString();
                }
                reader.Close();
                connection.Close();
            }
            catch(Exception ex) { 
                entryOp.Text = ex.Message;
            }
            finally
            {
                if (loginPassword.Text.ToString().Equals(pwd))
                {
                    
                }
                else
                {
                    loginEmail.Text = "";
                    loginPassword.Text = "";
                    entryOp.Text = "Email or Passwords Mismatch";
                }
            }
            List<string> column = support.GetColumn("user_logs");
            column.Remove("session_end");
            List<string> records = new List<string>() { sessionId, email, currDate.ToString() };
            string insertQuery = support.InsertQueryGenerator("user_logs",records, column);
            entryOp.Text = insertQuery;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.ExecuteNonQuery();

            }
            catch(Exception ex) { }
            finally { 
                connection.Close();
                entryOp.Text = "";
                entryPanel.Dispose();
                loginEmail.Text = "";
                loginPassword.Text = "";
                profilePanel.Visible = true;
            }
        }

        private void loginRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (login.Enabled)
            {
                loginPanel.Visible = true;
                registerPanel.Visible = false;
            }
            else
            {
                loginPanel.Visible = false;
                registerPanel.Visible = true;
            }
        }

        private void RegisterRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (register.Enabled)
            {
                loginPanel.Visible = false;
                registerPanel.Visible = true;
            }
            else
            {
                loginPanel.Visible = true;
                registerPanel.Visible = false;
            }
        }
        private bool LoginRegisterCheck(string email, string password)
        {
            bool valid = true;
            if(support.PasswordValidate(password) && support.MailValidate(email))
            {
                valid = true;
            }
            else
            {
                valid = false;
            }
            return valid;
        }

        private void loginEmail_TextChanged(object sender, EventArgs e)
        {
            if(support.MailValidate(loginEmail.Text))
            {
                entryOp.Text = "";
            }
            else
            {
                entryOp.Text = "**Incorrect Mail Format**";
            }
        }

        private void loginPassword_TextChanged(object sender, EventArgs e)
        {
            if(support.PasswordValidate(loginPassword.Text))
            {
                entryOp.Text = "";

            }
            else
            {
                entryOp.Text = "Password Must contain 1 special character, 1 uppercase, 1 numeric";
            }
        }

        private void registerEmail_TextChanged(object sender, EventArgs e)
        {
            if (support.MailValidate(registerEmail.Text))
            {
                entryOp.Text = "";
            }
            else
            {
                entryOp.Text = "**Incorrect Mail Format**";
            }
        }

        private void registerPassword_TextChanged(object sender, EventArgs e)
        {
            if (support.PasswordValidate(registerPassword.Text))
            {
                entryOp.Text = "";

            }
            else
            {
                entryOp.Text = "Password Must contain 1 special character, 1 uppercase, 1 numeric";
            }
        }

        private void entryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            profilepic.ImageLocation = "./profile-icon.png";
            sessionId = $"SID{random.Next(100, 999)}";
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            List<string> emailList = new List<string>();
            email = registerEmail.Text;
            /*try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(@"select email from user_credentials");
                SqlDataAdapter loginAdapter = new SqlDataAdapter(command);
                connection.Close();
                DataTable localLoginTable = new DataTable();
                loginAdapter.Fill(localLoginTable);
                //Console.WriteLine("Data table created");
                foreach (DataRow row in localLoginTable.Rows)
                {
                    int index = -1;
                    foreach (DataColumn col in localLoginTable.Columns)
                    {
                        if ((col.ColumnName.ToString()).Equals("email"))
                        {
                            emailList.Add(row.ItemArray[++index].ToString());
                        }
                    }
                }
                loginAdapter.Dispose();
                foreach(string el in emailList)
                {
                    if (email.Equals(el))
                    {
                        registerEmail.Text = "";
                        registerPassword.Text= "";
                        registerUserName.Text = "";
                        entryOp.Text = "Email already registered with us";
                        return;
                    }
                }
            }
            catch { }
            finally { connection.Close(); }*/
            password = registerPassword.Text;
            userName = registerUserName.Text;
            if(LoginRegisterCheck(email, password))
            {
                
            }
            else
            {
                entryOp.Text = "check email or password ";
                return;
            }
            List<string> columns = new List<string>();
            columns = support.GetColumn("user_credentials");
            List<string> records = new List<string>() { email, password, userName, currDate.ToShortTimeString(), "User"};
            string insertQuery = support.InsertQueryGenerator("user_credentials", records, columns);
            //entryOp.Text = insertQuery;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(insertQuery, connection);

                command.ExecuteNonQuery();
                
                connection.Close();
            }
            catch(Exception ex) { 
                entryOp.Text = ex.Message;
            }
            finally { 
                connection.Close();

                registerEmail.Text = "";
                registerPassword.Text = "";
                registerUserName.Text = "";
            }
            columns = support.GetColumn("user_logs");
            columns.Remove("session_end");
            records = new List<string>() { sessionId, email, currDate.ToString() };
            insertQuery = support.InsertQueryGenerator("user_logs", records, columns);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.ExecuteNonQuery();
            }
            catch(Exception ex) { }
            finally
            {
                connection.Close();
            }
            profilePanel.Visible = true;
            entryPanel.Dispose();
        }

        private void registerUserName_TextChanged(object sender, EventArgs e)
        {
            entryOp.Text = "";
        }

        private void viewProfile_Click(object sender, EventArgs e)
        {
            
            if (!viewProfileClicked)
            {
                profileEmail.Text += email;
                profilePassword.Text += password;
                profileUserName.Text += userName;
                profileSessionId.Text += sessionId;
            }
            IsViewProfileClicked();
        }
        private void IsViewProfileClicked()
        {
            viewProfileClicked = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string userMovieRequest = searchBox.Text.Trim().ToLower();
            moviePanel.Visible = true;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($@"select * from movie_table where lower(movie_name) = '{userMovieRequest}'",connection);
                SqlDataAdapter movieDetailsAdapter = new SqlDataAdapter(command);
                DataTable movieDetails = new DataTable();
                movieDetailsAdapter.Fill(movieDetails);
                foreach (DataRow row in movieDetails.Rows)
                {
                    int index = -1;
                    foreach (DataColumn col in movieDetails.Columns)
                    {
                        if (row.ItemArray[++index].ToString().ToLower().Equals(userMovieRequest))
                        {

                            movieName.Text += row["movie_name"].ToString();
                            movieDirector.Text += row["director_name"].ToString();
                            movieCast.Text += row["movie_cast"].ToString();
                            moviePlot.Text += row["movie_plot"].ToString();


                        }

                    }
                }


            }
            catch(Exception ex )
            {
                movieNameLabel.Text = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            
        }

        private void profileEmail_Click(object sender, EventArgs e)
        {
            GetProfileUpdate(sender);
            updatePanel.Visible = true;
        }
        string[] str = new string[2];
        private void GetProfileUpdate(object sender)
        {
            //updateStatus.Text = sender.GetType().Name.Equals("Button").ToString();
            if (sender.GetType().Name.Equals("Label"))
            {
                str = ((Label)sender).Text.Split(':');
                //updateStatus.Text= str[0].Equals("Email ").ToString();
            }
            
            
        }
        private void ProfileUpdate(object sender)
        {
            if (str[0].Equals("Email ") && updateProfile.Text != null)
            {
                profileEmail.Text = $"Email : {updateProfile.Text}";
                updateStatus.Text = "Updated !!";
                UpdateProfileDB("email", updateProfile.Text);
                email = updateProfile.Text;

            }
            else if (str[0].Equals("Password ") && updateProfile.Text != null)
            {
                profilePassword.Text = $"Passsword : {updateProfile.Text}";
                updateStatus.Text = "Updated !!";
                UpdateProfileDB("password", updateProfile.Text);
                password = updateProfile.Text;
            }
            else if (str[0].Equals("User Name ") && updateProfile.Text != null)
            {
                profileUserName.Text = $"User Name : {updateProfile.Text}";
                updateStatus.Text = "Updated !!";
                UpdateProfileDB("user_name", updateProfile.Text);
                userName = updateProfile.Text;
            }
            else if (str[0].Equals("Session ID "))
            {
                updateStatus.Text = "Session Id  Cannot be updated !!";
            }
        }
        private void UpdateProfileDB(string column, string value)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($@"update user_credentials set {column} = '{value}' where email = '{email}'",connection);
                command.ExecuteNonQuery();
                
            }
            catch(Exception ex) { updateStatus.Text = ex.Message; }
            finally { connection.Close(); }
        }
        private void profileUpdate_Click(object sender, EventArgs e)
        {
            ProfileUpdate(sender);
        }

        private void profileSessionId_Click(object sender, EventArgs e)
        {
            if (sender.GetType().Name.Equals("Label"))
            {
                str = ((Label)sender).Text.Split(':');
                //updateStatus.Text= str[0].Equals("Email ").ToString();
            }
        }

        private void profileUserName_Click(object sender, EventArgs e)
        {
            if (sender.GetType().Name.Equals("Label"))
            {
                str = ((Label)sender).Text.Split(':');
                //updateStatus.Text= str[0].Equals("Email ").ToString();
            }
        }

        private void profilePassword_Click(object sender, EventArgs e)
        {
            if (sender.GetType().Name.Equals("Label"))
            {
                str = ((Label)sender).Text.Split(':');
                //updateStatus.Text= str[0].Equals("Email ").ToString();
            }
        }
    }
}
