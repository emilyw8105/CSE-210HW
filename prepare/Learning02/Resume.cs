public class Resume {
        public string _Name = "";
        public List<Job> _Jobs = new List<Job>();

    public void Display()
    {
        Console.Write($"Name: {_Name} \n");
        Console.Write("Jobs: \n");

        foreach (Job job in _Jobs)
        {
            job.Display();
        }
        }
    }