using System;
using System.Collections.Generic;

namespace classes {
    public class Company {
        public string CompanyName { get; }

        public DateTime DateFounded { get; }
        //creating a public property for listing the employees

        public List<Employee> Employees = new List<Employee> ();

        //  The constructor will set the value of the public properties
        // 
        public Company (string name, DateTime date) {
            CompanyName = name;
            DateFounded = date;
        }
        //this is a method that takes an employee as an argument
        public void AddEmployeeToCompany (Employee employee) {
            Employees.Add (employee);
        }
        public void ListEmployees () {
            foreach (Employee employee in Employees) {
                Console.WriteLine ($"{employee.FirstName} {employee.LastName}");
            }

        }
    }
    public class Employee {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public DateTime StartDate { get; set; }
        //This is the Employee Constructor below
        public Employee (string first, string last, string title, DateTime start) {
            FirstName = first;
            LastName = last;
            Title = title;
            StartDate = start;
        }

    }
    class Program {

        static void Main (string[] args) {
            Employee Sam = new Employee ("Sam", "Parton", "Mandolin and Singer", DateTime.Now);
            Employee Melissa = new Employee ("Melissa", "Carper", "Bass", DateTime.Now);
            Employee Joe = new Employee ("Joe", "Sundell", "Banjo and Harmonica", DateTime.Now);
            Company SadDaddy = new Company ("Sad Daddy", DateTime.Now);

            SadDaddy.AddEmployeeToCompany (Sam);
            SadDaddy.AddEmployeeToCompany (Melissa);
            SadDaddy.AddEmployeeToCompany (Joe);

            SadDaddy.ListEmployees ();
        }

    }
}