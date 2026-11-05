Character player = new();

player.AddItem(new Weapon("A New Shiny Weapon!\nEnter Name For The Weapon!"));
Console.Clear();

player.AddItem(new Consumable("A New Consumable!\nEnter Name For The Consumable"));
Console.Clear();

Console.WriteLine(player.DisplayInventory());
Console.WriteLine($"Press Enter To Continue!");
Console.ReadLine();
Console.Clear();

PickUpHelmet();
void PickUpHelmet()
{   
    Console.Clear();
    string helment = Input.Text("A New Shiny Helment!\nDo You Want To Pick It Up?\n[Y/N]");
    if(helment == "y" || helment == "Y")
    {
        Console.Clear();
        player.AddItem(new Armor("What Type Of Armor Is It?!"));
    }
    else if(helment != "n" && helment != "N")
    {
        PickUpHelmet();
    }
    Console.Clear();
}

Console.WriteLine(player.DisplayInventory());
Console.WriteLine($"Press Enter To Continue!");
Console.ReadLine();
Console.Clear();