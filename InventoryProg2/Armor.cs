public class Armor : Item
{
    public Armor(string? question = null) : base(question) =>
        Protection = Input.Int(0, int.MaxValue, "What Is the Protection On The Armor?\nInput A Number");
    float Protection;

    public override string ToString()
    {
        string text = base.ToString();
        text += $"Protection: {Protection}\n";

        return text;
    }
}