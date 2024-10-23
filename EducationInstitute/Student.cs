namespace EducationInstitute;

public class Student : User
{
    private string CourseTitle { get; set; }
    private int CurrentYear { get; set; }
    private List<Module> StudentModules { get; set; }

    public Student(string userId, string name, string email, string courseTitle, int currentYear) : base(userId, name, email)
    {
        CourseTitle = courseTitle;
        CurrentYear = currentYear;
        StudentModules = new List<Module>();
    }

    public override string ToString()
    {
        return
            $"{base.ToString()}, {nameof(CourseTitle)}: {CourseTitle}, {nameof(CurrentYear)}: {CurrentYear}, {nameof(StudentModules)}: {StudentModules}";
    }
}