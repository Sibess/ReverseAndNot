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
            string defaultValues = i.ToString();

            string reversedValues = new string(defaultValues.Reverse().ToArray());

            string result = String.Concat(reversedValues, defaultValues);

            return result;
        }
    }
}
