namespace Task1.Models;

public class User
{
	#region Private Fields

	private int? _id;
	private string? _name;
	private string? _surname;
	private string? _username;
	private string? _password;
	private sbyte? _age;

	#endregion

	#region Public Properties

	public int? Id { get => _id; set => _id=value; }
    public string? Name { get => _name; set => _name=value; }
    public string? Surname { get => _surname; set => _surname=value; }
    public string? Username { get => _username; set => _username=value; }
    public string? Password { get =>_password; set => _password=value; }
    public sbyte? Age { get => _age; set => _age=value; }

	#endregion

	public User() { }
	public User(int id, string name, string surname, string username, string password, sbyte age)
	{
		Id=id;
		Name=name;
		Surname=surname;
		Username=username;
		Password=password;
		Age=age;
	}

	public override string ToString() => $"{Name} {Surname}";
}
