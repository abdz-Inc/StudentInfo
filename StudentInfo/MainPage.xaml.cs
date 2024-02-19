using StudentInfo.Models;
using StudentInfo.ViewModel;
using System.Collections.ObjectModel;

namespace StudentInfo
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Student> students;
        public ObservableCollection<Student> Students {  get { return students; }

            set {  students = value; }
                }
        StaticViewModel StaticViewModel { get; set; }

        public MainPage( StaticViewModel staticViewModel)
        {
            InitializeComponent();
            Students = staticViewModel.Students;
            BindingContext = this;
        }

        private async void ListView_ItemSelectedAsync(object sender, ItemTappedEventArgs e)
        {
            ListView lv = sender as ListView;
            await Shell.Current.GoToAsync($"studentdetails", new Dictionary<string, Object>
            {
                { "SelectedStudent" , lv.SelectedItem }
            }); ;
        }

        private void SwipeItem_Clicked(object sender, EventArgs e)
        {
            Student? s = ((SwipeItem)sender)?.CommandParameter as Student;
            Console.WriteLine(s.Name);
            Students.Remove(s);
        }
    }

}
