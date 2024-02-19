using StudentInfo.Models;
using StudentInfo.ViewModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace StudentInfo.View;

[QueryProperty("SelectedStudent", "SelectedStudent")]
public partial class StudentDetails : ContentPage, INotifyPropertyChanged
{
	public event PropertyChangedEventHandler? PropertyChanged;

	Student student;
    public Student SelectedStudent
	{
		get => student; 
		set
		{
			student = value;
			onPropertyChanged(nameof(SelectedStudent));
		}
	}

    public StudentDetails()
	{
		InitializeComponent();
		BindingContext = this;
	}

	public void onPropertyChanged(string name)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}

    private async void SwipeItem_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"teacherdetails", new Dictionary<string, Object>
            {
                { "SelectedTeacher" , SelectedStudent.ClassTeacher }
            }); ;
    }
}