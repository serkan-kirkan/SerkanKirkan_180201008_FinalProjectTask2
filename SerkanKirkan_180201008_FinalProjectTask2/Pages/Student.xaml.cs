namespace SerkanKirkan_180201008_FinalProjectTask2;

public partial class Student : ContentPage
{
	public Student()
	{
		InitializeComponent();
		Student_list_view.ItemsSource = App.DBTrans.GetAllStudent();
	}

	private void add_Clicked(object sender, EventArgs e)
	{
		App.DBTrans.AddStudent(new Models.StudentClass
		{
			Student_NameSurname = student_namesurname.Text,
			Department_Name = student_department.Text
		});
		Student_list_view.ItemsSource = App.DBTrans.GetAllStudent();
	}

	private void show_Clicked(object sender, EventArgs e)
	{
		Student_list_view.ItemsSource=App.DBTrans.GetAllStudent();
	}

	private void delete_Clicked(object sender, EventArgs e)
	{
		Button button = (Button)sender;
		App.DBTrans.DeleteStudent((int)button.BindingContext);
		Student_list_view.ItemsSource = App.DBTrans.GetAllStudent();
		
	}
}