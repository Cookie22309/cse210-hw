using System.Runtime.CompilerServices;

public class Word
{
    private string _text;
    private bool _hiddenWord;

    public Word(string text)
    {
        _text = text;
        _hiddenWord = false;
    }
    public void Hide()
    {
        _hiddenWord = true;
    }
    public bool IsHidden()
    {
        return _hiddenWord;
    }
    public string GetDisplayText()
    {
    if (_hiddenWord)
    {
        return new string('_', _text.Length);
    }
    else
    {
        return _text;
    }
    }
}