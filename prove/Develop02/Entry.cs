using System;

public class Entry
{
    private string _dateText;
    private string _promptText;
    private string _responseText;
    private const string Sep = "~|~";

    public Entry(string dateText, string promptText, string responseText)
    {
        _dateText = dateText;
        _promptText = promptText;
        _responseText = responseText;
    }

    public string GetDate() => _dateText;
    public string GetPrompt() => _promptText;
    public string GetResponse() => _responseText;

    public override string ToString()
    {
        return $"{_dateText}\nPrompt: {_promptText}\nResponse: {_responseText}\n";
    }

    public string ToStorageString()
    {
        return $"{_dateText}{Sep}{_promptText}{Sep}{_responseText}";
    }

    public static Entry FromstorageString(string line)
    {
        var parts = line.Split(new[] { "~|~" }, StringSplitOptions.None);
        if (parts.Length != 3) return null;
        return new Entry(parts[0], parts[1], parts[2]);
    }
}