using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        string[] wordArray = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWord()
{
    Random random = new Random();
    List<Word> visibleWords = _words.Where(word => !word.IsHidden).ToList();
    if (visibleWords.Count > 0)
    {
        int index = random.Next(0, visibleWords.Count);
        visibleWords[index].Hide();
    }
}
    
    public bool AreAllWordsHidden()
    {
        return _words.All(word => word.IsHidden);
    }

    public void Display()
    {
        Console.WriteLine($"{_reference.Book} {_reference.Chapter}:{_reference.Verse}");
        foreach (var word in _words)
        {
            if (word.IsHidden)
                Console.Write("_ ");
            else
                Console.Write(word.Text + " ");
        }
        Console.WriteLine();
    }
}