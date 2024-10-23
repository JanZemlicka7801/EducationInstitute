using EducationInstitute;

static Module CreateModules()
{
    Console.WriteLine("Create new module...");

    Module module = CreateModuleFromInput();
    Console.WriteLine("New module created: " + module);
    
    return module;
}

static Module CreateModuleFromInput()
{
    Console.Write("Enter the Module title: ");
    string title = Console.ReadLine() ?? throw new InvalidOperationException();

    Console.Write("Enter the Module Stage: ");
    int stage = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

    Console.Write("Enter the number of Credits: ");
    int credits = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

    return new Module(title, stage, credits);
}

static int CountMature(List<Student> students)
{
    int count = 0;
    foreach (var student in students)
    {
        if (student.IsMature)
        {
            count++;
        }
    }
    return count;
}

Student testStudent1 = new Student("Jan Zemlicka",  "Computing", 3, true);
Student testStudent2 = new Student("Tom Hubert", "Software Development", 2, true);
Student testStudent3 = new Student("Lukas Niedel", "Computing", 1, false);
Student testStudent4 = new Student("Joe Rushin", "Data Analytics", 4, true);
Teacher testTeacher1 = new Teacher("Kinga Michalska", Teacher.DegreeLevel.HDip, DateTime.Today);
Teacher testTeacher2 = new Teacher("Dosia Danade", Teacher.DegreeLevel.Degree, DateTime.Today);
Teacher testTeacher3 = new Teacher("Emilia Von Stau", Teacher.DegreeLevel.Masters, DateTime.Today);
Teacher testTeacher4 = new Teacher("Olivia Lewonska", Teacher.DegreeLevel.PhD, DateTime.Today);
List<Student> students = new List<Student>() { testStudent1, testStudent2, testStudent3, testStudent4 };
List<Teacher> teachers = new List<Teacher>() { testTeacher1, testTeacher2, testTeacher3, testTeacher4 };

Module toAdd = CreateModules();
testStudent1.AddModule(toAdd);
testTeacher1.AddModule(toAdd);
Console.WriteLine(students[1]);
Console.WriteLine(teachers[0]);
Console.WriteLine($"There are {CountMature(students)} student/s that is/are mature.");