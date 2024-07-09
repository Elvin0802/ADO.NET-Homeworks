using Microsoft.Extensions.Configuration;
using System.Windows;

namespace Task2;

public partial class App : Application
{
	public static IConfigurationRoot? _configuration;
	public static DashboardWindow? DashboardWindow { get; set; }

	private void StartApp(object sender, StartupEventArgs e)
	{
		DashboardWindow = new DashboardWindow();

		_configuration = new ConfigurationBuilder()
		.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
		.AddJsonFile("appsettings.json")
		.Build();

		DashboardWindow.ShowDialog();
	}
}
