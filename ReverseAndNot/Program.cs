using System;
using System.Linq;

namespace ReverseAndNot
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseAndNot(123456789));
        }

        public static string ReverseAndNot(int i)

        {
            string myString = i.ToString();

            string reverseValue = new string(myString.Reverse().ToArray());

            string result = String.Concat(reverseValue, myString);

            return result;
        }
    }
}