using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.Models
{
    public class Teacher :Person
    {
        public int TId { get; set; }
        public string Qualification { get; set; }

        public Teacher()
        {
            
        }

        public Teacher(int tid, string qualification, string name, string address, string postalcode, string phonenumber, string city, string bloodgroup, DateOnly dOB) 
            
            : base(name, address, postalcode, phonenumber, city, bloodgroup, dOB)
        
        {
            TId = tid;
            Qualification = qualification;

        }

    }
}
