namespace EducationInstitute;

public class Teacher : User, IEmployee
{
    private int DegreeLevel { get; set; }
    private DateTime StartDate { get; set; }

    public Teacher(string userId, string name, string email, int degreeLevel, DateTime startDate) : base(userId, name, email)
    {
        DegreeLevel = degreeLevel;
        StartDate = startDate;
    }

    public Teacher()
    {
        DegreeLevel = 0;
        StartDate = DateTime.Today;
    }

    public int GetSalary()
    {
        return 50000;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, {nameof(DegreeLevel)}: {DegreeLevel}, {nameof(StartDate)}: {StartDate}";
    }
    
    
}