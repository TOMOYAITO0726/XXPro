using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS21
{
    internal class Customer
    {
        public string FirstName;
        public string LastName;

        public Customer(string firstName, string lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Customer(string lastName) : this("--", lastName) 
        {
            LastName += "AAAA";
        }
        

        public string GetFullName()
        { 
            return LastName + FirstName;
        }

    }
}
