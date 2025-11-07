using System.ComponentModel.DataAnnotations;

public class Scripture
{   //define attributes
    public List<Word> _word = new List<Word>();
    private Reference _ref;
    //Display method that print the scripture content
    public void Display()
    {
        Console.Write(_ref.GetReference());
        Console.Write("\n");

        foreach (var word in _word)
        {
            Console.Write(word.GetWord() + " ");
        }
        Console.WriteLine();
    }
    //Hide words method that uses an index and iterates through the list to hide words
    public void HideWords(List<Word> _word, int size)
    {
        Random random = new Random();
        int hiddenSize = 0;

        while (hiddenSize < size)
        {
            int index = random.Next(_word.Count);
            _word[index].Hide();
            hiddenSize++;
        }

    }
    //method to tell when all the words are hidden
    public bool AllHidden()
    {
        return _word.All(w => w.IsHidden());
    }
    //constructor that initializes the attributes
    public Scripture(List<Word> words, Reference reference)
    {
        _word = words;
        _ref = reference; 
    }
}