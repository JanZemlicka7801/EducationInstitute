namespace EducationInstitute;

public class Student : User
{
    private string CourseTitle { get; set; }
    private int CurrentYear { get; set; }

    public Student(string userId, string name, string email, string courseTitle, int currentYear) : base(userId, name, email)
    {
        CourseTitle = courseTitle;
        CurrentYear = currentYear;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, {nameof(CourseTitle)}: {CourseTitle}, {nameof(CurrentYear)}: {CurrentYear}";
    }
}