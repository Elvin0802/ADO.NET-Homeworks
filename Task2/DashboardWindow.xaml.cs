using Microsoft.Extensions.Configuration;
using System.Windows;

namespace Task2;

public partial class DashboardWindow : Window
{
	public DashboardWindow()
	{
		InitializeComponent();
		string connectionString = App._configuration!.GetConnectionString("DefaultConnection")!;
	}
}
