using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace EmailRegex
{
    class EmailPattern
    {
        string Regex_Email = "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public bool ValidateEmail(string pincode)
        {
            return Regex.IsMatch(pincode, Regex_Email);
        }
    }
}
