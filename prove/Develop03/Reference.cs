public class Reference
{   //define attributes
    private string Book;
    private int Chapter;
    private int VerseStart;
    private int VerseFinish;
    //constructor to intitialize attributes and allows for multiple verses in reference
    public Reference(string _book, int _chapter, int _verseStart, int _verseFinish)
    {
        Book = _book;
        Chapter = _chapter;
        VerseStart = _verseStart;
        VerseFinish = _verseFinish;
    }
    //method that formats the reference based on the book, chapter, and verse(s)
    public string GetReference()
    {
        if (VerseStart == VerseFinish)
            return $"{Book} {Chapter}:{VerseStart}";
        else
            return $"{Book} {Chapter}:{VerseStart}-{VerseFinish}";
        
    }
    //constructor for a reference with only one verse
    public Reference(string _book, int _chapter, int _verse)
    {
        Book = _book;
        Chapter = _chapter;
        VerseStart = _verse;
        VerseFinish = _verse;
    }
    
}