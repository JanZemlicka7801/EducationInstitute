namespace EducationInstitute;

public class User
{
    private static int _userId = 0;
    
    private int UserId {get; set;}
    private string Name {get; set;}
    private string Email {get; set;}

    protected User( string name, string email)
    {
        UserId = _userId++;
        Name = name;
        Email = email;
    }
    
    public override string ToString()
    {
        return $"{nameof(UserId)}: {UserId}, {nameof(Name)}: {Name}, {nameof(Email)}: {Email}";
    }
}