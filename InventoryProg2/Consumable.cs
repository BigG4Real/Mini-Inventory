public class Consumable : Item
{
    public Consumable() =>
        SetConsumable();
    
    int UsesMax;
    int UsesCurrent;
    
    void SetConsumable()
    {
        UsesMax = Input.Int(0, int.MaxValue, "How Many Times Can You Use It?\nInput A Number");
        UsesCurrent = UsesMax;
        Console.Clear();
    }
    public void Use(Character target)
    {
        if(UsesCurrent <= 0)
        {
            Console.WriteLine("No uses left");
            return;
        }
        target.HealBy(10);
        UsesCurrent--;
    }

    public int GetUsesCurrent() => UsesCurrent;
}