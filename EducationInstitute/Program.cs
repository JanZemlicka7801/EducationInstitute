using EducationInstitute;

static void CreateModules()
{
    Console.WriteLine("Create new module...");

    Module module1 = CreateModuleFromInput();
    Console.WriteLine("New module created: " + module1);
}

static Module CreateModuleFromInput()
{
    Console.Write("Enter the Module ID: ");
    string moduleID = Console.ReadLine();

    Console.Write("Enter the Module Name: ");
    int moduleName = int.Parse(Console.ReadLine());

    Console.Write("Enter the number of Credits: ");
    int credits = int.Parse(Console.ReadLine());

    return new Module(moduleID, moduleName, credits);
}

CreateModules();