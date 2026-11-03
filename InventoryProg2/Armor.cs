public class Armor : Item
{
    public Armor() =>
        Protection = Input.Int(0, int.MaxValue, "What Is the Protection On The Armor?\nInput A Number");
    float Protection;
}