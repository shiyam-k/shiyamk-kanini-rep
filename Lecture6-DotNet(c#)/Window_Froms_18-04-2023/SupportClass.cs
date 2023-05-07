using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Window_Froms_18_04_2023
{
    internal class SupportClass
    {
        List<string> tables = new List<string>();
        static string connectionSource = "Data Source=LAPTOP-OJCNGD2Q\\SQLEXPRESS;Initial Catalog=bingersbible;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectionSource);
        public SupportClass()
        {
            connection.Open();
            SqlCommand command = new SqlCommand(@"SELECT name FROM sys.Tables", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tables.Add(((reader["name"]).ToString()));
            }
            connection.Close();
        }
        public bool Yes_No()
        {
            bool res = false;

            do
            {
                string s = GetStringInput("Want to continue? Y/N");
                if (s.Equals("y"))
                {
                    res = true;
                    break;
                }
                else if (s.Equals("n"))
                {
                    res = false;
                    break;
                }
                else
                {
                    continue;
                }
            } while (true);
            return res;
        }

        public int GetNumberInput(string s)
        {
            int res = 0;
            do
            {
                try
                {
                    Console.WriteLine($"{s} : ");
                    res = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (true);
            return res;
        }
        public string GetStringInput(string s)
        {
            string res = "";
            do
            {
                try
                {
                    Console.WriteLine($"{s}");
                    res = Console.ReadLine();

                    if (!res.Equals(""))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("**String cannot be Empty**");
                        Console.WriteLine("");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);
            return res;
        }
        public bool MailValidate(string s)
        {
            string res = "";
            var valid = true;
            try
            {
                var emailAddress = new MailAddress(s);
            }
            catch(Exception e) 
            {
                valid = false;
            }
            finally
            {
                
            }
           
           return valid;

        }
        public bool PasswordValidate(string s)
        {
            bool valid = true;
            try
            {
                Regex passwordValidator = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
                if (passwordValidator.IsMatch(s))
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                }
            }
            catch (Exception e)
            {
                valid = false;
            }
            return valid;
        }
        public string GetPasswordInput(string s, string pwd)
        {
            string res = "";
            do
            {
                res = "";
                if (res.Equals(pwd))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Passwords Dont match");
                    continue;
                }
            }
            while (true);
            return res;
        }
        public string GetStringInput(string s, string key)
        {
            string res = "";
            do
            {
                try
                {
                    Console.WriteLine($"Enter {s}");
                    res = Console.ReadLine().ToLower();

                    if (res.Equals(key))
                    {
                        break;
                    }
                    else if (!res.Equals(key))
                    {
                        Console.WriteLine($"{s}s dont match");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("**String cannot be Empty**");
                        Console.WriteLine("");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);
            return res;
        }
        public dynamic GetStringInput(string s, List<string> resArr)
        {
            resArr.Sort();
            string key = "";
            dynamic res = "";
            do
            {
                try
                {
    
                    if (key.Equals("0"))
                    {
                        break;
                    }
                    else if (key.Equals(""))
                    {
                        continue;
                    }
                    else if (resArr.Count > 0)
                    {
                        res = BSearch(resArr, key);
                        if (!res.Equals(key))
                        {
                            Console.WriteLine($"No {s} found");
                        }
                        else if (res.Equals(key))
                        {
                            break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);
            return res;
        }
        public string BSearch(List<string> resArr, string key)
        {
            //int res = resArr.BinarySearch(key);
            //Console.WriteLine(res);
            string res = "";
            int l = 0, r = resArr.Count - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;
                int re = key.CompareTo(resArr[m]);
                if (re == 0)
                {
                    res = resArr[m];
                    break;
                }
                if (re > 0)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }

            if (res.Equals(""))
            {
                Console.WriteLine("**No input keys found **");
                return "";
            }
            return res;
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();

            }
            return columns;
        }
        public string InsertQueryGenerator(string tablename, List<string> records, List<string> columns)
        {
            string insertColumns = "(";
            string insertValues = "(";
            foreach (string value in columns)
            {
                if (value.Equals(columns[columns.Count - 1]))
                {
                    insertColumns += $"{value})";
                    break;
                }
                insertColumns += $"{value},";
            }
            foreach (string value in records)
            {
                if (value.Equals(records[records.Count - 1]))
                {
                    insertValues += $"'{value}')";
                    break;
                }
                insertValues += $"'{value}',";
            }
            string query = $"insert into {tablename}{insertColumns} values {insertValues}";
            //Console.WriteLine(query);
            return query;
        }
        public void GetTableName()
        {
            tables = null;
            connection.Open();
            SqlCommand command = new SqlCommand(@"SELECT name FROM sys.Tables", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tables.Add(((reader["name"]).ToString()));
            }
            connection.Close();

            for (int i = 0; i < tables.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tables[i]}");
            }
        }
        private string UpdateQueryGenerator()
        {
            string tName = GetStringInput("Table name:", tables);
            Console.WriteLine($"Columns in {tName}");
            GetTableColumn(tName);
            Console.WriteLine();
            string col = GetStringInput("Enter Column to update");
            string query = $"update {tName} set  {col} = '{GetStringInput("Enter Update Value")}' where {GetPrimaryKey(tName)} = '{GetStringInput("Key to Update")}'";
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
                if (reader.Read())
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
        private string AlterQueryGenerator()
        {
            string query = $"alter table {GetStringInput("Enter table name to alter", tables)} ";
            List<string> alteraction = new List<string>();
            alteraction.Add("add");
            alteraction.Add("delete");
            string alterMode = $"{GetStringInput("Enter Add / Drop", alteraction)}";
            if (alterMode.Equals("add"))
            {
                query += $"{alterMode} {GetStringInput("Enter Column to add")} {GetStringInput("Enter Data type")}";
            }
            else
            {
                query += $"{alterMode} column {GetStringInput("Enter Column to Delete")}";
            }
            Console.WriteLine(query);
            return query;
        }
        private string CreateQueryGenerator()
        {
            string query = $"create table {GetStringInput("Enter Table name to create")} (";
            int n = GetNumberInput("Enter the number of columns in Table");
            List<string> columnName = new List<string>();
            List<string> columnType = new List<string>();
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    columnName.Add(GetStringInput("Enter primary key name"));
                    columnType.Add($"{GetStringInput("Enter Key type")} not null");
                    continue;
                }
                columnName.Add(GetStringInput("Enter Column name"));
                columnType.Add(GetStringInput("Enter Data type"));
            }
            for (int i = 0; i < columnName.Count; i++)
            {
                if (i == columnName.Count - 1)
                {
                    query += $"{columnName[i]} {columnType[i]}, ";
                    query += $" constraint {GetStringInput("Enter Primary key constraint name")} primary key({columnName[0]}) )";
                    break;
                }
                query += $"{columnName[i]} {columnType[i]}, ";
            }
            Console.WriteLine(query);
            return query;
        }
        private string DeleteQueryGenerator()
        {
            GetTableName();
            string query = $"drop table {GetStringInput("Enter table name to delete", tables)}";
            Console.WriteLine(query);
            return query;
        }
    }
}
