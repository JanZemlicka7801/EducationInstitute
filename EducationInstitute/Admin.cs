namespace EducationInstitute;

public class Admin : User, IEmployee
{
    private string Department { get; set; }
    private DateTime StartDate { get; set; }

    public Admin(string name, string email, string department, DateTime startDate) : base(name, email)
    {
        Department = department;
        StartDate = startDate;
    }
    
    public int GetSalary()
    {
        return 40000;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, {nameof(Department)}: {Department}, {nameof(StartDate)}: {StartDate}";
    }
}