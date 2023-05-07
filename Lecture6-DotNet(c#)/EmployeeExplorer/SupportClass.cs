using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;

namespace EmployeeExplorer
{
    public class SupportClass
    {
        public bool MailValidate(string s)
        {
            string res = "";
            var valid = true;
            try
            {
                var emailAddress = new MailAddress(s);
            }
            catch (Exception e)
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
    }
}