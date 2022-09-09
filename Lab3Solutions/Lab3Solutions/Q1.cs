using System;
using System.Text.RegularExpressions;

namespace Lab3Solutions
{
    public class Q1
    {
        public static void Main(String[] args)
        {

        }

        public bool IsPalindrome(string s)
        {
            s = Regex.Replace(s, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled).ToLower();
            return s.Equals(strRev(s));
        }

        private string strRev(string s)
        {
            char[] cArr = s.ToCharArray();
            Array.Reverse(cArr);

            return new string(cArr);
        }
    }
}

