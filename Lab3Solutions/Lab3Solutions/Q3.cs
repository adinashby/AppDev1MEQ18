using System;
using System.Text.RegularExpressions;

namespace Lab3Solutions
{
    public class Q3
    {
        public static void Main(String[] args)
        {

        }

        public int MyAtoi(string str)
        {
            if (Regex.IsMatch(str, "^\\s*[-+]?[0-9]+.*"))
            {
                var match = Regex.Match(str, "^\\s*[-+]?[0-9]+").ToString().Replace(" ", "");

                try
                {
                    return Convert.ToInt32(match);
                }
                catch
                {
                    if (match[0] == '-')
                        return Int32.MinValue;
                    return Int32.MaxValue;
                }
            }
            return 0;
        }
    }
}

