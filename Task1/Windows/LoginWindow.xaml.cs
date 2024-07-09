using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Input;

namespace Task1.Windows;

public partial class LoginWindow : Window
{
	public LoginWindow()
	{
		InitializeComponent();
		DataContext = this;
	}

	private void LoginButtonClickExecute(object sender, RoutedEventArgs e)
	{
		SqlDataReader? reader = null;
		SqlCommand? cmd = null;
		string connectionString = App._configuration!.GetConnectionString("DefaultConnection")!;

		using (SqlConnection connection = new SqlConnection(connectionString))
		{
			var querry = @"SELECT * FROM MainUsers";

			cmd = new(querry, connection);

			connection.Open();
			reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				if (reader["Username"].ToString() == UsernameTBox.Text)
				{
					if (reader["Password"].ToString() == PasswordTBox.Text)
					{
						MessageBox.Show($"Welcome {reader["Name"]} {reader["Surname"]}.", "Message");
						return;
					}
				}
			}
		}
	}

	private void RegisterButtonClickExecute(object sender, RoutedEventArgs e)
	{
		this.Hide();

		App.RegisterWindow?.ShowDialog();
	}

	private void ExitButtonExecute(object sender, RoutedEventArgs e)
	{
		App.AppExit();
	}

	private void Window_MouseDown(object sender, MouseButtonEventArgs e)
	{
		App.MoveWindow(e, this);
	}
}
