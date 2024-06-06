public class UserService
{
    private string username;

    public string GetUsername()
    {
        return username;
    }

    public void SetUsername(string value)
    {
        username = value;
        Console.WriteLine(username);
    }

}
