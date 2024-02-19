using StudentInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.ViewModel
{
    class StudentDetailViewModel
    {
        public static Student SelectedStudent { get; set; }

        public StudentDetailViewModel()
        {
            
        }

        public static void GetStudent(int SId)
        {
            foreach(Student s in StaticModel.Students)
            {
                if(s.SId == SId) { SelectedStudent = s;break; }
            }
        }
    }
}
