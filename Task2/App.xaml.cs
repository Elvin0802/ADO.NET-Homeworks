using System.Windows;

namespace Task2;

public partial class App : Application
{
	public static DashboardWindow? DashboardWindow { get; set; }

	private void StartApp(object sender, StartupEventArgs e)
	{
		DashboardWindow = new DashboardWindow();

		DashboardWindow.ShowDialog();
	}
}
