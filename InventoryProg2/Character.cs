public class Character()
{
    int Hp;
    string? Name;
    Inventory Backpack = new Inventory();
    public void HealBy(int health)
    {
        Hp += health;
    }
    public void AddItem(Item itemToAdd)
    {
        Backpack.Items.Add(itemToAdd);
    }
    public void DisplayInventory()
    {
        Backpack.Display();
    }
}