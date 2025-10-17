public class Journal
{
    public string _Name;
    public List<Entry> _Entries = new List<Entry>();

    public static List<string> Prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "How did I see the hand of the Lord in my life today?",
        "What do I want to remember about today?",
        "If I had one thing I could do over today, what would it be?",
        "What made me happier today?"
    };
    public void NewEntry()
    {
        Console.Write("Write a title for today's entry: \n");
        string title = Console.ReadLine();

        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Count)];

        Console.Write($"Prompt: {prompt}");
        Console.Write(">");
        string answer = Console.ReadLine();

        Console.Write("What is your rating for today? ");
        int _Rating;
        while(!int.TryParse(Console.ReadLine(), out _Rating)|| _Rating < 1 || _Rating > 10)
        {
            Console.Write("Please enter a number between 1 and 10: ");
        }

        _Entries.Add(new Entry(title, prompt, answer, _Rating));
    }
    public void Display()
    {
        Console.Write($"{_Name}:\n");

        if (_Entries.Count == 0)
        {
            Console.Write("There are no entries to display. ");
        }
        else
        {
            foreach (Entry entry in _Entries)
            {
                entry.Display();
                Console.Write("\n");
            }
        }
    } 
    public void Load(string filename)
{
    if (!File.Exists(filename))
    {
        Console.WriteLine("File not found.\n");
        return;
    }

    _Entries.Clear();

    using (StreamReader streamreader = new StreamReader(filename))
    {
        // First line is the journal name
        _Name = streamreader.ReadLine();

        while (!streamreader.EndOfStream)
        {
            string line = streamreader.ReadLine();
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split('|');

            if (parts.Length >= 5)
            {
                    DateTime date = DateTime.Parse(parts[0]);
                    string title = parts[1];
                    string prompt = parts[2];
                    string answer = parts[3];
                    int _Rating = int.Parse(parts[4]);
                    
                _Entries.Add(new Entry(title, prompt, answer, _Rating) { _Date = DateTime.Now });
            }
        }
    }
}
    public void Save(string filename)
    {
        using (StreamWriter streamWriter = new StreamWriter(filename))
        {
            streamWriter.WriteLine(_Name); /*Saves name before the list of entries*/
            foreach (Entry entry in _Entries) /*Saves the list of entries to the file*/
            {
                 streamWriter.WriteLine($"{entry._Date:MM-dd-yyyy}|Entry: {entry._Title}|Prompt: {entry._Prompt}|Answer: {entry._Answer}|{entry.rating}");
            }
        }
    }
    
    
}
