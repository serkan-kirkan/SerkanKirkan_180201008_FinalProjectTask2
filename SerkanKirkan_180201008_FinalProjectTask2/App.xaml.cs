
using SerkanKirkan_180201008_FinalProjectTask2.DatabaseTrans;

namespace SerkanKirkan_180201008_FinalProjectTask2;

public partial class App : Application
{
	public static DBTrans DBTrans { get; private set; }
	public App(DBTrans dBTrans)
	{
		InitializeComponent();

		MainPage = new AppShell();
		DBTrans = dBTrans;
	}
}
