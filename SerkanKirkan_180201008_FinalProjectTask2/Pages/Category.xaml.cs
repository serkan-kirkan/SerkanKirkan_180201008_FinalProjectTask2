namespace SerkanKirkan_180201008_FinalProjectTask2;

public partial class Category : ContentPage
{
	public Category()
	{
		InitializeComponent();
	}

	private void add_Clicked(object sender, EventArgs e)
	{
		App.DBTrans.AddCategory(new Models.CategoryClass
		{
			Category_Name = category_name.Text
		});
		Category_list_view.ItemsSource=App.DBTrans.GetAllCategories();
	}

	private void show_Clicked(object sender, EventArgs e)
	{
		Category_list_view.ItemsSource = App.DBTrans.GetAllCategories();
	}

	private void delete_Clicked(object sender, EventArgs e)
	{
		Button button = (Button)sender;
		App.DBTrans.DeleteCategory((int)button.BindingContext);
		Category_list_view.ItemsSource = App.DBTrans.GetAllCategories();
	}
}