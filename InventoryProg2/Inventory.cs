public class Inventory()
{
    public List<Item> Items = new List<Item>();
    public string Display()
    {
        string infomation = "";
        for (int i = 0; i < Items.Count; i++)
        {
            infomation += $"{Items[i]}\n--------------------------\n";
        }
        return infomation;
    }
}