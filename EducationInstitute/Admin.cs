namespace EducationInstitute;

public class Admin : User
{
    private string Department { get; set; }
    private DateTime StartDate { get; set; }

    public Admin(string userId, string name, string email, string department, DateTime startDate) : base(userId, name, email)
    {
        Department = department;
        StartDate = startDate;
    }

    public Admin()
    {
        Department = "department";
        StartDate = DateTime.Today;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, {nameof(Department)}: {Department}, {nameof(StartDate)}: {StartDate}";
    }
}