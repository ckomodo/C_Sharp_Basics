using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Person
    {
        //properties when public
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //called "fields" when using private keyword
        private double _salary { get; set; } //can be accessed only using a method

        public void setSalary(double salary) //to set the value in the private field _salary
        {
            _salary = salary; //_salary's value
        }

        public double getSalary() //to retrieve salary's value
        {
            return _salary; //returns the value set in setSalary method
        }

        public string getFullName()
        {
            return $"{FirstName} {LastName}";
        }

        //public int yearOfBirth(int Dob)
        //{

        //    Dob = 2022 - Age;

        //    return Dob; 
        //}

        public string getFullName(string middleName)
        {
            return $"{FirstName} {middleName} {LastName}";
        }
    }
}
