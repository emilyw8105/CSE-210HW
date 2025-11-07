public class Word
{   //define attributes
    private string word;
    private bool isHidden;
    //constructor to intitialize both attributes
    public Word(string _word)
    {
        word = _word;
        isHidden = false;
    }
    //method that gets the word and either keeps it, or replaces it with underscores
    public string GetWord()
    {
        if (isHidden == true)
            return new string('_', word.Length);
        else
        {
            return word;
        }

    }
    //method for is hidden to allow for ishidden to be accessed in main
    public bool IsHidden()
    {
        return isHidden;
    }
    //method to make ishidden true to replace word with underscores
    public void Hide()
    {
        isHidden = true;
    }
}