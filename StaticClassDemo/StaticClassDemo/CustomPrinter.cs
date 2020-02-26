using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassDemo
{
    public static class CustomPrinter
    {
        public static string QuoteIt(string toQuote, string author)
        {
            return "\"" + toQuote + "\" - " + author;

        }

        public static int CountVowel(string phrase)
        {
            char[] vowels = { 'a', 'e', 'o', 'i', 'u' };
            char[] charArr = phrase.ToLower().ToCharArray();

            int vowelsFound = 0;
            foreach(char v in vowels)
            {
                vowelsFound += charArr.Where(ch => ch == v).Count();
            }

            return vowelsFound;
        }

        public static string UpperLower(string toChange)
        {
            StringBuilder sb = new StringBuilder(toChange);

            for(int i = 0; i<toChange.Length; i++)
            {
                if( i % 2 == 0)
                {
                    sb[i] = Char.ToUpper(sb[i]);
                }
                else
                {
                    sb[i] = Char.ToLower(sb[i]);
                }
            }
            return sb.ToString();
        }

        public enum StringBuilding
        {
            Conatenation,
            StringBuilder
        }

        public static long StringBuildTest(long countTo,StringBuilding testType)
        {
            long milliseconds = 0;
            Stopwatch sw = new Stopwatch();

            sw.Start();

            if(testType == StringBuilding.StringBuilder)
            {
                StringBuilder sb = new StringBuilder();

                for(int i = 0; i<countTo; i++)
                {
                    sb.Append(i.ToString());
                }
            }
            else
            {
                string test = "";
                for(int i = 0; i< countTo; i++)
                {
                    test += i.ToString();
                }
            }

            sw.Stop();
            milliseconds = sw.ElapsedMilliseconds;

            return milliseconds;
        }
    }
}
