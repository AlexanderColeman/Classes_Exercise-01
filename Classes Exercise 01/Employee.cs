using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Exercise_01
{
    public class Employee
    {

        private string _password;

        public Employee(string password, string firstName, char middleInitial, string lastName, string phoneNumber, string title, string dateOfBirth)
        {
            _password = password;
            FirstName = firstName;
            MiddleInitial = middleInitial;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Title = title;
            DateOfBirth = dateOfBirth;
        }

        public string FirstName { get; set; }
        public char MiddleInitial { get; set; }
        public string LastName { get; set; } 
        public string PhoneNumber { get; set; }
        public string Title { get; set; }
        public string DateOfBirth { get; set; }

        public void DisplayPassword()
        {
            Console.WriteLine(_password);
        }

        public void EmployeeReport()
        {
            var Header = "{0,-20}{1,-20}{2,-20}{3,-15}{4,-10}{5,-10}";
            Console.WriteLine(Header, "First Name", "Middle Initial", "Last Name", "Phone Number", "Title", "Date Of Birth");
            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            Console.WriteLine(Header, FirstName, MiddleInitial, LastName, PhoneNumber, Title, DateOfBirth);
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }
    }
}
