using System;
using System.Text.RegularExpressions;

namespace Lab3Solutions
{
    public class Q2
    {
        public static void Main(String[] args)
        {

        }

        public string ReverseWords(string s)
        {
            s = Regex.Replace(s, @" +", " ").Trim();
            string[] words = s.Split(" ");

            return String.Join(" ", words.Reverse());

        }
    }
}

