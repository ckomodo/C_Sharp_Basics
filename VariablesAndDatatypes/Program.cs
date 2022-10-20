using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDatatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = string.Empty;
            int age = 0;
            double salary = 0;
            char gender = char.MinValue;
            bool working = false;


            Console.Write("please enter your name: ");
            fullName = Console.ReadLine();

            Console.Write("please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("please enter your salary: ");
            salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("please enter your gender: (M or F) ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.Write("Are you working? (true or false): ");
            working = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Your name is: " + fullName);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine($"Your salary is: {salary}"); //interpolation
            Console.WriteLine($"Your gender is: {gender}");
            Console.WriteLine($"Your are employed: {working}");
            Console.ReadLine();

        }
    }
}
