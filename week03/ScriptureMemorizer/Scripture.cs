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
        int _hiddenCount = 0;
        List<int> availableIndices = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                availableIndices.Add(i);
            }
        }

        while (_hiddenCount < _numberToHide && availableIndices.Count > 0)
        {
            int _index = _random.Next(availableIndices.Count);
            int _selectedIndex = availableIndices[_index];
            _words[_selectedIndex].Hide();
            availableIndices.RemoveAt(_index);
            _hiddenCount++;
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
