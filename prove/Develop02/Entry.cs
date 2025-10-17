public class Entry
{
    public string _Title;
    public DateTime _Date;
    public string _Prompt;
    public string _Answer;
    public int rating;

    public Entry(string title, string prompt, string answer, int _Rating)
    {
        _Date = DateTime.Now;
        _Title = title;
        _Prompt = prompt;
        _Answer = answer;
        rating = _Rating;
    }
    public Entry() { }

    public override string ToString()
    {
        return $"Date: {_Date.ToShortDateString()}\n" +
        $"Title: {_Title}\n" +
        $"Rating: {rating}/10\n" +
        $"Prompt: {_Prompt}\n" +
        $"Answer: {_Answer}\n";
    }
    public void Display()
    {
        Console.Write($"{_Date = DateTime.Now}\nEntry: {_Title}\nPrompt: {_Prompt}:\n{_Answer}\nRating: {rating}");
    }
}