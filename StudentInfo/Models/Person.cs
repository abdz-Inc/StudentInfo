using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string BloodGroup { get; set; }
        public DateOnly DOB { get; set; }


        public Person() { }

        public Person( string name, string address, string postalcode, string phonenumber, string city, string bloodgroup,  DateOnly dOB)
        
        {
            Name = name;
            Address = address;
            PostalCode = postalcode;
            PhoneNumber = phonenumber;
            City = city;
            BloodGroup = bloodgroup;
            DOB = dOB;

        }
    }
}
