public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference _reference, string _text)
    {
        this._reference = _reference;
        _words = new List<Word>();
        foreach (string word in _text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int _numberToHide)
    {
        Random _random = new Random();
        for (int i = 0; i < _numberToHide; i++)
        {
            int _index = _random.Next(_words.Count);
            _words[_index] = new Word("_");
        }
    }
    public string GetFullText()
    {
        return string.Join(" ", _words.Select(w => w.GetText()));
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.GetText() == "_");
    }
}