using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EF_Code_First_26_04_2023
{
    internal class SupportClass
    {
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
                    Console.WriteLine($"Enter {s} : ");
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
        public string GetMailInput(string s)
        {
            string res = "";
            bool y_n = true;
            do
            {
                res = GetStringInput(s);
                var valid = true;
                try
                {
                    var emailAddress = new MailAddress(res);
                }
                catch (Exception e)
                {
                    Console.WriteLine("**Incorrect email Format**");
                    valid = false;
                }
                finally
                {
                    if (valid)
                    {
                        y_n = false;
                    }

                }

            }
            while (y_n);
            return res;

        }
        public string GetPasswordInput(string s)
        {
            string res = "";
            do
            {
                res = GetStringInput($"{s}");
                try
                {
                    Regex passwordValidator = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
                    if (passwordValidator.IsMatch(res))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Password must contain 1 special character, 1 uppercase, 1 number");
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (true);
            return res;
        }
        public string GetPasswordInput(string s, string pwd)
        {
            string res = "";
            do
            {
                res = GetPasswordInput($"{s}");
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
                    if (s.Equals("Email"))
                    {
                        key = GetMailInput($"Enter {s} :");
                    }
                    else
                    {
                        key = GetStringInput($"Enter {s} :");
                    }
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
    }
}
