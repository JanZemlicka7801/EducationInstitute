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

    public void AddModule(Module module)
    {
        StudentModules.Add(module);
    }

    public override string ToString()
    {
        
        string moduleList = "Modules: ";
        if (StudentModules.Count > 0)
        {
            foreach (Module module in StudentModules)
            {
                moduleList += module + "; ";
            }
        }
        else
        {
            moduleList += "No modules assigned.";
        }
        
        return
            $"{base.ToString()}, {nameof(CourseTitle)}: {CourseTitle}, {nameof(CurrentYear)}: {CurrentYear}, {moduleList}";
    }
}