using StudentInfo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.ViewModel
{
    public class StaticViewModel
    {
        public ObservableCollection<Student> Students {  get; set; }
        public ObservableCollection<Teacher> Teachers {  get; set; }

        public ObservableCollection<Teacher> StaticallyGenerateTeachers()
        {
            Teacher t1 = new Teacher(1, "PG","VeeraRaghavan", "33, West Street", "620102", "1234567890","Chennai","B+",new DateOnly(1987, 10, 3));
            Teacher t2 = new Teacher(2, "PHD", "MuthuvelPandian", "12, Adyar", "620017", "9023765416", "Chennai", "A+", new DateOnly(1978, 12, 12));
            return new ObservableCollection<Teacher>{ t1, t2};
        }

        public ObservableCollection<Student> StaticallyGenerateStudents()
        {
            Student s1 = new Student(1,1, 2, 1, "Abdz", "trichy", "620102", "9089877665", "trichy", "A2B-", new DateOnly(2011, 2, 3), Teachers.ElementAt<Teacher>(0));
            Student s2 = new Student(2,1, 6, 2, "Abinaya", "Kaattumannarkovil", "6200187", "1982780935", "kaattumannarkovil", "B-", new DateOnly(2005, 6, 3), Teachers.ElementAt<Teacher>(1));
            Student s3 = new Student(3,2, 6, 2, "Archana", "trichy", "620019", "7089604321", "trichy", "A-", new DateOnly(2005, 12, 9), Teachers.ElementAt<Teacher>(1));
            Student s4 = new Student(4,3, 2, 2, "Theeraj", "madurai", "629018", "9501203920", "madurai", "O-", new DateOnly(2005, 4, 13), Teachers.ElementAt<Teacher>(0));
            Student s5 = new Student(5,2, 2, 1, "Ashwin", "coimbatore", "620008", "6893709832", "Coimbatore", "B+", new DateOnly(2011, 2, 3), Teachers.ElementAt<Teacher>(0));
            Student s6 = new Student(6,3, 6, 2, "vaishali", "chennai", "607012", "8012456298", "trichy", "AB+", new DateOnly(2005, 11, 10), Teachers.ElementAt<Teacher>(1));
            return new ObservableCollection<Student> { s1, s2, s3, s4, s5, s6 };
        }

        public StaticViewModel() 
        {
            Teachers = StaticallyGenerateTeachers();
            Students = StaticallyGenerateStudents();
            
        }

        

    }
}
