using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.firstName = "Ngo";
            customer.lastName = "Anh Tu";
            customer.phoneNumber = "090234455";
            customer.emailAddress = "t@gmail.com";
            Console.WriteLine("You first name is " + customer.firstName);
            Console.ReadLine();
        }
    }
    public class Customer
    {
        public string firstName;
        public string lastName;
        public string phoneNumber;
        public string emailAddress;

        public string GetFullNamee()
        {
            return firstName + " " + lastName;
        }
    }
}