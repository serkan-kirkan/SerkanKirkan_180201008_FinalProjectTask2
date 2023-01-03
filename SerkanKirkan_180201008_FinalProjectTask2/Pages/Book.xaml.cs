using SerkanKirkan_180201008_FinalProjectTask2.Models;
using SQLite;

namespace SerkanKirkan_180201008_FinalProjectTask2;

public partial class Book : ContentPage
{

    public Book()
	{


		InitializeComponent();
		Book_list_view.ItemsSource=App.DBTrans.GetAllBooks();
        
        App.DBTrans.Update();
        Picker picker=new Picker { Title="cates"};
        picker.ItemsSource= results;
        
        
    }


    private void add_book_Clicked(object sender, EventArgs e)
    {
        App.DBTrans.AddBook(new Models.BookClass
        {
            Book_Name = book_name.Text,
            Book_Author = book_author.Text,
            Book_Page = book_page.Text
        });
        Book_list_view.ItemsSource = App.DBTrans.GetAllBooks();
    }
    private void show_book_Clicked(object sender, EventArgs e)
    {
        Book_list_view.ItemsSource = App.DBTrans.GetAllBooks();
    }

    private void book_delete_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteBook((int)button.BindingContext);
        Book_list_view.ItemsSource = App.DBTrans.GetAllBooks();
    }
}

