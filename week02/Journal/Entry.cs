public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public string Display()
    {
        string entry = _date + " " + _promptText + " " + _entryText;
        Console.WrtieLine(entry);
        return entry;
    }
}