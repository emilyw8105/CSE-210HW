public class Math : Assignment
{
    //define attributes
    private string _section;
    private string _problems;

    //constructor
    public Math(string Section, string Problems, string StudentName, string Topic) : base(StudentName, Topic)
    {
        _section = Section;
        _problems = Problems;
    }
    
    //build methods
    public void display()
    {
        Console.WriteLine($"Section {_section} Problems {_problems}");
    }
}