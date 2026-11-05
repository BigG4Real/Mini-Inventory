public class Weapon : Item
{
    public Weapon(string? question = null) : base(question) => SetDamge();
    
    int MinDamage = 1; 
    int MaxDamage = 100;
    void SetDamge()
    {
        MinDamage = Input.Int(0, int.MaxValue, "What Is the Least Damge?\nInput A Number");
        MaxDamage = Input.Int(0, int.MaxValue, "What Is the Max Damge?\nInput A Number");
        if(MaxDamage <= MinDamage)
        {
            SetDamge();
        }
    }
    public int Attack() => new Random().Next(MinDamage, (MaxDamage + 1));
    
    public override string ToString()
    {
        string text = base.ToString();
        text += $"Least Damge: {MinDamage}\n";
        text += $"Max Damge: {MaxDamage}\n";

        return text;
    }
}