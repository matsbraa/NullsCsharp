using System;
using System.Collections.Generic;
using System.Text;

#nullable enable

namespace NullableDemo
{
    public class Person
    {
        public string FirstName;
        public string? MiddleName;
        public string LastName;

        public Address? Address { get; set; }
        public string Country => Address?.Country;   // ERROR! CS8603

        
    }
}
