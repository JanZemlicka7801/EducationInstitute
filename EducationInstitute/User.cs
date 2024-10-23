namespace EducationInstitute;

public class User
{
    private static int _userId = 0;
    
    private int UserId {get; set;}
    private string Name {get; set;}
    private string Email {get; set;}

    protected User(string name, string email)
    {
        UserId = _userId++;
        Name = name;
        Email = email;
    }

    public User(string name)
    {
        UserId = _userId++;
        Name = name;
        Email = GenerateEmail(name);
    }

    public string GenerateEmail(string name)
    {
        string FirstName = name.Split(' ').First().ToLower();
        string LastName = name.Split(' ').Last().ToLower();

        return $"{FirstName[0]}{LastName[0]}{LastName[1]}{LastName[2]}{UserId}@dkit.ie";
    }
    
    public override string ToString()
    {
        return $"{nameof(UserId)}: {UserId}, {nameof(Name)}: {Name}, {nameof(Email)}: {Email}";
    }
}