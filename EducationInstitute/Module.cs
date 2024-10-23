namespace EducationInstitute;

public class Module
{
    private string Title { get; set; }
    private int Stage { get; set; }
    public int Credits { get; set; }

    public Module(string title, int stage, int credits)
    {
        Title = title;
        Stage = stage;
        Credits = credits;
    }

    public override string ToString()
    {
        return $"{nameof(Title)}: {Title}, {nameof(Stage)}: {Stage}, {nameof(Credits)}: {Credits}";
    }
}