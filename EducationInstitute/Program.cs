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
    string title = Console.ReadLine();

    Console.Write("Enter the Module Stage: ");
    int stage = int.Parse(Console.ReadLine());

    Console.Write("Enter the number of Credits: ");
    int credits = int.Parse(Console.ReadLine());

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

Student testStudent1 = new Student("D00260376", "Jan", "D00260376@dkit.student.ie", "Computing", 3, true);
Student testStudent2 = new Student("D00260377", "Tom", "D00260377@dkit.student.ie", "Software Development", 2, true);
Student testStudent3 = new Student("D00260378", "Lukas", "D00260378@dkit.student.ie", "Computing", 1, false);
Student testStudent4 = new Student("D00260379", "Joe", "D00260379@dkit.student.ie", "Data Analytics", 4, true);
Teacher testTeacher1 = new Teacher("D00000001", "Kinga", "D00000001@dkit.teacher.ie", Teacher.DegreeLevel.HDip, DateTime.Today);
Teacher testTeacher2 = new Teacher("D00000002", "Dosia", "D00000002@dkit.teacher.ie", Teacher.DegreeLevel.Degree, DateTime.Today);
Teacher testTeacher3 = new Teacher("D00000003", "Emilia", "D00000003@dkit.teacher.ie", Teacher.DegreeLevel.Masters, DateTime.Today);
Teacher testTeacher4 = new Teacher("D00000004", "Olivia", "D00000004@dkit.teacher.ie", Teacher.DegreeLevel.PhD, DateTime.Today);
List<Student> students = new List<Student>() { testStudent1, testStudent2, testStudent3, testStudent4 };
Module toAdd = CreateModules();
testStudent1.AddModule(toAdd);
testTeacher1.AddModule(toAdd);
Console.WriteLine(testStudent1);
Console.WriteLine(testTeacher1);
Console.WriteLine($"There are {CountMature(students)} student/s that is/are mature.");