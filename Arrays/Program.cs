using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare fixed size array
            //int[] grades = new int[4];

            //Console.WriteLine("Enter all grades");

            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.Write("enter a grade: ");
            //    grades[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("the grades you have entered are: ");
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.Write(grades[i] + ", ");
            //}

            string[] studentName = new string[] {"test", "Student1", "studentMore"};

            Console.WriteLine("Add more names: ");

            for (int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine("enter a name: ");
                studentName[i] = Console.ReadLine();
            }

            Console.WriteLine("the names entered are: ");
            for (int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine(studentName[i]);
            }


        }

    }
}
