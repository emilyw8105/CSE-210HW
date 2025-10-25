using System.ComponentModel.DataAnnotations;

public class Scripture
{
    public List<Word> _word = new List<Word>();
    private Reference _ref;

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

    public bool AllHidden()
    {
        return _word.All(w => w.IsHidden());
    }

    public Scripture(List<Word> words, Reference reference)
    {
        _word = words;
        _ref = reference; 
    }
}