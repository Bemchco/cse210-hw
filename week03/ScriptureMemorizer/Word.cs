public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string _text)
    {
        this._text = _text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetText()
    {
        return _isHidden ? "_" : _text;
    }
}
