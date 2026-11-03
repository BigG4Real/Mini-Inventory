public abstract class Item
{
    public Item()
    {
        Name = Input.Text("Input A Text");
        Console.Clear();
        Weight = Input.Int(0, int.MaxValue, "How Much Dose It Weight?\nInput A Number");
        Console.Clear();
    }

    string Name;
    float Weight;

    public string GetName() => Name;
    public float GetWeight() => Weight;
}