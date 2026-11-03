public static class Input
{
    public static string Text(string question = "Type A Text!")
    {
        Console.WriteLine(question);
        string? text = Console.ReadLine();
        return text != string.Empty ? text : Text(question);
    }
    public static int Int(int min, int max, string question = "Type A Number!")
    {
        Console.WriteLine(question);
        string? text = Console.ReadLine();
        if(string.IsNullOrEmpty(text)) return Int(min, max, question);
        if(int.TryParse(text, out int num))
            return (num >= min && num <= max) ? num : Int(min, max, question);
        return Int(min, max, question);
    }
}