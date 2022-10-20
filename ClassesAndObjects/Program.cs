using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            string middleName = string.Empty;

            Console.WriteLine("enter first name: ");
            person.FirstName = Console.ReadLine();

            Console.WriteLine("enter last name: ");
            person.LastName = Console.ReadLine();

            Console.WriteLine("enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("enter salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter middle name: ");
            middleName = Console.ReadLine();

            if (string.IsNullOrEmpty(middleName))
            {
                Console.WriteLine("Full name is: " + person.getFullName());
            }
            else
            {
                Console.WriteLine("Full name is: " + person.getFullName(middleName));

            }

            person.setSalary(salary);
            //Console.WriteLine("Salary is: " + person.getSalary());


            //Console.WriteLine("First name is: " + person.FirstName);
            //Console.WriteLine("Last name is: " + person.LastName);
            Console.WriteLine("Age is: " + age);
            Console.WriteLine("Year of birth is: " + DateUtil.YearOfBirth(person.Age));

            //Console.WriteLine("You were born in: " + person.yearOfBirth(Dob));
            Console.WriteLine("Salary is: " + person.getSalary());

            

        }
    }
}
