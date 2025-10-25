public class Reference
{
    private string Book;
    private int Chapter;
    private int VerseStart;
    private int VerseFinish;

    public Reference(string _book, int _chapter, int _verseStart, int _verseFinish)
    {
        Book = _book;
        Chapter = _chapter;
        VerseStart = _verseStart;
        VerseFinish = _verseFinish;
    }

    public string GetReference()
    {
        if (VerseStart == VerseFinish)
            return $"{Book} {Chapter}:{VerseStart}";
        else
            return $"{Book} {Chapter}:{VerseStart}-{VerseFinish}";
        
    }

    public Reference(string _book, int _chapter, int _verse)
    {
        Book = _book;
        Chapter = _chapter;
        VerseStart = _verse;
        VerseFinish = _verse;
    }
    
}