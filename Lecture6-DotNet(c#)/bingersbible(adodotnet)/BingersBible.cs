using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bingersbible_adodotnet_
{
    class BingersBible
    {
        public static SupporterClass support = new SupporterClass();
        public static List<Object> tables = new List<Object>();
        static string connectionSource = "Data Source=LAPTOP-OJCNGD2Q\\SQLEXPRESS;Initial Catalog=bingersbible;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionSource);
        Random random = new Random();
        DateTime currDate = DateTime.Now;
        string email;
        string password;
        string userName;
        string sessionId;
        string userType = "";
        List <string> action = null;
        public BingersBible()
        {
            sessionId = $"SID{random.Next(100, 999)}";
            bool y_n = true ;
            Console.WriteLine("Welcome to BingersBible!");
            action = new List<string>() { "l", "r" };
            switch (support.GetStringInput("Login / Register (L/R)", action))
            {
                case "l":
                    Console.WriteLine(Login());
                    break;
                case "r":
                    Console.WriteLine(Register());
                    break;
            }
        }
        private string Login()
        {
            List<string> emailList = new List<string>();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(@"select * from user_credentials", connection);
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
            try
            {
                Console.WriteLine("*****Login Page*****");
                email = support.GetStringInput("Email",emailList);
                string pwd = "";
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
                command = new SqlCommand($@"select user_type from user_credentials where email = '{email}'", connection);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    userType = reader["user_type"].ToString();
                }
                connection.Close();
                reader.Close();
                password = support.GetPasswordInput("Password",pwd);
                List<string> record = new List<string>() {sessionId, email, currDate.ToString()};
                List<string> columns = GetColumn("user_logs");
                columns.RemoveAt(columns.Count - 1);
                try
                {
                    connection.Open();
                    string query = support.InsertQueryGenerator("user_logs", record, columns);
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                }
                finally {
                    
                    command = null;
                    command = new SqlCommand($@"select user_type from user_credentials where email = '{email}'", connection);
                    SqlDataReader newReader= command.ExecuteReader();
                    if (newReader.Read())
                    {
                        userType = newReader["user_type"].ToString();
                    }
                    connection.Close();
                    newReader.Close();
                    if (userType.Equals(""))
                    {
                        Console.WriteLine("User Type doesnot exists");
                    }
                    else if (userType.Equals("Admin"))
                    {
                        Admin admin = new Admin(email, sessionId, 0);
                    }
                    else if (userType.Equals("User"))
                    {
                        User user = new User(email, sessionId);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally { connection.Close(); }
            return "";
        }
        private string Register() 
        {
            List<string> columns = new List<string>();
            email = support.GetMailInput("Enter Email:");
            password = support.GetPasswordInput("Enter Password:");
            userName = support.GetStringInput("Enter user name:");
            List<string> register = new List<string>() { email, password, userName, currDate.ToString(), "User" };
            columns = GetColumn("user_credentials");
            string insertQuery = support.InsertQueryGenerator("user_credentials", register, columns);
            try
            {
                connection.Open();
                SqlCommand command = null;
                
                command = new SqlCommand(insertQuery, connection);
                command.ExecuteNonQuery();

                Console.WriteLine($"User {userName} created");
                connection.Close();
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Open();
                SqlCommand command = null;
                command = new SqlCommand($@"select user_type from user_credentials where email = '{email}'", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    userType = reader["user_type"].ToString();
                }
                connection.Close();
                if (userType.Equals(""))
                {
                    Console.WriteLine("User Type doesnot exists");
                }
                else if (userType.Equals("Admin"))
                {
                    Admin admin = new Admin(email, sessionId, 0);
                }
                else if (userType.Equals("User"))
                {
                    User user = new User(email, sessionId);
                }
            }

            return "";
        }
        public List<string> GetColumn(string tableName)
        {
            List<string> columns = new List<string>();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($@"SELECT name FROM sys.columns WHERE object_id = OBJECT_ID('{tableName}')", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    columns.Add(reader["name"].ToString());
                }
                reader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally { 
                connection.Close(); 
                
            }
            return columns;
        }
        ~BingersBible()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($@"update user_logs set session_end = '{currDate.ToString()}' where session_id = '{this.sessionId}' ", connection);
                int res = command.ExecuteNonQuery();
            }
            catch(Exception e) 
            { 
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public string GetEmail()
        {
            return this.email;
        }
        public string GetUserName()
        {
            return this.userName;
        }
        public string GetSessionId()
        {
            return this.sessionId;
        }
    }  
    
    class User : BingersBible
    {
        string email;
        string password;
        string userName;
        string sessionId;
        SqlDataAdapter loginAdapter = null;
        SqlCommandBuilder cb = null;
        public User()
        {

        }
        public User(string email, string sId) 
        {
            this.email = email;
            this.sessionId= sId;
            List<string> profile = new List<string>();
            profile.Add(this.email);
            profile.Add(sessionId);
            connection.Open();
            SqlCommand command = new SqlCommand($@"select * from user_credentials where email = '{email}'", connection);
            loginAdapter = new SqlDataAdapter(command);

            DataTable localLoginTable = new DataTable();
            loginAdapter.Fill(localLoginTable);
            loginAdapter.Dispose();
            command = new SqlCommand($@"select * from movie_table", connection);
            DataTable localMoviesTable = new DataTable();
            loginAdapter = new SqlDataAdapter(command);

            loginAdapter.Fill(localMoviesTable);
            connection.Close();
            
            foreach (DataRow row in localLoginTable.Rows)
            {
                foreach (DataColumn col in localLoginTable.Columns)
                {
                    if (col.ColumnName.ToString().Equals("user_name"))
                    {
                        userName= row.ItemArray.GetValue(2).ToString();
                        profile.Add(userName);
                    }
                    if(col.ColumnName.ToString().Equals("password"))
                    {
                        password = row.ItemArray.GetValue(1).ToString();
                        profile.Add(password);
                    } 
                }
            }
            bool y_n = true;
            do
            {
                Console.WriteLine($"*****User {userName} Logged In*****");
                Console.WriteLine("");
                Console.WriteLine("Press 1 to view profile");
                Console.WriteLine("Press 2 to search movies");
                Console.WriteLine("Press 3 to Edit Profile");
                string action = support.GetStringInput("Key", new List<string>() { "1", "2","3" });
                switch (action)
                {
                    case "1":
                        ViewProfile(profile);
                        break;
                    case "2":
                        SearchMovies(localMoviesTable);
                        break;
                    case "3":
                        EditProfile(localLoginTable);   
                        break;
                }
                y_n = support.Yes_No();
            }
            while(y_n );    
        }
        void SyncDatabase(DataTable updatedTable)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($@"select * from user_credentials where email = '{email}'", connection);
                loginAdapter = new SqlDataAdapter(command);
                cb = new SqlCommandBuilder(loginAdapter);
                loginAdapter.UpdateCommand = cb.GetUpdateCommand();
                loginAdapter.Update(updatedTable);
                loginAdapter.Dispose();
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            
        }

        public virtual void EditProfile(DataTable profile)
        {
            int i = 0;
            foreach (DataColumn col in profile.Columns)
            {
                if(col.ColumnName.ToString().Equals("user_type") || col.ColumnName.ToString().Equals("date_of_registration"))
                {
                    continue;
                }
                Console.WriteLine($"{++i}. { col.ColumnName}");
            }
            string edit = support.GetStringInput("Field to Edit",new List<string>() { "email", "password", "user_name"});
            switch (edit)
            {
                
                case "email":
                    //profile = RowUpdate(profile, edit);
                    profile.Rows[0]["email"] = support.GetMailInput("Email :");
                    break;
                case "password":
                    String op = profile.Rows[0].ItemArray[1].ToString();
                    support.GetPasswordInput("password :", op);
                    profile.Rows[0]["password"] = support.GetPasswordInput("password :",op);
                    break;
                case "user_name":
                    profile.Rows[0]["user_name"] = support.GetStringInput("User Name: ");
                    break;
            }
            SyncDatabase(profile);
        }
        
        public virtual void ViewProfile(List<string> profile)
        {
            try
            {
                Console.WriteLine($"Email id : {profile[0]}");
                Console.WriteLine($"Session Id : {profile[1]}");
                Console.WriteLine($"User Name : {profile[3]}");
                Console.WriteLine($"Password: {profile[2]}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally { connection.Close(); }
        }
        public virtual void SearchMovies(DataTable localMoviesTable)
        {
            string user_movie_request = support.GetStringInput("Enter A movie to view");
            foreach (DataRow row in localMoviesTable.Rows)
            {
                int index = -1;
                foreach (DataColumn col in localMoviesTable.Columns)
                {
                    if (row.ItemArray[0].ToString().ToLower().Equals(user_movie_request))
                    {
                        Console.WriteLine($"{col.ColumnName}: {row.ItemArray[++index].ToString()}");
                    }

                }
            }
        }
        
    }
    /*class PrimeUser : User
    {

    }*/
    class Admin : User
    {
        List<string> tables = new List<string>();
        static List<string> columns = new List<string>();
        string email;
        string password;
        string userName;
        string sessionId;
        SqlDataAdapter loginAdapter = null;
        SqlCommandBuilder cb = null;
        public Admin(string email, string sId) : base(email, sId)
        {
            
        }
        public Admin(string email, string sId, int n)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(@"SELECT name FROM sys.Tables", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tables.Add(((reader["name"]).ToString()));
            }
            connection.Close();
            this.email = email;
            List<string> profile = new List<string>();
            profile.Add(email);
            profile.Add(sessionId);
            connection.Open();
            command = new SqlCommand($@"select * from user_credentials where email = '{email}'", connection);
            SqlDataAdapter loginAdapter = new SqlDataAdapter(command);
            DataTable localLoginTable = new DataTable();
            loginAdapter.Fill(localLoginTable);
            loginAdapter.Dispose();
            loginAdapter.Dispose();
            command = new SqlCommand($@"select * from movie_table", connection);
            DataTable localMoviesTable = new DataTable();
            loginAdapter = new SqlDataAdapter(command);
            loginAdapter.Fill(localMoviesTable);
            connection.Close();
            foreach (DataRow row in localLoginTable.Rows)
            {
                int index = -1;
                foreach (DataColumn col in localLoginTable.Columns)
                {
                    if (col.ColumnName.ToString().Equals("user_name"))
                    {
                        userName = row.ItemArray.GetValue(2).ToString();
                        profile.Add(userName);
                    }
                    if (col.ColumnName.ToString().Equals("password"))
                    {
                        password = row.ItemArray.GetValue(1).ToString();
                        profile.Add(password);
                    }
                }
            }
            bool y_n = true;
            do
            {
                
                Console.WriteLine($"*****Admin {userName} Logged In*****");
                Console.WriteLine("");
                Console.WriteLine("Press 1 to view profile");
                Console.WriteLine("Press 2 to search movies");
                Console.WriteLine("Press 3 to perform Admin Operations");
                Console.WriteLine("Press 4 to Edit Profile");
                Console.WriteLine();
                string action = support.GetStringInput("Key", new List<string>() { "1", "2", "3", "4" });
                switch (action)
                {
                    case "1":
                        ViewProfile(profile);
                        break;
                    case "2":
                        SearchMovies(localMoviesTable);
                        break;
                    case "3":
                        AdminOperation();
                        break;
                    case "4":
                        EditProfile(localLoginTable);
                        break;
                }
                y_n = support.Yes_No();
            }while(y_n);
        }
        void SyncDatabase(DataTable updatedTable)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($@"select * from user_credentials where email = '{email}'", connection);
                loginAdapter = new SqlDataAdapter(command);
                cb = new SqlCommandBuilder(loginAdapter);
                loginAdapter.UpdateCommand = cb.GetUpdateCommand();
                loginAdapter.Update(updatedTable);
                loginAdapter.Dispose();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
        public override void EditProfile(DataTable profile)
        {
            int i = 0;
            foreach (DataColumn col in profile.Columns)
            {
                if (col.ColumnName.ToString().Equals("user_type") || col.ColumnName.ToString().Equals("date_of_registration"))
                {
                    continue;
                }
                Console.WriteLine($"{++i}. {col.ColumnName}");
            }
            string edit = support.GetStringInput("Field to Edit", new List<string>() { "email", "password", "user_name" });
            switch (edit)
            {

                case "email":
                    //profile = RowUpdate(profile, edit);
                    profile.Rows[0]["email"] = support.GetMailInput("Email :");
                    break;
                case "password":
                    String op = profile.Rows[0].ItemArray[1].ToString();
                    support.GetPasswordInput("password :", op);
                    profile.Rows[0]["password"] = support.GetPasswordInput("password :", op);
                    break;
                case "user_name":
                    profile.Rows[0]["user_name"] = support.GetStringInput("User Name: ");
                    break;
            }
            SyncDatabase(profile);
        }
        public override void ViewProfile(List<string> profile)
        {
            try
            {
                Console.WriteLine($"Email id : {profile[0]}");
                Console.WriteLine($"Session Id : {profile[1]}");
                Console.WriteLine($"User Name : {profile[3]}");
                Console.WriteLine($"Password: {profile[2]}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally { connection.Close(); }
        }
        public override void SearchMovies(DataTable localMoviesTable)
        {
            string user_movie_request = support.GetStringInput("Enter A movie to view");
            List<string> list = new List<string>();
            foreach (DataRow row in localMoviesTable.Rows)
            {
                int index = -1;
                foreach (DataColumn col in localMoviesTable.Columns)
                {
                    if (row.ItemArray[0].ToString().ToLower().Equals(user_movie_request))
                    {
                        Console.WriteLine($"{col.ColumnName}: {row.ItemArray[++index].ToString()}");
                    }

                }
            }
        }
        public void AdminOperation()
        {
            connection.Open();
            SqlCommand command = new SqlCommand(@"SELECT name FROM sys.Tables", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tables.Add(((reader["name"]).ToString()));
            }
            connection.Close();
            bool y_n = true;
            do
            {
                Console.WriteLine("Admin Operations");
                Console.WriteLine("Press 'C' to Create a table");
                Console.WriteLine("Press 'D' to Delete a table");
                Console.WriteLine("Press 'A' to Alter a table");
                Console.WriteLine("Press 'G' to get tablenames");
                Console.WriteLine("Press 'U' to update records");
                Console.WriteLine("Press 'I' to Insert records");

                Console.WriteLine();
                List<string> action = new List<string>() { "c", "d", "a", "g", "u", "i"};
                switch (support.GetStringInput("Enter Key", action))
                {
                    case "c":
                        Console.WriteLine(CreateTable());
                        break;
                    case "d":
                        Console.WriteLine(DeleteTable());
                        break;
                    case "a":
                        Console.WriteLine(AlterTable());
                        break;
                    case "g":
                        GetTableName();
                        break;
                    case "u":
                        UpdateTable();
                        break;
                    case "i":
                        InsertRecord();
                        break;
                }
                y_n = support.Yes_No();
            }
            while (y_n);
        }
        public void InsertRecord()
        {
            List<string> column = new List<string>();
            string tName = (support.GetStringInput("Enter Table Name"));
            column = GetColumn(tName);
            GetTableColumn(tName);
            List<string> record = new List<string>();
            foreach(string s in column)
            {
                record.Add(support.GetStringInput($"Enter {s}"));
            }
            string insertQuery = support.InsertQueryGenerator(tName, record,column);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void UpdateTable()
        {
            string updateQuery = UpdateQueryGenerator();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($@"{updateQuery}", connection);
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Update Successful");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally { connection.Close(); }


        }
        public string CreateTable()
        {

            string progress = "";
            string createQuery = "";
            createQuery = CreateQueryGenerator();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(createQuery, connection);
                command.ExecuteNonQuery();
                connection.Close();
                progress = "Table created successfully";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                progress = "Table creation failed";
            }
            finally { connection.Close(); }
            return progress;
        }
        private string CreateQueryGenerator()
        {
            string query = $"create table {support.GetStringInput("Enter Table name to create")} (";
            int n = support.GetNumberInput("Enter the number of columns in Table");
            List<string> columnName = new List<string>();
            List<string> columnType = new List<string>();
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    columnName.Add(support.GetStringInput("Enter primary key name"));
                    columnType.Add($"{support.GetStringInput("Enter Key type")} not null");
                    continue;
                }
                columnName.Add(support.GetStringInput("Enter Column name"));
                columnType.Add(support.GetStringInput("Enter Data type"));
            }
            for (int i = 0; i < columnName.Count; i++)
            {
                if (i == columnName.Count - 1)
                {
                    query += $"{columnName[i]} {columnType[i]}, ";
                    query += $" constraint {support.GetStringInput("Enter Primary key constraint name")} primary key({columnName[0]}) )";
                    break;
                }
                query += $"{columnName[i]} {columnType[i]}, ";
            }
            Console.WriteLine(query);
            return query;
        }
        public string DeleteTable()
        {
            string progress = "";
            string deleteQuery = "";
            deleteQuery = $@"{DeleteQueryGenerator()}";
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(@deleteQuery, connection);
                command.ExecuteNonQuery();
                connection.Close();
                progress = "Table deleted successfully";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return progress;
        }
        private string DeleteQueryGenerator()
        {
            GetTableName();
            string query = $"drop table {support.GetStringInput("Enter table name to delete", tables)}";
            Console.WriteLine(query);
            return query;
        }
        public string AlterTable()
        {
            string progress = "";
            string alterQuery = AlterQueryGenerator();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(alterQuery, connection);
                command.ExecuteNonQuery();
                connection.Close();
                progress = "Column altered successfully";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                progress = "Column alteration failed";
            }
            finally
            {
                connection.Close();
            }
            return progress;
        }
        private string AlterQueryGenerator()
        {
            string query = $"alter table {support.GetStringInput("Enter table name to alter", tables)} ";
            List<string> alteraction = new List<string>();
            alteraction.Add("add");
            alteraction.Add("drop");
            string alterMode = $"{support.GetStringInput("Enter Add / Drop", alteraction)}";
            if (alterMode.Equals("add"))
            {
                query += $"{alterMode} {support.GetStringInput("Enter Column to add")} {support.GetStringInput("Enter Data type")}";
            }
            else
            {
                query += $"{alterMode} column {support.GetStringInput("Enter Column to Delete")}";
            }
            return query;
        }
        public void GetTableName()
        {
            for (int i = 0; i < tables.Count/2; i++)
            {
                Console.WriteLine($"{i + 1}. {tables[i]}");
            }
        }
        private string UpdateQueryGenerator()
        {
            string tName = support.GetStringInput("Table name:", tables);
            Console.WriteLine($"Columns in {tName}");
            GetTableColumn(tName);
            Console.WriteLine();
            string col = support.GetStringInput("Enter Column to update");
            string query = $"update {tName} set  {col} = '{support.GetStringInput("Enter Update Value")}' where {GetPrimaryKey(tName)} = '{support.GetStringInput("Key to Update")}'";
            Console.WriteLine(query);
            return query;
        }
        public string GetPrimaryKey(string tableName)
        {
            string key = "";
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($@"SELECT name FROM sys.columns WHERE object_id = OBJECT_ID('{tableName}')", connection);
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    key = reader["name"].ToString();
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();

            }
            return key;
        }
        public void GetTableColumn(string tableName)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($@"SELECT name FROM sys.columns WHERE object_id = OBJECT_ID('{tableName}')", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["name"].ToString());
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
            

        }

    }

}
