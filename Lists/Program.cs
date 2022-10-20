using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();//declare a list
            string name = string.Empty;

            //adding values to a list
            //names[0] = "TestName";
            names.Add("John");
            //names.Remove("Trevoir");

            Console.WriteLine("Enter names: ");

            while (name != "-1")
            {
                Console.Write("Enter name: ");
                name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name) && !name.Equals("-1"))
                {
                    names.Add(name);
                    Console.WriteLine($"{name} was added successfully");

                }
            }
             
            //print the List
            Console.WriteLine("printing List using a for loop");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]); 
            }

            Console.WriteLine("printing List using a for each loop");
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }

        }
    }
}
