namespace EducationInstitute;

public class User
{
    private string UserId {get; set;}
    private string Name {get; set;}
    private string Email {get; set;}

    protected User(string userId, string name, string email)
    {
        UserId = userId;
        Name = name;
        Email = email;
    }
    
    public override string ToString()
    {
        return $"{nameof(UserId)}: {UserId}, {nameof(Name)}: {Name}, {nameof(Email)}: {Email}";
    }
}