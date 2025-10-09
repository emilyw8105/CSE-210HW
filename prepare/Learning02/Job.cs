public class Job
{
    public string _Company = "";
    public string _JobTitle = "";
    public int _StartYear;
    public int _EndYear;

    public Job()
    {
    }
 public void Display()
    {
        Console.Write($"{_JobTitle} ({_Company}) {_StartYear}-{_EndYear}\n");
    }
}


