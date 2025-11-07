public class Assignment
{
    //define attributes
    private string _studentName;
    private string _topic;

    //constructor
    public Assignment(string StudentName, string Topic)
    {
        _studentName = StudentName;
        _topic = Topic;
    }

    //build methods
    public string get_name()
    {
        return _studentName;
    }

    public string get_topic()
    {
        return _topic;
    }
    
    public void assignment_summary()
    {
        //store summary of assignments for both math and writing
        Console.WriteLine($"{_studentName} - {_topic}");
    }
}