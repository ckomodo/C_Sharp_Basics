using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    //PARTS OF A FUNCTION
    /*
     1. Prototype - defines the function (type, name and parameters)
     2. Defintion - this is the code block
     3. Function call - Code that executes the function
     */
    //TYPES OF FUNCTIONS
    /*
     Void Functions - completes a task and moves along
    Value-Returning - completes a task and returns a result
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            //void function
            void PrintName()
            {
                Console.WriteLine("c# developer");
            }
            void Addition(int num1, int num2)
            {
                Console.WriteLine($"the sum of {num1} and {num2} is {num1 + num2}");
            }

            int LargestNumber(int num1, int num2, int num3)
            {
                int largest = num1;
                if (largest < num2)
                {
                    num2 = largest;
                }
                if (largest < num3)
                {
                    largest = num3;
                }

                return largest;
            }

            PrintName();
            Console.WriteLine("end of void function");

            Console.WriteLine("enter number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Addition(number1, number2);
            Console.WriteLine("end of void function");

            Console.WriteLine("enter number 3: ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            int result = LargestNumber(number1, number2, number3);
            Console.WriteLine($"the largest number is {result}");
        }
    }
}
