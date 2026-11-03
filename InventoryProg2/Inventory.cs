public class Inventory()
{
    public List<Item> Items = new List<Item>();
    public void Display()
    {
        for (int i = 0; i < Items.Count; i++)
        {
            if(Items[i] is Weapon) Console.WriteLine($"Item: {Items[i].GetName()} (Weapon)\nWeight: {Items[i].GetWeight()}\nLeast Damge: {((Weapon)Items[i]).GetMinDamage()}\nMax Damge: {((Weapon)Items[i]).GetMaxDamage()}\n");
            if(Items[i] is Consumable) Console.WriteLine($"Item: {Items[i].GetName()} (Consumable)\nWeight: {Items[i].GetWeight()}\nUses Left: {((Consumable)Items[i]).GetUsesCurrent()}\n");
        }
        Console.WriteLine("Press Enter To Continue");
        Console.ReadLine();
        Console.Clear();
    }
}