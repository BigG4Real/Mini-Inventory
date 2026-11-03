Character player = new();
Console.WriteLine("A New Shiny Weapon!");
player.AddItem(new Weapon());
Console.Clear();
Console.WriteLine("A New Consumable!");
player.AddItem(new Consumable());
Console.Clear();
player.DisplayInventory();
Console.WriteLine("A New Shiny Helment!");
PickUpHelmet();
void PickUpHelmet()
{
    string helment = Input.Text("Do You Want To Pick It Up?\n[Y/N]");
    if(helment == "y" || helment == "Y")
    {
        Console.WriteLine("What Is It!");
        player.AddItem(new Armor());
        Console.Clear();
    }
    else if(helment != "n" && helment != "N")
    {
        PickUpHelmet();
        Console.Clear();
    }
}
Console.Clear();

Console.ReadLine();