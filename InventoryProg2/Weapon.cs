public class Weapon : Item
{
    public Weapon() =>
       SetDamge();
       
    int MinDamage = 1; 
    int MaxDamage = 100;
    void SetDamge()
    {
        MinDamage = Input.Int(0, int.MaxValue, "What Is the Least Damge?\nInput A Number");
        Console.Clear();
        MaxDamage = Input.Int(0, int.MaxValue, "What Is the Max Damge?\nInput A Number");
        Console.Clear();
        if(MaxDamage <= MinDamage)
        {
            Console.WriteLine("Invalid Inputs!");
            SetDamge();
        }
    }
    public int Attack() => new Random().Next(MinDamage, (MaxDamage + 1));
    
    public int GetMinDamage() => MinDamage;
    public int GetMaxDamage() => MaxDamage;
}