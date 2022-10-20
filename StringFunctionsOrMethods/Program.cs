using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctionsOrMethods
{
   
    internal class Program
    {
       
        static void Main(string[] args)
        {
            string firstName = "majina";
            string lastName = "languNaZangu";

            //print to screen
            Console.WriteLine(firstName);
            Console.WriteLine("string being printed");

            //concatenation
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine("my full name is " + lastName + " " + firstName);
            Console.WriteLine($"my full name is {lastName} { firstName}");
            Console.WriteLine();

            //string length
            int length = firstName.Length;
            Console.WriteLine($"your first name has {length} letters");
            Console.WriteLine();

            //replace string parts
            Console.WriteLine("**************");
            string newName = firstName.Replace('j', 'n');
            Console.WriteLine("your new name is " + newName);

            string newName1 = newName.Replace('n', 'l');
            Console.WriteLine($"your newest name is {newName1}");

            //split string
            string[] splitName = newName1.Split('n');
            
                for (int i = 0; i < splitName.Length; i++)
                {
                Console.WriteLine(splitName[i]);
                }

            //string comparisons.

            string nullString = null;
            string emptyString = "";
            string whiteSpaceString = " ";

            if (String.IsNullOrEmpty(nullString))
            {
                Console.WriteLine("string is null");
            }

            if (firstName == lastName)
            {
                Console.WriteLine("names are equal");
            }

            if (firstName != lastName)
            {
                Console.WriteLine("names are not equal");
            }

            int comparisonResult = string.Compare(firstName, lastName);
            if (comparisonResult == 0)
            {
                Console.WriteLine("names are equal");
            }
            else
            {
                Console.WriteLine("names are not equal");

            }
        }
    }
}
