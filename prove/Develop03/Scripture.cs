public class Scripture
{
    private List<Word> _words;
    private Reference _reference;
    private Random _rand = new Random();
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] parts = text.Split(' ');
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }
    public void HideRandomWords(int count)
    {
        List<Word> notHidden = new List<Word>();
        foreach (Word i in _words)
        {
            if (!i.IsHidden())
            {
                notHidden.Add(i);
            }
        }
        if (notHidden.Count == 0)
            return;
        int hide = Math.Min(count, notHidden.Count);

        for (int i = 0; i < hide; i++)
        {
            int index = _rand.Next(notHidden.Count);
            notHidden[index].Hide();
            notHidden.RemoveAt(index);
        }
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word i in _words)
        {
            if (!i.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        string text = "";
        foreach (string w in displayWords)
        {
            text += w + " ";
        }
        text = text.TrimEnd();
        return _reference.GetDisplayText() + "\n" + text;
    }
}