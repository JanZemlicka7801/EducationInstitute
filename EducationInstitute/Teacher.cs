namespace EducationInstitute;

public class Teacher : User, IEmployee
{
    private int DegreeLevel { get; set; }
    private DateTime StartDate { get; set; }
    private List<Module> TeacherModules { get; set; }

    public Teacher(string userId, string name, string email, int degreeLevel, DateTime startDate) : base(userId, name, email)
    {
        DegreeLevel = degreeLevel;
        StartDate = startDate;
        TeacherModules = new List<Module>();
    }

    public void AddModule(Module module)
    {
        TeacherModules.Add(module);
    }
    
    public int GetSalary()
    {
        return 50000;
    }

    public override string ToString()
    {
        string moduleList = "Modules: ";
        if (TeacherModules.Count > 0)
        {
            foreach (Module module in TeacherModules)
            {
                moduleList += module + "; ";
            }
        }
        else
        {
            moduleList += "No modules assigned.";
        }
        
        return
            $"{base.ToString()}, {nameof(DegreeLevel)}: {DegreeLevel}, {nameof(StartDate)}: {StartDate}, {moduleList}";
    }
}