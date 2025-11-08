public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public string Display()
    {
        string _text = _date + " " + _promptText + " " + _entryText;
        Console.WrtieLine(_text);
        return _text;
    }
}