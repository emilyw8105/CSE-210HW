public class Writing : Assignment
{
    //define attributes
    private string _title;

    //constructor
    public Writing(string Title, string StudentName, string Topic) : base(StudentName, Topic)
    {
        _title = Title;
    }
    
    //Build methods
    public void Get_Writing()
    {
        //get title and student name
        string studentName = get_name();
        Console.WriteLine($"{_title} by {studentName}");
    }
}