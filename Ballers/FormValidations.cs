using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ballers
{
    public class FormValidations
    {
        public FormValidations()
        {
        }

        Dictionary<string, string> result = new Dictionary<string, string> { };

        /// <summary>
        /// @param param name="userPassword"
        /// @param name="userEmail"
        /// This method will provide result of validation based on userEmail and password provided 
        /// </summary>
        public Dictionary<string, string> LoginValidation(String userEmail, String userPassword)
        {
            if (userEmail == null || userEmail == "")
            {
                result.Add("Result", "Fail");
                result.Add("Message", Message.USER_EMAIL_REQUIRED_MESSAGE);
            }
            else if (!Regex.IsMatch(userEmail, Message.EMAIL_REGEX))
            {
                result.Add("Result", "Fail");
                result.Add("Message", Message.VALID_EMAIL_REQUIRED_MESSAGE);
            }
            else if (userPassword == null || userPassword == "")
            {
                result.Add("Result", "Fail");
                result.Add("Message", Message.PAASWORD_REQUIRED_MESSAGE);
            }
            else
            {
                result.Add("Result", "Success");
                result.Add("Message", "Login Success");
            }
            return result;
        }

        public Dictionary<string, string> signUpValidation(String userName, String userEmail, String userPassword, String confirmPassword)
        {
            if (userName == null || userName == "")
            {
                result.Add("Result", "Fail");
                result.Add("Message", Message.USERNAME_REQUIRED_MESSAGE);
                return result;
            }
            if (userEmail == null || userEmail == "")
            {
                result.Add("Result", "Fail");
                result.Add("Message", Message.USER_EMAIL_REQUIRED_MESSAGE);
                return result;
            }
            else if (!Regex.IsMatch(userEmail, Message.EMAIL_REGEX))
            {
                result.Add("Result", "Fail");
                result.Add("Message", Message.VALID_EMAIL_REQUIRED_MESSAGE);
                return result;
            }

            if (userPassword == null || userPassword == "")
            {
                result.Add("Result", "Fail");
                result.Add("Message", Message.PAASWORD_REQUIRED_MESSAGE);
                return result;
            }
            else if (confirmPassword == null || confirmPassword == "")
            {
                result.Add("Result", "Fail");
                result.Add("Message", Message.CONFIRM_PASSWORD_REQUIRED);
                return result;
            }
            else if (userPassword.Length < 4)
            {
                result.Add("Result", "Fail");
                result.Add("Message", Message.PSW_LENGTH);
                return result;
            }
            else if (userPassword.Contains(" ") || confirmPassword.Contains(" "))
            {
                result.Add("Result", "Fail");
                result.Add("Message", Message.PASSWORD_DOES_NOT_CONTAIN_WHITESPACES);
                return result;
            }
            else if (userPassword != confirmPassword)
            {
                result.Add("Result", "Fail");
                result.Add("Message", Message.PASSWORD_MATCH_REQUIRED);
                return result;
            }
            else
            {
                result.Add("Result", "Success");
                result.Add("Message", "Login Success");
                return result;
            }
        }
    }
}
