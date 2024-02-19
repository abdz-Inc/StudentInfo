using StudentInfo.View;

namespace StudentInfo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("studentdetails", typeof(StudentDetails));
            Routing.RegisterRoute("teacherdetails", typeof(TeacherDetails));
        }
    }
}
