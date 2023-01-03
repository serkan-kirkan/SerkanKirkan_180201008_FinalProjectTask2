namespace SerkanKirkan_180201008_FinalProjectTask2;

public partial class Department : ContentPage
{
	public Department()
	{
		InitializeComponent();
		Department_list_view.ItemsSource = App.DBTrans.GetAllDepartments();
	}

	private void add_Clicked(object sender, EventArgs e)
	{
		App.DBTrans.AddDepartment(new Models.DepartmentClass() 
		{
            Department_Name = department_name.Text
        });
		Department_list_view.ItemsSource = App.DBTrans.GetAllDepartments();
	}

	private void show_Clicked(object sender, EventArgs e)
	{
		Department_list_view.ItemsSource = App.DBTrans.GetAllDepartments();
	}

	private void delete_Clicked(object sender, EventArgs e)
	{
		Button button = (Button)sender;
		App.DBTrans.DeleteDepartment((int)button.BindingContext);
		Department_list_view.ItemsSource=App.DBTrans.GetAllDepartments();
	}
}