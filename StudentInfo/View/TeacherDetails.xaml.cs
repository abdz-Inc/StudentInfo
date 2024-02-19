using StudentInfo.Models;
using StudentInfo.ViewModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace StudentInfo.View;

[QueryProperty("SelectedTeacher", "SelectedTeacher")]
public partial class TeacherDetails : ContentPage, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    Teacher teacher;
    public Teacher SelectedTeacher
    {
        get => teacher;
        set
        {
            teacher = value;
            onPropertyChanged(nameof(SelectedTeacher));
        }
    }

    public TeacherDetails()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public void onPropertyChanged(string name)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

}