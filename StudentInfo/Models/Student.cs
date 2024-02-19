using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.Models
{
    public class Student : Person
    {

        public int SId { get; set; }

        public int RollNo { get; set; }

        public int Standard {  get; set; }

        public int TId {  get; set; }

        public Teacher ClassTeacher { get; set; }

        public Student(
            int sid, 
            int rollno, 
            int standard, 
            int tid, 
            string name, 
            string address, 
            string postalcode, 
            string phonenumber, 
            string city, 
            string bloodgroup, 
            DateOnly dOB, 
            Teacher classteacher) 
            
            : base(name, address, postalcode, phonenumber, city, bloodgroup, dOB)

        {
            
            SId = sid;
            RollNo = rollno;
            Standard = standard;
            TId = tid;
            ClassTeacher = classteacher;
            

        }


    }
}
