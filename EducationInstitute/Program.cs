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

Student testStudent = new Student("D00260376", "Jan", "D00260376@dkit.student.ie", "Computing", 3);
Teacher testTeacher = new Teacher("D00260333", "Kinga", "D00260333@dkit.teacher.ie", 8, DateTime.Today);
Module toAdd = CreateModules();
testStudent.AddModule(toAdd);
testTeacher.AddModule(toAdd);
Console.WriteLine(testStudent);
Console.WriteLine(testTeacher);