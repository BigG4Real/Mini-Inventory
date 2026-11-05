public abstract class Item
{
    public Item(string? question)
    {
        if(question == null) question = "Input A Text!";
        Name = Input.Text(question);
        Weight = Input.Int(0, int.MaxValue, "How Much Dose It Weight?\nInput A Number");
    }

    string Name;
    float Weight;

    public override string ToString()
    {
        string text = "";
        text += $"Item: {Name}\n";
        text += $"Type: {this.GetType().Name}\n";
        text += $"Weight: {Weight}\n";

        return text;
    }
}