using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter number of apples: ");
            //int apples = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter number of oranges: ");
            //int oranges = Convert.ToInt32(Console.ReadLine());

            //if statements
            //if (apples > oranges)
            //{ 
            //    Console.WriteLine("you have more apples ");
            //}
            //else if (apples < oranges)
            //{
            //    Console.WriteLine("You have more oranges");
            //} 
            //else if (apples == oranges)
            //{
            //    Console.WriteLine("you have an equal amount of apples and oranges");
            //}

            //switch statements
            Console.WriteLine("enter number final grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            switch (grade)
            {
                case int n when n >=0 && n<= 59:
                    Console.WriteLine("you failed");
                    break;
                case int n when n >= 60 && n <=100:
                    Console.WriteLine("you got passed");
                    break ;
                 default:
                    Console.WriteLine("Invalid grade");
                    break;

            }

            //ternary operator
             

            Console.ReadLine();
        }
    }
}
