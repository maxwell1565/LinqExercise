﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

           var sum = numbers.Sum();
            Console.WriteLine($"Sum of numbers = {sum}");

            //TODO: Print the Average of numbers

            var avg = numbers.Average();
            Console.WriteLine($"Average of numbers = {avg}");

            //TODO: Order numbers in ascending order and print to the console

            var sortedNumbers = numbers.OrderBy(num => num);
            Console.WriteLine("Ascending Order:");
            foreach (var num in sortedNumbers)
            {
                Console.WriteLine($"{num}");
            }

            //TODO: Order numbers in descending order and print to the console

            var sortedNumberz = numbers.OrderByDescending(num => num);
            Console.WriteLine("Descending Order:");
            foreach (var num in sortedNumberz)
            {
                Console.WriteLine($"{num}");
            }

            //TODO: Print to the console only the numbers greater than 6

            var greaterThanSix = numbers.Where(num => num > 6);
            Console.WriteLine("Nums greater than 6:");
            foreach (var num in greaterThanSix)
            {
                Console.WriteLine(num);
            }
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**

            var fourNumsDescending = numbers.OrderByDescending(num => num).Take(4);
            Console.WriteLine("Four nums decending:");
            foreach (var num in fourNumsDescending)

             
            {
                Console.WriteLine(num);
            }

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order

            numbers[4] = 26;
            var numsDecendingAge = numbers.OrderByDescending(num => num);

            Console.WriteLine("Numbers with decending age:");
            foreach (var num in numsDecendingAge)

                
            {
                Console.WriteLine(num);
            }

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            var filtered = employees.Where(person => person.FirstName.ToLower().StartsWith('c') || person.FirstName.ToLower()[0] == 's')
                           .OrderBy(person => person.FirstName);

            Console.WriteLine("----");
            foreach (var person in filtered)
            {
                Console.WriteLine(person.FullName);
            }

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            var filteredAgeFirst = employees.Where(person => person.Age > 26).OrderByDescending(person => person.Age).ThenBy(person => person.FirstName.ToLower());

            Console.WriteLine("----");
            foreach (var human in filteredAgeFirst)
            {
                Console.WriteLine($"{human.FullName} age:{human.Age}");
            }

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            var experience = employees.Where(person => person.YearsOfExperience <= 10 || person.YearsOfExperience >= 35).Sum(person => person.YearsOfExperience);

            Console.WriteLine("----");
            Console.WriteLine($"YOE: {experience} ");
           
           

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            var avgExperience = employees.Where(person => person.YearsOfExperience <= 10 || person.YearsOfExperience >= 35).Average(person => person.YearsOfExperience);

            Console.WriteLine("----");
            Console.WriteLine($" Average YOE: {avgExperience} ");


            //TODO: Add an employee to the end of the list without using employees.Add
            //

            Console.WriteLine("----");

            Employee newEmployee = new Employee
            {
                FirstName = "Max",
                LastName = "Stangler",
                Age = 26,
                YearsOfExperience = 1,
            };

            employees = employees.Concat(new[] { newEmployee }).ToList();

            foreach (var employee in employees)
            {
                Console.WriteLine($"Full Name: {employee.FullName}, Age: {employee.Age}, YOE: {employee.YearsOfExperience}");
            }


          

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
