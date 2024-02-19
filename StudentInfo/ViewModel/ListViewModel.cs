using StudentInfo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo.ViewModel
{
    
    class ListViewModel
    {
        public ObservableCollection<Student> Students { get; set; }
        public ObservableCollection<Teacher> Teachers { get; set; }

        public ListViewModel()
        {
            Students = StaticModel.Students;
            Teachers = StaticModel.Teachers;
        }
    }
}
