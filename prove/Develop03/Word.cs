public class Word
{
    private string word;
    private bool isHidden;

    public Word(string _word)
    {
        word = _word;
        isHidden = false;
    }
    public string GetWord()
    {
        if (isHidden == true)
            return new string('_', word.Length);
        else
        {
            return word;
        }

    }

    public bool IsHidden()
    {
        return isHidden;
    }
    
    public void Hide()
    {
        isHidden = true;
    }
}