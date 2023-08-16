using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPractice
{
    internal class Employee
    {

        // fields
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthDay;

        const int minimalHoursWorkedUnit = 1;

        //Constructor if only given 4 values 
        public Employee(string First, string Last, string em, DateTime bd) : this(First, Last, em, bd, 0)
        {

        }

        //Default constructor
        public Employee(string first, string Last, string em, DateTime bd, double rate) 
        {
            firstName = first;
            lastName = Last;
            email = em;
            birthDay = bd;
            hourlyRate = rate;
        }

        // Method that adds to the numberOfHoursWorked and prints it
        public void PerformWork()
        {
            //Initailly this method just added one to numberOfHoursWorked but I updated it to call PerformWork give it 1 as a paramtrer.
            //numberOfHoursWorked++;
            PerformWork(minimalHoursWorkedUnit);
            //Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hours!");
        }

        // Methods overloading 
        // Method that adds to the numberOfHoursWorked and prints it but, you get to pick how many hours is worked
        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hour(s)!");
        }

        //Calculates wages and prints them
        public double RecieveWage(bool resetHours = true)
        {
            wage = numberOfHoursWorked * hourlyRate;

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hour(s) of work.");

            if (resetHours)
                numberOfHoursWorked = 0;

            return wage;
        }

        //Prints the name, lastname, email, and birthday of employees
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}\nBirthday: \t{birthDay.ToShortDateString()}\n");
        }
    }
}
