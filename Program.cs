Console.Write("Enter username: ");
string username = Console.ReadLine();
Console.Write("Enter password: ");
string password = Console.ReadLine();
Console.Write("Enter user ID: ");
uint userId = uint.Parse(Console.ReadLine());

// Outputs
bool userIsAdmin = userId > 65536;
bool usernameValid = username.Length >= 3;
bool passwordContainsSpecial = password.Contains('$') || password.Contains('|') || password.Contains('@');
bool passwordValid = passwordContainsSpecial &&
                     ((userIsAdmin && password.Length >= 20) || (!userIsAdmin && password.Length >= 16));